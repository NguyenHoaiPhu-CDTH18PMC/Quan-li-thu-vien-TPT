namespace QuanLiThuVienTPT
{
    partial class frmQuanLiSach
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
            this.dtgvSach = new System.Windows.Forms.DataGridView();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDauSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpTacVu = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grpThongTinSach = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnThemNXB = new System.Windows.Forms.Button();
            this.btnThemDS = new System.Windows.Forms.Button();
            this.btnThemTG = new System.Windows.Forms.Button();
            this.cboMaDauSach = new System.Windows.Forms.ComboBox();
            this.cboMaTG = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboMaNXB = new System.Windows.Forms.ComboBox();
            this.nbrSLTon = new System.Windows.Forms.NumericUpDown();
            this.nbrGiaTien = new System.Windows.Forms.NumericUpDown();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnThoat = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnHide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).BeginInit();
            this.grpTacVu.SuspendLayout();
            this.grpThongTinSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrSLTon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrGiaTien)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvSach
            // 
            this.dtgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSach.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dtgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach,
            this.colTenSach,
            this.colMaTacGia,
            this.colMaDauSach,
            this.colMaNXB,
            this.colNamXB,
            this.colGiaTien,
            this.colSLTon,
            this.Xoa});
            this.dtgvSach.GridColor = System.Drawing.Color.SkyBlue;
            this.dtgvSach.Location = new System.Drawing.Point(13, 301);
            this.dtgvSach.Name = "dtgvSach";
            this.dtgvSach.RowHeadersWidth = 51;
            this.dtgvSach.RowTemplate.Height = 24;
            this.dtgvSach.Size = new System.Drawing.Size(1170, 340);
            this.dtgvSach.TabIndex = 5;
            this.dtgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSach_CellClick);
            // 
            // colMaSach
            // 
            this.colMaSach.DataPropertyName = "MaSach";
            this.colMaSach.HeaderText = "Mã sách";
            this.colMaSach.MinimumWidth = 6;
            this.colMaSach.Name = "colMaSach";
            // 
            // colTenSach
            // 
            this.colTenSach.DataPropertyName = "TenSach";
            this.colTenSach.HeaderText = "Tên sách";
            this.colTenSach.MinimumWidth = 6;
            this.colTenSach.Name = "colTenSach";
            // 
            // colMaTacGia
            // 
            this.colMaTacGia.DataPropertyName = "MaTacGia";
            this.colMaTacGia.HeaderText = "Mã tác giả";
            this.colMaTacGia.MinimumWidth = 6;
            this.colMaTacGia.Name = "colMaTacGia";
            // 
            // colMaDauSach
            // 
            this.colMaDauSach.DataPropertyName = "MaDauSach";
            this.colMaDauSach.HeaderText = "Mã đầu sách";
            this.colMaDauSach.MinimumWidth = 6;
            this.colMaDauSach.Name = "colMaDauSach";
            // 
            // colMaNXB
            // 
            this.colMaNXB.DataPropertyName = "MaNXB";
            this.colMaNXB.HeaderText = "Mã NXB";
            this.colMaNXB.MinimumWidth = 6;
            this.colMaNXB.Name = "colMaNXB";
            this.colMaNXB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colNamXB
            // 
            this.colNamXB.DataPropertyName = "NamXB";
            this.colNamXB.HeaderText = "Năm xuất bản";
            this.colNamXB.MinimumWidth = 6;
            this.colNamXB.Name = "colNamXB";
            // 
            // colGiaTien
            // 
            this.colGiaTien.DataPropertyName = "GiaTien";
            this.colGiaTien.HeaderText = "Giá tiền";
            this.colGiaTien.MinimumWidth = 6;
            this.colGiaTien.Name = "colGiaTien";
            // 
            // colSLTon
            // 
            this.colSLTon.DataPropertyName = "SLTon";
            this.colSLTon.HeaderText = "SL Tồn";
            this.colSLTon.MinimumWidth = 6;
            this.colSLTon.Name = "colSLTon";
            // 
            // Xoa
            // 
            this.Xoa.HeaderText = "Delete";
            this.Xoa.MinimumWidth = 6;
            this.Xoa.Name = "Xoa";
            this.Xoa.Text = "Xóa";
            this.Xoa.UseColumnTextForButtonValue = true;
            // 
            // grpTacVu
            // 
            this.grpTacVu.BackColor = System.Drawing.Color.MistyRose;
            this.grpTacVu.Controls.Add(this.btnThem);
            this.grpTacVu.Controls.Add(this.btnCapNhat);
            this.grpTacVu.Controls.Add(this.btnTimKiem);
            this.grpTacVu.Controls.Add(this.btnXoa);
            this.grpTacVu.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTacVu.Location = new System.Drawing.Point(987, 66);
            this.grpTacVu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpTacVu.Name = "grpTacVu";
            this.grpTacVu.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpTacVu.Size = new System.Drawing.Size(196, 229);
            this.grpTacVu.TabIndex = 2;
            this.grpTacVu.TabStop = false;
            this.grpTacVu.Text = "Tác vụ";
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Image = global::QuanLiThuVienTPT.Properties.Resources.ThemSach;
            this.btnThem.Location = new System.Drawing.Point(11, 25);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 70);
            this.btnThem.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnThem, "Thêm sách");
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AutoSize = true;
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCapNhat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Image = global::QuanLiThuVienTPT.Properties.Resources.CapNhatSach;
            this.btnCapNhat.Location = new System.Drawing.Point(28, 119);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(70, 70);
            this.btnCapNhat.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnCapNhat, "Cập nhật sách");
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnTimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Image = global::QuanLiThuVienTPT.Properties.Resources.TimSach;
            this.btnTimKiem.Location = new System.Drawing.Point(116, 119);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(70, 70);
            this.btnTimKiem.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnTimKiem, "Tìm kiếm sách");
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKIem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Image = global::QuanLiThuVienTPT.Properties.Resources.XoaSach;
            this.btnXoa.Location = new System.Drawing.Point(103, 26);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 70);
            this.btnXoa.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnXoa, "Xóa sách");
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // grpThongTinSach
            // 
            this.grpThongTinSach.BackColor = System.Drawing.Color.LightBlue;
            this.grpThongTinSach.Controls.Add(this.txtTimKiem);
            this.grpThongTinSach.Controls.Add(this.label12);
            this.grpThongTinSach.Controls.Add(this.btnThemMoi);
            this.grpThongTinSach.Controls.Add(this.btnThemNXB);
            this.grpThongTinSach.Controls.Add(this.btnThemDS);
            this.grpThongTinSach.Controls.Add(this.btnThemTG);
            this.grpThongTinSach.Controls.Add(this.cboMaDauSach);
            this.grpThongTinSach.Controls.Add(this.cboMaTG);
            this.grpThongTinSach.Controls.Add(this.label10);
            this.grpThongTinSach.Controls.Add(this.label9);
            this.grpThongTinSach.Controls.Add(this.cboMaNXB);
            this.grpThongTinSach.Controls.Add(this.nbrSLTon);
            this.grpThongTinSach.Controls.Add(this.nbrGiaTien);
            this.grpThongTinSach.Controls.Add(this.txtNamXB);
            this.grpThongTinSach.Controls.Add(this.txtTenSach);
            this.grpThongTinSach.Controls.Add(this.txtMaSach);
            this.grpThongTinSach.Controls.Add(this.label8);
            this.grpThongTinSach.Controls.Add(this.label7);
            this.grpThongTinSach.Controls.Add(this.label6);
            this.grpThongTinSach.Controls.Add(this.label5);
            this.grpThongTinSach.Controls.Add(this.label4);
            this.grpThongTinSach.Controls.Add(this.label3);
            this.grpThongTinSach.Controls.Add(this.label2);
            this.grpThongTinSach.Controls.Add(this.label1);
            this.grpThongTinSach.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinSach.Location = new System.Drawing.Point(13, 66);
            this.grpThongTinSach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpThongTinSach.Name = "grpThongTinSach";
            this.grpThongTinSach.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpThongTinSach.Size = new System.Drawing.Size(971, 229);
            this.grpThongTinSach.TabIndex = 1;
            this.grpThongTinSach.TabStop = false;
            this.grpThongTinSach.Text = "Thông tin sách";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(249, 196);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(336, 27);
            this.txtTimKiem.TabIndex = 21;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(150, 199);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Tìm kiếm";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.Red;
            this.btnThemMoi.FlatAppearance.BorderSize = 0;
            this.btnThemMoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnThemMoi.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ForeColor = System.Drawing.Color.Transparent;
            this.btnThemMoi.Location = new System.Drawing.Point(841, 161);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(105, 37);
            this.btnThemMoi.TabIndex = 11;
            this.btnThemMoi.Text = "Reset";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnThemNXB
            // 
            this.btnThemNXB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemNXB.FlatAppearance.BorderSize = 0;
            this.btnThemNXB.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNXB.ForeColor = System.Drawing.Color.Black;
            this.btnThemNXB.Location = new System.Drawing.Point(749, 34);
            this.btnThemNXB.Name = "btnThemNXB";
            this.btnThemNXB.Size = new System.Drawing.Size(75, 28);
            this.btnThemNXB.TabIndex = 7;
            this.btnThemNXB.Text = "Thêm";
            this.btnThemNXB.UseVisualStyleBackColor = false;
            this.btnThemNXB.Click += new System.EventHandler(this.btnThemNXB_Click);
            // 
            // btnThemDS
            // 
            this.btnThemDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemDS.FlatAppearance.BorderSize = 0;
            this.btnThemDS.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDS.ForeColor = System.Drawing.Color.Black;
            this.btnThemDS.Location = new System.Drawing.Point(319, 141);
            this.btnThemDS.Name = "btnThemDS";
            this.btnThemDS.Size = new System.Drawing.Size(75, 28);
            this.btnThemDS.TabIndex = 5;
            this.btnThemDS.Text = "Thêm";
            this.btnThemDS.UseVisualStyleBackColor = false;
            this.btnThemDS.Click += new System.EventHandler(this.btnThemDS_Click);
            // 
            // btnThemTG
            // 
            this.btnThemTG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemTG.FlatAppearance.BorderSize = 0;
            this.btnThemTG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnThemTG.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTG.ForeColor = System.Drawing.Color.Black;
            this.btnThemTG.Location = new System.Drawing.Point(319, 105);
            this.btnThemTG.Name = "btnThemTG";
            this.btnThemTG.Size = new System.Drawing.Size(75, 28);
            this.btnThemTG.TabIndex = 3;
            this.btnThemTG.Text = "Thêm";
            this.btnThemTG.UseVisualStyleBackColor = false;
            this.btnThemTG.Click += new System.EventHandler(this.btnThemTG_Click);
            // 
            // cboMaDauSach
            // 
            this.cboMaDauSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboMaDauSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMaDauSach.FormattingEnabled = true;
            this.cboMaDauSach.Location = new System.Drawing.Point(122, 141);
            this.cboMaDauSach.Name = "cboMaDauSach";
            this.cboMaDauSach.Size = new System.Drawing.Size(185, 28);
            this.cboMaDauSach.TabIndex = 4;
            // 
            // cboMaTG
            // 
            this.cboMaTG.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboMaTG.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMaTG.FormattingEnabled = true;
            this.cboMaTG.Location = new System.Drawing.Point(122, 105);
            this.cboMaTG.Name = "cboMaTG";
            this.cboMaTG.Size = new System.Drawing.Size(185, 28);
            this.cboMaTG.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(699, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Quyển";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(699, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "VND";
            // 
            // cboMaNXB
            // 
            this.cboMaNXB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboMaNXB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMaNXB.FormattingEnabled = true;
            this.cboMaNXB.Location = new System.Drawing.Point(582, 34);
            this.cboMaNXB.Name = "cboMaNXB";
            this.cboMaNXB.Size = new System.Drawing.Size(161, 28);
            this.cboMaNXB.TabIndex = 6;
            // 
            // nbrSLTon
            // 
            this.nbrSLTon.Location = new System.Drawing.Point(582, 147);
            this.nbrSLTon.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nbrSLTon.Name = "nbrSLTon";
            this.nbrSLTon.Size = new System.Drawing.Size(105, 27);
            this.nbrSLTon.TabIndex = 10;
            this.nbrSLTon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nbrGiaTien
            // 
            this.nbrGiaTien.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nbrGiaTien.Location = new System.Drawing.Point(582, 111);
            this.nbrGiaTien.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nbrGiaTien.Name = "nbrGiaTien";
            this.nbrGiaTien.Size = new System.Drawing.Size(105, 27);
            this.nbrGiaTien.TabIndex = 9;
            this.nbrGiaTien.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(582, 74);
            this.txtNamXB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(161, 27);
            this.txtNamXB.TabIndex = 8;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(122, 69);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(185, 27);
            this.txtTenSach.TabIndex = 1;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Enabled = false;
            this.txtMaSach.Location = new System.Drawing.Point(122, 34);
            this.txtMaSach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(185, 27);
            this.txtMaSach.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Giá tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Năm xuất bản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nhà xuất bản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng tồn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đầu sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tác giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
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
            this.btnThoat.Location = new System.Drawing.Point(1117, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(66, 57);
            this.btnThoat.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnThoat, "Thoát");
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(481, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 28);
            this.label11.TabIndex = 6;
            this.label11.Text = "QUẢN LÍ SÁCH";
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
            this.btnHide.Location = new System.Drawing.Point(1045, 3);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(66, 57);
            this.btnHide.TabIndex = 18;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // frmQuanLiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1194, 647);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtgvSach);
            this.Controls.Add(this.grpTacVu);
            this.Controls.Add(this.grpThongTinSach);
            this.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmQuanLiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÍ SÁCH";
            this.Load += new System.EventHandler(this.frmQuanLiSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSach)).EndInit();
            this.grpTacVu.ResumeLayout(false);
            this.grpTacVu.PerformLayout();
            this.grpThongTinSach.ResumeLayout(false);
            this.grpThongTinSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrSLTon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrGiaTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvSach;
        private System.Windows.Forms.GroupBox grpThongTinSach;
        private System.Windows.Forms.ComboBox cboMaNXB;
        private System.Windows.Forms.NumericUpDown nbrSLTon;
        private System.Windows.Forms.NumericUpDown nbrGiaTien;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTacVu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboMaDauSach;
        private System.Windows.Forms.ComboBox cboMaTG;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnThemNXB;
        private System.Windows.Forms.Button btnThemDS;
        private System.Windows.Forms.Button btnThemTG;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDauSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLTon;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnHide;
    }
}