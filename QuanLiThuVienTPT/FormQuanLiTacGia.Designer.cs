namespace QuanLiThuVienTPT
{
    partial class frmQuanLiTacGia
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
            this.label11 = new System.Windows.Forms.Label();
            this.grpThongTinSach = new System.Windows.Forms.GroupBox();
            this.txtChuoiTK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.txtMaTG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvTacGia = new System.Windows.Forms.DataGridView();
            this.MaTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTacVu = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.grpThongTinSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTacGia)).BeginInit();
            this.grpTacVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(334, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 28);
            this.label11.TabIndex = 10;
            this.label11.Text = "QUẢN LÍ TÁC GIẢ";
            // 
            // grpThongTinSach
            // 
            this.grpThongTinSach.BackColor = System.Drawing.Color.LightBlue;
            this.grpThongTinSach.Controls.Add(this.txtChuoiTK);
            this.grpThongTinSach.Controls.Add(this.label5);
            this.grpThongTinSach.Controls.Add(this.txtDiaChi);
            this.grpThongTinSach.Controls.Add(this.txtEmail);
            this.grpThongTinSach.Controls.Add(this.btnThemMoi);
            this.grpThongTinSach.Controls.Add(this.txtTenTG);
            this.grpThongTinSach.Controls.Add(this.txtMaTG);
            this.grpThongTinSach.Controls.Add(this.label4);
            this.grpThongTinSach.Controls.Add(this.label3);
            this.grpThongTinSach.Controls.Add(this.label2);
            this.grpThongTinSach.Controls.Add(this.label1);
            this.grpThongTinSach.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinSach.Location = new System.Drawing.Point(13, 59);
            this.grpThongTinSach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpThongTinSach.Name = "grpThongTinSach";
            this.grpThongTinSach.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpThongTinSach.Size = new System.Drawing.Size(674, 176);
            this.grpThongTinSach.TabIndex = 7;
            this.grpThongTinSach.TabStop = false;
            this.grpThongTinSach.Text = "Thông tin tác giả";
            // 
            // txtChuoiTK
            // 
            this.txtChuoiTK.Location = new System.Drawing.Point(122, 138);
            this.txtChuoiTK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtChuoiTK.Name = "txtChuoiTK";
            this.txtChuoiTK.Size = new System.Drawing.Size(185, 27);
            this.txtChuoiTK.TabIndex = 31;
            this.txtChuoiTK.TextChanged += new System.EventHandler(this.txtChuoiTK_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Từ khóa";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(433, 69);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(211, 27);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(433, 34);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 27);
            this.txtEmail.TabIndex = 10;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.Red;
            this.btnThemMoi.FlatAppearance.BorderSize = 0;
            this.btnThemMoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnThemMoi.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ForeColor = System.Drawing.Color.Transparent;
            this.btnThemMoi.Location = new System.Drawing.Point(513, 134);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(105, 37);
            this.btnThemMoi.TabIndex = 8;
            this.btnThemMoi.Text = "Reset";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // txtTenTG
            // 
            this.txtTenTG.Location = new System.Drawing.Point(122, 69);
            this.txtTenTG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(185, 27);
            this.txtTenTG.TabIndex = 9;
            // 
            // txtMaTG
            // 
            this.txtMaTG.Enabled = false;
            this.txtMaTG.Location = new System.Drawing.Point(122, 34);
            this.txtMaTG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaTG.Name = "txtMaTG";
            this.txtMaTG.Size = new System.Drawing.Size(185, 27);
            this.txtMaTG.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tác giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tác giả";
            // 
            // dtgvTacGia
            // 
            this.dtgvTacGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTacGia.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dtgvTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTacGia,
            this.HoTen,
            this.Email,
            this.DiaChi});
            this.dtgvTacGia.GridColor = System.Drawing.Color.SkyBlue;
            this.dtgvTacGia.Location = new System.Drawing.Point(13, 241);
            this.dtgvTacGia.Name = "dtgvTacGia";
            this.dtgvTacGia.RowHeadersWidth = 51;
            this.dtgvTacGia.RowTemplate.Height = 24;
            this.dtgvTacGia.Size = new System.Drawing.Size(878, 365);
            this.dtgvTacGia.TabIndex = 8;
            this.dtgvTacGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTacGia_CellClick);
            // 
            // MaTacGia
            // 
            this.MaTacGia.DataPropertyName = "MaTacGia";
            this.MaTacGia.HeaderText = "Mã tác giả";
            this.MaTacGia.MinimumWidth = 6;
            this.MaTacGia.Name = "MaTacGia";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Tên tác giả";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // grpTacVu
            // 
            this.grpTacVu.BackColor = System.Drawing.Color.MistyRose;
            this.grpTacVu.Controls.Add(this.btnSua);
            this.grpTacVu.Controls.Add(this.btnXoa);
            this.grpTacVu.Controls.Add(this.btnThem);
            this.grpTacVu.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTacVu.Location = new System.Drawing.Point(695, 59);
            this.grpTacVu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpTacVu.Name = "grpTacVu";
            this.grpTacVu.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpTacVu.Size = new System.Drawing.Size(196, 176);
            this.grpTacVu.TabIndex = 9;
            this.grpTacVu.TabStop = false;
            this.grpTacVu.Text = "Tác vụ";
            // 
            // btnSua
            // 
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(29, 122);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 42);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(29, 76);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 40);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(29, 29);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 41);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = global::QuanLiThuVienTPT.Properties.Resources.Close;
            this.btnThoat.Location = new System.Drawing.Point(825, 1);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(66, 58);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.ForeColor = System.Drawing.Color.White;
            this.btnHide.Image = global::QuanLiThuVienTPT.Properties.Resources.Hide;
            this.btnHide.Location = new System.Drawing.Point(753, 1);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(66, 58);
            this.btnHide.TabIndex = 18;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // frmQuanLiTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(898, 610);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grpThongTinSach);
            this.Controls.Add(this.dtgvTacGia);
            this.Controls.Add(this.grpTacVu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLiTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuanLiTacGia";
            this.Load += new System.EventHandler(this.frmQuanLiTacGia_Load);
            this.grpThongTinSach.ResumeLayout(false);
            this.grpThongTinSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTacGia)).EndInit();
            this.grpTacVu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grpThongTinSach;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.TextBox txtMaTG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvTacGia;
        private System.Windows.Forms.GroupBox grpTacVu;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtChuoiTK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}