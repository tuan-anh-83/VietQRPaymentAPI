﻿namespace VietQRPaymentAPI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreate = new System.Windows.Forms.Button();
            this.cb_nganhang = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSTK = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cb_template = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoTien = new System.Windows.Forms.NumericUpDown();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtInfo = new DevExpress.XtraEditors.TextEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cb_nganhang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_template.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(49, 190);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(197, 43);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create VietQR payment";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_nganhang
            // 
            this.cb_nganhang.Location = new System.Drawing.Point(45, 77);
            this.cb_nganhang.Name = "cb_nganhang";
            this.cb_nganhang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_nganhang.Properties.NullText = "";
            this.cb_nganhang.Properties.PopupView = this.gridLookUpEdit1View;
            this.cb_nganhang.Size = new System.Drawing.Size(192, 20);
            this.cb_nganhang.TabIndex = 1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(45, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Ngân hàng:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(278, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Số tài khoản:";
            // 
            // txtSTK
            // 
            this.txtSTK.EditValue = " 0721000584901";
            this.txtSTK.Location = new System.Drawing.Point(278, 77);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(197, 20);
            this.txtSTK.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(524, 58);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Template:";
            // 
            // cb_template
            // 
            this.cb_template.Location = new System.Drawing.Point(524, 77);
            this.cb_template.Name = "cb_template";
            this.cb_template.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_template.Properties.Items.AddRange(new object[] {
            "compact",
            "compact2",
            "qr_only",
            "print"});
            this.cb_template.Size = new System.Drawing.Size(197, 20);
            this.cb_template.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(47, 108);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Số tiền:";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(49, 130);
            this.txtSoTien.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(187, 20);
            this.txtSoTien.TabIndex = 8;
            this.txtSoTien.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(278, 114);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Tên tài khoản:";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.EditValue = "NGUYEN THAO";
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(278, 133);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(197, 20);
            this.txtTenTaiKhoan.TabIndex = 10;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(524, 114);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(76, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Thông tin thêm:";
            // 
            // txtInfo
            // 
            this.txtInfo.EditValue = "DONATE LAPTRINHVB.NET";
            this.txtInfo.Location = new System.Drawing.Point(524, 133);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(197, 20);
            this.txtInfo.TabIndex = 12;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ngân hàng";
            this.gridColumn1.FieldName = "custom_name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(424, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(426, 177);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(82, 13);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "VietQR Payment:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 512);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cb_template);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtSTK);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cb_nganhang);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[C#] VietQR payment API - https://laptrinhvb.net";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cb_nganhang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_template.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private DevExpress.XtraEditors.GridLookUpEdit cb_nganhang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSTK;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cb_template;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.NumericUpDown txtSoTien;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtTenTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}

