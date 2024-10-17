using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace VietQRPaymentAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private  void button1_Click(object sender, EventArgs e)
        {

            //"accountNo": 113366668888,
            //"accountName": "QUY VAC XIN PHONG CHONG COVID",
            //"acqId": 970415,
            //"amount": 79000,
            //"addInfo": "Ung Ho Quy Vac Xin",
            //"format": "text",
            //"template": "compact"
            var apiRequest = new ApiRequest();
            apiRequest.acqId = Convert.ToInt32( cb_nganhang.EditValue.ToString());
            apiRequest.accountNo = long.Parse( txtSTK.Text);
            apiRequest.accountName = txtTenTaiKhoan.Text;
            apiRequest.amount = Convert.ToInt32( txtSoTien.Text);
            apiRequest.format = "text";
            apiRequest.template = cb_template.Text;
            var jsonRequest = JsonConvert.SerializeObject(apiRequest);
            // use restsharp for request api.
            var client = new RestClient("https://api.vietqr.io/v2/generate");
            var request = new RestRequest();

            request.Method = Method.Post;
            request.AddHeader("Accept", "application/json");
            
            request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

            var response = client.Execute(request);
            var content = response.Content; 
            var dataResult = JsonConvert.DeserializeObject<ApiResponse>(content);


            var image = Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));
            pictureBox1.Image = image;


        }

        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                var htmlData = client.DownloadData("https://api.vietqr.io/v2/banks");
                var bankRawJson = Encoding.UTF8.GetString(htmlData);
                var listBankData = JsonConvert.DeserializeObject<Bank>(bankRawJson);

                cb_nganhang.Properties.DataSource = listBankData.data;   // list banks
                cb_nganhang.Properties.DisplayMember = "custom_name";
                cb_nganhang.Properties.ValueMember = "bin";
                cb_nganhang.EditValue = listBankData.data.FirstOrDefault().bin;
                cb_template.SelectedIndex = 0;
            }
        }
    }
}
