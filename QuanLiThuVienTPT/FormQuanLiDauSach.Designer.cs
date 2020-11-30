namespace QuanLiThuVienTPT
{
    partial class frmQuanLiDauSach
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
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.txtChuoiTK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.txtTenDS = new System.Windows.Forms.TextBox();
            this.txtMaDS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvDauSach = new System.Windows.Forms.DataGridView();
            this.MaDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.grpTacVu = new System.Windows.Forms.GroupBox();
            this.grpThongTinSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDauSach)).BeginInit();
            this.grpTacVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(325, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(217, 28);
            this.label11.TabIndex = 14;
            this.label11.Text = "QUẢN LÍ ĐẦU SÁCH";
            // 
            // grpThongTinSach
            // 
            this.grpThongTinSach.BackColor = System.Drawing.Color.LightBlue;
            this.grpThongTinSach.Controls.Add(this.cboTheLoai);
            this.grpThongTinSach.Controls.Add(this.txtChuoiTK);
            this.grpThongTinSach.Controls.Add(this.label5);
            this.grpThongTinSach.Controls.Add(this.btnThemMoi);
            this.grpThongTinSach.Controls.Add(this.txtTenDS);
            this.grpThongTinSach.Controls.Add(this.txtMaDS);
            this.grpThongTinSach.Controls.Add(this.label3);
            this.grpThongTinSach.Controls.Add(this.label2);
            this.grpThongTinSach.Controls.Add(this.label1);
            this.grpThongTinSach.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinSach.Location = new System.Drawing.Point(4, 60);
            this.grpThongTinSach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpThongTinSach.Name = "grpThongTinSach";
            this.grpThongTinSach.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpThongTinSach.Size = new System.Drawing.Size(674, 176);
            this.grpThongTinSach.TabIndex = 11;
            this.grpThongTinSach.TabStop = false;
            this.grpThongTinSach.Text = "Thông tin đầu sách";
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Location = new System.Drawing.Point(451, 34);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(178, 28);
            this.cboTheLoai.TabIndex = 32;
            // 
            // txtChuoiTK
            // 
            this.txtChuoiTK.Location = new System.Drawing.Point(139, 134);
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
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.Red;
            this.btnThemMoi.FlatAppearance.BorderSize = 0;
            this.btnThemMoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnThemMoi.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ForeColor = System.Drawing.Color.Transparent;
            this.btnThemMoi.Location = new System.Drawing.Point(524, 84);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(105, 37);
            this.btnThemMoi.TabIndex = 8;
            this.btnThemMoi.Text = "Reset";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // txtTenDS
            // 
            this.txtTenDS.Location = new System.Drawing.Point(139, 69);
            this.txtTenDS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenDS.Name = "txtTenDS";
            this.txtTenDS.Size = new System.Drawing.Size(185, 27);
            this.txtTenDS.TabIndex = 9;
            // 
            // txtMaDS
            // 
            this.txtMaDS.Enabled = false;
            this.txtMaDS.Location = new System.Drawing.Point(139, 34);
            this.txtMaDS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaDS.Name = "txtMaDS";
            this.txtMaDS.Size = new System.Drawing.Size(185, 27);
            this.txtMaDS.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thể loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đầu sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đầu sách";
            // 
            // dtgvDauSach
            // 
            this.dtgvDauSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDauSach.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dtgvDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDauSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDauSach,
            this.TenDauSach,
            this.MaTheLoai});
            this.dtgvDauSach.GridColor = System.Drawing.Color.SkyBlue;
            this.dtgvDauSach.Location = new System.Drawing.Point(4, 242);
            this.dtgvDauSach.Name = "dtgvDauSach";
            this.dtgvDauSach.RowHeadersWidth = 51;
            this.dtgvDauSach.RowTemplate.Height = 24;
            this.dtgvDauSach.Size = new System.Drawing.Size(878, 365);
            this.dtgvDauSach.TabIndex = 12;
            this.dtgvDauSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDauSach_CellClick);
            // 
            // MaDauSach
            // 
            this.MaDauSach.DataPropertyName = "MaDauSach";
            this.MaDauSach.HeaderText = "Mã đầu sách";
            this.MaDauSach.MinimumWidth = 6;
            this.MaDauSach.Name = "MaDauSach";
            // 
            // TenDauSach
            // 
            this.TenDauSach.DataPropertyName = "TenDauSach";
            this.TenDauSach.HeaderText = "Tên đầu sách";
            this.TenDauSach.MinimumWidth = 6;
            this.TenDauSach.Name = "TenDauSach";
            // 
            // MaTheLoai
            // 
            this.MaTheLoai.DataPropertyName = "MaTheLoai";
            this.MaTheLoai.HeaderText = "Mã thể loại";
            this.MaTheLoai.MinimumWidth = 6;
            this.MaTheLoai.Name = "MaTheLoai";
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
            this.btnHide.Location = new System.Drawing.Point(746, -4);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(66, 61);
            this.btnHide.TabIndex = 17;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
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
            this.btnThoat.Location = new System.Drawing.Point(816, -4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(66, 61);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(29, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(129, 36);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(29, 81);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(129, 37);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(29, 130);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(129, 35);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // grpTacVu
            // 
            this.grpTacVu.BackColor = System.Drawing.Color.MistyRose;
            this.grpTacVu.Controls.Add(this.btnSua);
            this.grpTacVu.Controls.Add(this.btnXoa);
            this.grpTacVu.Controls.Add(this.btnThem);
            this.grpTacVu.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTacVu.Location = new System.Drawing.Point(686, 60);
            this.grpTacVu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpTacVu.Name = "grpTacVu";
            this.grpTacVu.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpTacVu.Size = new System.Drawing.Size(196, 176);
            this.grpTacVu.TabIndex = 13;
            this.grpTacVu.TabStop = false;
            this.grpTacVu.Text = "Tác vụ";
            // 
            // frmQuanLiDauSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 614);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grpThongTinSach);
            this.Controls.Add(this.dtgvDauSach);
            this.Controls.Add(this.grpTacVu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuanLiDauSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuanLiDauSach";
            this.Load += new System.EventHandler(this.frmQuanLiDauSach_Load);
            this.grpThongTinSach.ResumeLayout(false);
            this.grpThongTinSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDauSach)).EndInit();
            this.grpTacVu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grpThongTinSach;
        private System.Windows.Forms.TextBox txtChuoiTK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.TextBox txtTenDS;
        private System.Windows.Forms.TextBox txtMaDS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvDauSach;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTheLoai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox grpTacVu;
    }
}