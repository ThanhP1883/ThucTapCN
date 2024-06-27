namespace BTLthu2
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.ckbHienThiMK = new System.Windows.Forms.CheckBox();
            this.btbThoat = new System.Windows.Forms.Button();
            this.btbDangNhap = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.lblMK = new System.Windows.Forms.Label();
            this.lblTenDN = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ckbHienThiMK
            // 
            this.ckbHienThiMK.AutoSize = true;
            this.ckbHienThiMK.BackColor = System.Drawing.Color.Transparent;
            this.ckbHienThiMK.Location = new System.Drawing.Point(325, 292);
            this.ckbHienThiMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckbHienThiMK.Name = "ckbHienThiMK";
            this.ckbHienThiMK.Size = new System.Drawing.Size(260, 42);
            this.ckbHienThiMK.TabIndex = 13;
            this.ckbHienThiMK.Text = "Hiển thị mật khẩu";
            this.ckbHienThiMK.UseVisualStyleBackColor = false;
            this.ckbHienThiMK.CheckedChanged += new System.EventHandler(this.ckbHienThiMK_CheckedChanged);
            // 
            // btbThoat
            // 
            this.btbThoat.BackColor = System.Drawing.Color.LightBlue;
            this.btbThoat.Location = new System.Drawing.Point(550, 353);
            this.btbThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btbThoat.Name = "btbThoat";
            this.btbThoat.Size = new System.Drawing.Size(112, 49);
            this.btbThoat.TabIndex = 12;
            this.btbThoat.Text = "Thoát";
            this.btbThoat.UseVisualStyleBackColor = false;
            this.btbThoat.Click += new System.EventHandler(this.btbThoat_Click);
            // 
            // btbDangNhap
            // 
            this.btbDangNhap.BackColor = System.Drawing.Color.LightBlue;
            this.btbDangNhap.Location = new System.Drawing.Point(44, 353);
            this.btbDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btbDangNhap.Name = "btbDangNhap";
            this.btbDangNhap.Size = new System.Drawing.Size(142, 49);
            this.btbDangNhap.TabIndex = 11;
            this.btbDangNhap.Text = "Đăng Nhập";
            this.btbDangNhap.UseVisualStyleBackColor = false;
            this.btbDangNhap.Click += new System.EventHandler(this.btbDangNhap_Click);
            // 
            // txtMK
            // 
            this.txtMK.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtMK.Location = new System.Drawing.Point(427, 200);
            this.txtMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMK.Multiline = true;
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(260, 43);
            this.txtMK.TabIndex = 10;
            // 
            // txtTenDN
            // 
            this.txtTenDN.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTenDN.Location = new System.Drawing.Point(427, 120);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenDN.Multiline = true;
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(260, 39);
            this.txtTenDN.TabIndex = 9;
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.BackColor = System.Drawing.Color.Transparent;
            this.lblMK.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMK.Location = new System.Drawing.Point(239, 212);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(123, 31);
            this.lblMK.TabIndex = 8;
            this.lblMK.Text = "Mật Khẩu :";
            // 
            // lblTenDN
            // 
            this.lblTenDN.AutoSize = true;
            this.lblTenDN.BackColor = System.Drawing.Color.Transparent;
            this.lblTenDN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDN.Location = new System.Drawing.Point(239, 128);
            this.lblTenDN.Name = "lblTenDN";
            this.lblTenDN.Size = new System.Drawing.Size(183, 31);
            this.lblTenDN.TabIndex = 7;
            this.lblTenDN.Text = "Tên Đăng Nhập :\r\n";
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.LightBlue;
            this.btnDangKy.Location = new System.Drawing.Point(218, 353);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(130, 49);
            this.btnDangKy.TabIndex = 14;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Location = new System.Drawing.Point(383, 353);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 49);
            this.button1.TabIndex = 15;
            this.button1.Text = "Trở về";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 68);
            this.label1.TabIndex = 16;
            this.label1.Text = "Đăng nhập \r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(699, 428);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.ckbHienThiMK);
            this.Controls.Add(this.btbThoat);
            this.Controls.Add(this.btbDangNhap);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.lblMK);
            this.Controls.Add(this.lblTenDN);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Đăng Nhập ";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbHienThiMK;
        private System.Windows.Forms.Button btbThoat;
        private System.Windows.Forms.Button btbDangNhap;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.Label lblTenDN;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}