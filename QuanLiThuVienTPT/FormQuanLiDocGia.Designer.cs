namespace QuanLiThuVienTPT
{
    partial class frmQuanLiDocGia
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgvDocGia = new System.Windows.Forms.DataGridView();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.radNu);
            this.groupBox1.Controls.Add(this.radNam);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboLop);
            this.groupBox1.Controls.Add(this.cboKhoa);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtTenDocGia);
            this.groupBox1.Controls.Add(this.txtMaDocGia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đọc giả";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(128, 210);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(254, 27);
            this.txtTimKiem.TabIndex = 23;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 213);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Tìm kiếm";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.Red;
            this.btnThemMoi.FlatAppearance.BorderSize = 0;
            this.btnThemMoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnThemMoi.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ForeColor = System.Drawing.Color.Transparent;
            this.btnThemMoi.Location = new System.Drawing.Point(685, 181);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(105, 37);
            this.btnThemMoi.TabIndex = 9;
            this.btnThemMoi.Text = "Reset";
            this.toolTip1.SetToolTip(this.btnThemMoi, "Thêm mới");
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(209, 124);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(54, 24);
            this.radNu.TabIndex = 3;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Location = new System.Drawing.Point(128, 124);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(66, 24);
            this.radNam.TabIndex = 2;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Giới tính";
            // 
            // cboLop
            // 
            this.cboLop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboLop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(440, 83);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(223, 28);
            this.cboLop.TabIndex = 6;
            // 
            // cboKhoa
            // 
            this.cboKhoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboKhoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(440, 38);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(223, 28);
            this.cboKhoa.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(128, 162);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(191, 27);
            this.txtDiaChi.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(440, 162);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 27);
            this.txtEmail.TabIndex = 8;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(440, 123);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(223, 27);
            this.txtSDT.TabIndex = 7;
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Location = new System.Drawing.Point(128, 83);
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.Size = new System.Drawing.Size(191, 27);
            this.txtTenDocGia.TabIndex = 1;
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.Enabled = false;
            this.txtMaDocGia.Location = new System.Drawing.Point(128, 38);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(191, 27);
            this.txtMaDocGia.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên đọc giả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã đọc giả";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.btnCapNhat);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(827, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 246);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnTimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Image = global::QuanLiThuVienTPT.Properties.Resources.TimDocGia;
            this.btnTimKiem.Location = new System.Drawing.Point(96, 131);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(80, 70);
            this.btnTimKiem.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnTimKiem, "Tìm độc giả");
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AutoSize = true;
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnCapNhat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Image = global::QuanLiThuVienTPT.Properties.Resources.CapnhatDocGia;
            this.btnCapNhat.Location = new System.Drawing.Point(7, 131);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(80, 70);
            this.btnCapNhat.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnCapNhat, "Cập nhật độc giả");
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLiThuVienTPT.Properties.Resources.XoaDocGia;
            this.btnXoa.Location = new System.Drawing.Point(96, 31);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 70);
            this.btnXoa.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnXoa, "Xóa độc giả");
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Image = global::QuanLiThuVienTPT.Properties.Resources.ThemDocGia;
            this.btnThem.Location = new System.Drawing.Point(7, 31);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 70);
            this.btnThem.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnThem, "Thêm độc giả");
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtgvDocGia
            // 
            this.dtgvDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDocGia.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDocGia,
            this.TenDocGia,
            this.colGioiTinh,
            this.DiaChi,
            this.Email,
            this.Phone,
            this.colKhoa,
            this.colLop,
            this.Column2});
            this.dtgvDocGia.Location = new System.Drawing.Point(12, 312);
            this.dtgvDocGia.Name = "dtgvDocGia";
            this.dtgvDocGia.RowHeadersWidth = 51;
            this.dtgvDocGia.RowTemplate.Height = 24;
            this.dtgvDocGia.Size = new System.Drawing.Size(1002, 331);
            this.dtgvDocGia.TabIndex = 6;
            this.dtgvDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDocGia_CellClick);
            // 
            // MaDocGia
            // 
            this.MaDocGia.DataPropertyName = "MaDocGia";
            this.MaDocGia.HeaderText = "Mã đọc giả";
            this.MaDocGia.MinimumWidth = 6;
            this.MaDocGia.Name = "MaDocGia";
            // 
            // TenDocGia
            // 
            this.TenDocGia.DataPropertyName = "TenDocGia";
            this.TenDocGia.HeaderText = "Tên đọc giả";
            this.TenDocGia.MinimumWidth = 6;
            this.TenDocGia.Name = "TenDocGia";
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "GioiTinh";
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.MinimumWidth = 6;
            this.colGioiTinh.Name = "colGioiTinh";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "SĐT";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            // 
            // colKhoa
            // 
            this.colKhoa.DataPropertyName = "Khoa";
            this.colKhoa.HeaderText = "Khoa";
            this.colKhoa.MinimumWidth = 6;
            this.colKhoa.Name = "colKhoa";
            // 
            // colLop
            // 
            this.colLop.DataPropertyName = "Lop";
            this.colLop.HeaderText = "Lớp";
            this.colLop.MinimumWidth = 6;
            this.colLop.Name = "colLop";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Delete";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Text = "Xóa";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(379, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 28);
            this.label9.TabIndex = 7;
            this.label9.Text = "QUẢN LÍ ĐỘC GIẢ";
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
            this.btnThoat.Location = new System.Drawing.Point(948, 1);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(66, 57);
            this.btnThoat.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnThoat, "Thoát");
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
            this.btnHide.Location = new System.Drawing.Point(876, 1);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(66, 57);
            this.btnHide.TabIndex = 18;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // frmQuanLiDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1031, 656);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtgvDocGia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmQuanLiDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÍ ĐỌC GIẢ";
            this.Load += new System.EventHandler(this.frmQuanLiDocGia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDocGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenDocGia;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dtgvDocGia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLop;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnHide;
    }
}