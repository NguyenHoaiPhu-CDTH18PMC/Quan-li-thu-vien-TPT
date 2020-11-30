namespace QuanLiThuVienTPT
{
    partial class frmTrangChu
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
            this.menuStripHome = new System.Windows.Forms.MenuStrip();
            this.HomeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NhanVienItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XoaLSItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TacVuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MuonTraItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SachItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocGiaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemXemThem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemTaccGia = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemNXB = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemDauSach = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiemItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimSachItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimDocGiaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimSachMuonItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HeThongItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongTinTKItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NgonNguItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vietnameseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMNV = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnSuCo = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnRefreshData = new System.Windows.Forms.Button();
            this.ptbAnhDaiDien = new System.Windows.Forms.PictureBox();
            this.btnLichSuDangNhap = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Time_Clock = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTime = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHide = new System.Windows.Forms.Button();
            this.HuongDanSuDungItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhDaiDien)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripHome
            // 
            this.menuStripHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuStripHome.Font = new System.Drawing.Font("Cambria Math", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripHome.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStripHome.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeItem,
            this.TacVuItem,
            this.TimKiemItem,
            this.HeThongItem});
            this.menuStripHome.Location = new System.Drawing.Point(0, 0);
            this.menuStripHome.Name = "menuStripHome";
            this.menuStripHome.Size = new System.Drawing.Size(1082, 86);
            this.menuStripHome.TabIndex = 2;
            // 
            // HomeItem
            // 
            this.HomeItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NhanVienItem,
            this.XoaLSItem});
            this.HomeItem.Font = new System.Drawing.Font("Cambria Math", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeItem.ForeColor = System.Drawing.Color.Red;
            this.HomeItem.Name = "HomeItem";
            this.HomeItem.Size = new System.Drawing.Size(81, 82);
            this.HomeItem.Text = "Home";
            // 
            // NhanVienItem
            // 
            this.NhanVienItem.ForeColor = System.Drawing.Color.Red;
            this.NhanVienItem.Name = "NhanVienItem";
            this.NhanVienItem.Size = new System.Drawing.Size(238, 82);
            this.NhanVienItem.Text = "Quản lí nhân viên";
            this.NhanVienItem.Click += new System.EventHandler(this.NhanVienItem_Click);
            // 
            // XoaLSItem
            // 
            this.XoaLSItem.ForeColor = System.Drawing.Color.Red;
            this.XoaLSItem.Name = "XoaLSItem";
            this.XoaLSItem.Size = new System.Drawing.Size(238, 82);
            this.XoaLSItem.Text = "Xóa lịch sử";
            this.XoaLSItem.Click += new System.EventHandler(this.XoaLSItem_Click);
            // 
            // TacVuItem
            // 
            this.TacVuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MuonTraItem,
            this.SachItem,
            this.DocGiaItem,
            this.ItemXemThem});
            this.TacVuItem.Font = new System.Drawing.Font("Cambria Math", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TacVuItem.ForeColor = System.Drawing.Color.Red;
            this.TacVuItem.Name = "TacVuItem";
            this.TacVuItem.Size = new System.Drawing.Size(83, 82);
            this.TacVuItem.Text = "Tác vụ";
            // 
            // MuonTraItem
            // 
            this.MuonTraItem.ForeColor = System.Drawing.Color.Red;
            this.MuonTraItem.Name = "MuonTraItem";
            this.MuonTraItem.Size = new System.Drawing.Size(236, 82);
            this.MuonTraItem.Text = "Quản lí mượn trả";
            this.MuonTraItem.Click += new System.EventHandler(this.MuonTraItem_Click);
            // 
            // SachItem
            // 
            this.SachItem.ForeColor = System.Drawing.Color.Red;
            this.SachItem.Name = "SachItem";
            this.SachItem.Size = new System.Drawing.Size(236, 82);
            this.SachItem.Text = "Quản lí sách";
            this.SachItem.Click += new System.EventHandler(this.SachItem_Click);
            // 
            // DocGiaItem
            // 
            this.DocGiaItem.ForeColor = System.Drawing.Color.Red;
            this.DocGiaItem.Name = "DocGiaItem";
            this.DocGiaItem.Size = new System.Drawing.Size(236, 82);
            this.DocGiaItem.Text = "Quản lí độc giả";
            this.DocGiaItem.Click += new System.EventHandler(this.DocGiaItem_Click);
            // 
            // ItemXemThem
            // 
            this.ItemXemThem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemTaccGia,
            this.ItemNXB,
            this.ItemDauSach});
            this.ItemXemThem.ForeColor = System.Drawing.Color.Red;
            this.ItemXemThem.Name = "ItemXemThem";
            this.ItemXemThem.Size = new System.Drawing.Size(236, 82);
            this.ItemXemThem.Text = "Xem thêm";
            // 
            // ItemTaccGia
            // 
            this.ItemTaccGia.ForeColor = System.Drawing.Color.Red;
            this.ItemTaccGia.Name = "ItemTaccGia";
            this.ItemTaccGia.Size = new System.Drawing.Size(231, 82);
            this.ItemTaccGia.Text = "Quản lí tác giả";
            this.ItemTaccGia.Click += new System.EventHandler(this.ItemTaccGia_Click);
            // 
            // ItemNXB
            // 
            this.ItemNXB.ForeColor = System.Drawing.Color.Red;
            this.ItemNXB.Name = "ItemNXB";
            this.ItemNXB.Size = new System.Drawing.Size(231, 82);
            this.ItemNXB.Text = "Quản lí NXB";
            this.ItemNXB.Click += new System.EventHandler(this.ItemNXB_Click);
            // 
            // ItemDauSach
            // 
            this.ItemDauSach.ForeColor = System.Drawing.Color.Red;
            this.ItemDauSach.Name = "ItemDauSach";
            this.ItemDauSach.Size = new System.Drawing.Size(231, 82);
            this.ItemDauSach.Text = "Quán lí đầu sách";
            this.ItemDauSach.Click += new System.EventHandler(this.ItemDauSach_Click);
            // 
            // TimKiemItem
            // 
            this.TimKiemItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimSachItem,
            this.TimDocGiaItem,
            this.TimSachMuonItem});
            this.TimKiemItem.Font = new System.Drawing.Font("Cambria Math", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimKiemItem.ForeColor = System.Drawing.Color.Red;
            this.TimKiemItem.Name = "TimKiemItem";
            this.TimKiemItem.Size = new System.Drawing.Size(102, 82);
            this.TimKiemItem.Text = "Tìm kiếm";
            // 
            // TimSachItem
            // 
            this.TimSachItem.ForeColor = System.Drawing.Color.Red;
            this.TimSachItem.Name = "TimSachItem";
            this.TimSachItem.Size = new System.Drawing.Size(226, 82);
            this.TimSachItem.Text = "Tìm sách";
            // 
            // TimDocGiaItem
            // 
            this.TimDocGiaItem.ForeColor = System.Drawing.Color.Red;
            this.TimDocGiaItem.Name = "TimDocGiaItem";
            this.TimDocGiaItem.Size = new System.Drawing.Size(226, 82);
            this.TimDocGiaItem.Text = "Tìm đọc giả";
            // 
            // TimSachMuonItem
            // 
            this.TimSachMuonItem.ForeColor = System.Drawing.Color.Red;
            this.TimSachMuonItem.Name = "TimSachMuonItem";
            this.TimSachMuonItem.Size = new System.Drawing.Size(226, 82);
            this.TimSachMuonItem.Text = "Tim sách mượn";
            // 
            // HeThongItem
            // 
            this.HeThongItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThongTinTKItem,
            this.NgonNguItem,
            this.HuongDanSuDungItem});
            this.HeThongItem.Font = new System.Drawing.Font("Cambria Math", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeThongItem.ForeColor = System.Drawing.Color.Red;
            this.HeThongItem.Name = "HeThongItem";
            this.HeThongItem.Size = new System.Drawing.Size(100, 82);
            this.HeThongItem.Text = "Hệ thống";
            // 
            // ThongTinTKItem
            // 
            this.ThongTinTKItem.ForeColor = System.Drawing.Color.Red;
            this.ThongTinTKItem.Name = "ThongTinTKItem";
            this.ThongTinTKItem.Size = new System.Drawing.Size(252, 82);
            this.ThongTinTKItem.Text = "Thông tin tài khoản";
            this.ThongTinTKItem.Click += new System.EventHandler(this.ThongTinTKItem_Click);
            // 
            // NgonNguItem
            // 
            this.NgonNguItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vietnameseToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.NgonNguItem.ForeColor = System.Drawing.Color.Red;
            this.NgonNguItem.Name = "NgonNguItem";
            this.NgonNguItem.Size = new System.Drawing.Size(252, 82);
            this.NgonNguItem.Text = "Ngôn ngữ";
            // 
            // vietnameseToolStripMenuItem
            // 
            this.vietnameseToolStripMenuItem.Name = "vietnameseToolStripMenuItem";
            this.vietnameseToolStripMenuItem.Size = new System.Drawing.Size(203, 82);
            this.vietnameseToolStripMenuItem.Text = "Vietnamese";
            this.vietnameseToolStripMenuItem.Click += new System.EventHandler(this.vietnameseToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(203, 82);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // lblMNV
            // 
            this.lblMNV.AutoSize = true;
            this.lblMNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblMNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMNV.ForeColor = System.Drawing.Color.Blue;
            this.lblMNV.Location = new System.Drawing.Point(724, 10);
            this.lblMNV.Name = "lblMNV";
            this.lblMNV.Size = new System.Drawing.Size(49, 18);
            this.lblMNV.TabIndex = 18;
            this.lblMNV.Text = "MaNV";
            this.toolTip1.SetToolTip(this.lblMNV, "Mã nhân viên");
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.ForeColor = System.Drawing.Color.Blue;
            this.lblTenNV.Location = new System.Drawing.Point(724, 46);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(53, 18);
            this.lblTenNV.TabIndex = 13;
            this.lblTenNV.Text = "TenNV";
            this.toolTip1.SetToolTip(this.lblTenNV, "Tên nhân viên");
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
            this.btnThoat.Location = new System.Drawing.Point(1028, 7);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(54, 55);
            this.btnThoat.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnThoat, "Thoát");
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Image = global::QuanLiThuVienTPT.Properties.Resources.Exit;
            this.btnDangXuat.Location = new System.Drawing.Point(901, 1);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(66, 67);
            this.btnDangXuat.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnDangXuat, "Đăng xuất");
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Image = global::QuanLiThuVienTPT.Properties.Resources.DangNhap__2_;
            this.btnDangNhap.Location = new System.Drawing.Point(311, 1);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(66, 66);
            this.btnDangNhap.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnDangNhap, "Đăng nhập");
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnSuCo
            // 
            this.btnSuCo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSuCo.FlatAppearance.BorderSize = 0;
            this.btnSuCo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSuCo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSuCo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuCo.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuCo.ForeColor = System.Drawing.Color.White;
            this.btnSuCo.Image = global::QuanLiThuVienTPT.Properties.Resources.CanhBao;
            this.btnSuCo.Location = new System.Drawing.Point(512, 1);
            this.btnSuCo.Name = "btnSuCo";
            this.btnSuCo.Size = new System.Drawing.Size(66, 66);
            this.btnSuCo.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnSuCo, "Warning");
            this.btnSuCo.UseVisualStyleBackColor = false;
            this.btnSuCo.Click += new System.EventHandler(this.btnSuCo_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBaoCao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Image = global::QuanLiThuVienTPT.Properties.Resources.report__2_;
            this.btnBaoCao.Location = new System.Drawing.Point(445, 7);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(66, 60);
            this.btnBaoCao.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnBaoCao, "Báo cáo");
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnRefreshData
            // 
            this.btnRefreshData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnRefreshData.FlatAppearance.BorderSize = 0;
            this.btnRefreshData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnRefreshData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefreshData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshData.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshData.ForeColor = System.Drawing.Color.White;
            this.btnRefreshData.Image = global::QuanLiThuVienTPT.Properties.Resources.Refresh;
            this.btnRefreshData.Location = new System.Drawing.Point(378, 1);
            this.btnRefreshData.Name = "btnRefreshData";
            this.btnRefreshData.Size = new System.Drawing.Size(66, 66);
            this.btnRefreshData.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnRefreshData, "Refresh");
            this.btnRefreshData.UseVisualStyleBackColor = false;
            this.btnRefreshData.Click += new System.EventHandler(this.btnRefreshData_Click);
            // 
            // ptbAnhDaiDien
            // 
            this.ptbAnhDaiDien.Location = new System.Drawing.Point(647, 1);
            this.ptbAnhDaiDien.Name = "ptbAnhDaiDien";
            this.ptbAnhDaiDien.Size = new System.Drawing.Size(71, 66);
            this.ptbAnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAnhDaiDien.TabIndex = 12;
            this.ptbAnhDaiDien.TabStop = false;
            this.toolTip1.SetToolTip(this.ptbAnhDaiDien, "Ảnh đại diện");
            // 
            // btnLichSuDangNhap
            // 
            this.btnLichSuDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLichSuDangNhap.FlatAppearance.BorderSize = 0;
            this.btnLichSuDangNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLichSuDangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLichSuDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichSuDangNhap.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSuDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnLichSuDangNhap.Image = global::QuanLiThuVienTPT.Properties.Resources.LichSu;
            this.btnLichSuDangNhap.Location = new System.Drawing.Point(579, 1);
            this.btnLichSuDangNhap.Name = "btnLichSuDangNhap";
            this.btnLichSuDangNhap.Size = new System.Drawing.Size(66, 66);
            this.btnLichSuDangNhap.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnLichSuDangNhap, "Lịch sử đăng nhập");
            this.btnLichSuDangNhap.UseVisualStyleBackColor = false;
            this.btnLichSuDangNhap.Click += new System.EventHandler(this.btnLichSuDangNhap_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(3, 59);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // Time_Clock
            // 
            this.Time_Clock.Tick += new System.EventHandler(this.Time_Clock_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnTime);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Location = new System.Drawing.Point(0, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 221);
            this.panel1.TabIndex = 22;
            // 
            // btnTime
            // 
            this.btnTime.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTime.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTime.ForeColor = System.Drawing.Color.White;
            this.btnTime.Location = new System.Drawing.Point(3, 3);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(227, 56);
            this.btnTime.TabIndex = 4;
            this.btnTime.Text = "Time";
            this.btnTime.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLiThuVienTPT.Properties.Resources._1111;
            this.pictureBox2.Location = new System.Drawing.Point(3, 313);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 255);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLiThuVienTPT.Properties.Resources._00000;
            this.pictureBox1.Location = new System.Drawing.Point(234, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(846, 482);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
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
            this.btnHide.Location = new System.Drawing.Point(969, 12);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(53, 46);
            this.btnHide.TabIndex = 23;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // HuongDanSuDungItem
            // 
            this.HuongDanSuDungItem.ForeColor = System.Drawing.Color.Red;
            this.HuongDanSuDungItem.Name = "HuongDanSuDungItem";
            this.HuongDanSuDungItem.Size = new System.Drawing.Size(252, 82);
            this.HuongDanSuDungItem.Text = "Hướng dẫn sử dụng";
            this.HuongDanSuDungItem.Click += new System.EventHandler(this.HuongDanSuDungItem_Click);
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1082, 570);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnSuCo);
            this.Controls.Add(this.lblMNV);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.btnRefreshData);
            this.Controls.Add(this.ptbAnhDaiDien);
            this.Controls.Add(this.btnLichSuDangNhap);
            this.Controls.Add(this.menuStripHome);
            this.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRANG CHỦ";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmTrangChu_KeyUp);
            this.menuStripHome.ResumeLayout(false);
            this.menuStripHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhDaiDien)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripHome;
        private System.Windows.Forms.ToolStripMenuItem HomeItem;
        private System.Windows.Forms.ToolStripMenuItem TacVuItem;
        private System.Windows.Forms.ToolStripMenuItem MuonTraItem;
        private System.Windows.Forms.ToolStripMenuItem SachItem;
        private System.Windows.Forms.ToolStripMenuItem DocGiaItem;
        private System.Windows.Forms.ToolStripMenuItem ItemXemThem;
        private System.Windows.Forms.ToolStripMenuItem TimKiemItem;
        private System.Windows.Forms.ToolStripMenuItem TimSachItem;
        private System.Windows.Forms.ToolStripMenuItem TimDocGiaItem;
        private System.Windows.Forms.ToolStripMenuItem TimSachMuonItem;
        private System.Windows.Forms.ToolStripMenuItem HeThongItem;
        private System.Windows.Forms.ToolStripMenuItem ThongTinTKItem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnSuCo;
        private System.Windows.Forms.Label lblMNV;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Button btnRefreshData;
        private System.Windows.Forms.PictureBox ptbAnhDaiDien;
        private System.Windows.Forms.Button btnLichSuDangNhap;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem NhanVienItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Timer Time_Clock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.ToolStripMenuItem ItemTaccGia;
        private System.Windows.Forms.ToolStripMenuItem ItemNXB;
        private System.Windows.Forms.ToolStripMenuItem ItemDauSach;
        private System.Windows.Forms.ToolStripMenuItem XoaLSItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem NgonNguItem;
        private System.Windows.Forms.ToolStripMenuItem vietnameseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HuongDanSuDungItem;
    }
}