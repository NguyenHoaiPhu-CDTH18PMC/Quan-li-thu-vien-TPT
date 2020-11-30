namespace QuanLiThuVienTPT
{
    partial class frmDangNhap
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptbpassword = new System.Windows.Forms.PictureBox();
            this.ptbuser = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.ptbusericon = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbpassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbusericon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Controls.Add(this.ptbpassword);
            this.panel2.Controls.Add(this.ptbuser);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnDangNhap);
            this.panel2.Controls.Add(this.txtPassWord);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Location = new System.Drawing.Point(1, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 196);
            this.panel2.TabIndex = 3;
            // 
            // ptbpassword
            // 
            this.ptbpassword.Image = global::QuanLiThuVienTPT.Properties.Resources._lock;
            this.ptbpassword.Location = new System.Drawing.Point(25, 65);
            this.ptbpassword.Name = "ptbpassword";
            this.ptbpassword.Size = new System.Drawing.Size(37, 36);
            this.ptbpassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbpassword.TabIndex = 7;
            this.ptbpassword.TabStop = false;
            // 
            // ptbuser
            // 
            this.ptbuser.Image = global::QuanLiThuVienTPT.Properties.Resources.userlock;
            this.ptbuser.Location = new System.Drawing.Point(27, 8);
            this.ptbuser.Name = "ptbuser";
            this.ptbuser.Size = new System.Drawing.Size(33, 35);
            this.ptbuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbuser.TabIndex = 6;
            this.ptbuser.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThoat.Location = new System.Drawing.Point(241, 128);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(89, 33);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDangNhap.Location = new System.Drawing.Point(70, 128);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(95, 33);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassWord.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Location = new System.Drawing.Point(70, 77);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(260, 31);
            this.txtPassWord.TabIndex = 1;
            this.txtPassWord.Text = "123456";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(70, 15);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(260, 31);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "NguyenHoaiPhu";
            // 
            // ptbusericon
            // 
            this.ptbusericon.Image = global::QuanLiThuVienTPT.Properties.Resources.usericon;
            this.ptbusericon.Location = new System.Drawing.Point(79, 4);
            this.ptbusericon.Name = "ptbusericon";
            this.ptbusericon.Size = new System.Drawing.Size(222, 160);
            this.ptbusericon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbusericon.TabIndex = 4;
            this.ptbusericon.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(382, 368);
            this.Controls.Add(this.ptbusericon);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbpassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbusericon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ptbpassword;
        private System.Windows.Forms.PictureBox ptbuser;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox ptbusericon;
    }
}

