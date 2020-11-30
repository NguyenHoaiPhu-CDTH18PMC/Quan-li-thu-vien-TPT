namespace QuanLiThuVienTPT
{
    partial class frmTimKiemSach
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
            this.btnTimKiemSach = new System.Windows.Forms.Button();
            this.txtChuoiTK = new System.Windows.Forms.TextBox();
            this.cboTImKiemDocGia = new System.Windows.Forms.ComboBox();
            this.lblNhapCTK = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTimKiemSach
            // 
            this.btnTimKiemSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemSach.FlatAppearance.BorderSize = 0;
            this.btnTimKiemSach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnTimKiemSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Linen;
            this.btnTimKiemSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemSach.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemSach.Location = new System.Drawing.Point(493, 90);
            this.btnTimKiemSach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTimKiemSach.Name = "btnTimKiemSach";
            this.btnTimKiemSach.Size = new System.Drawing.Size(107, 29);
            this.btnTimKiemSach.TabIndex = 26;
            this.btnTimKiemSach.Text = "Tìm kiếm";
            this.btnTimKiemSach.UseVisualStyleBackColor = true;
            this.btnTimKiemSach.Click += new System.EventHandler(this.btnTimKiemSach_Click);
            // 
            // txtChuoiTK
            // 
            this.txtChuoiTK.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuoiTK.Location = new System.Drawing.Point(236, 93);
            this.txtChuoiTK.Name = "txtChuoiTK";
            this.txtChuoiTK.Size = new System.Drawing.Size(232, 25);
            this.txtChuoiTK.TabIndex = 25;
            // 
            // cboTImKiemDocGia
            // 
            this.cboTImKiemDocGia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboTImKiemDocGia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTImKiemDocGia.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTImKiemDocGia.FormattingEnabled = true;
            this.cboTImKiemDocGia.Items.AddRange(new object[] {
            "Tất cả",
            "Tên sách",
            "Mã sách",
            "NXB",
            "Năm xuất bản",
            "Tác giả ",
            "Đầu sách"});
            this.cboTImKiemDocGia.Location = new System.Drawing.Point(39, 93);
            this.cboTImKiemDocGia.Name = "cboTImKiemDocGia";
            this.cboTImKiemDocGia.Size = new System.Drawing.Size(158, 25);
            this.cboTImKiemDocGia.TabIndex = 24;
            // 
            // lblNhapCTK
            // 
            this.lblNhapCTK.AutoSize = true;
            this.lblNhapCTK.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapCTK.Location = new System.Drawing.Point(233, 59);
            this.lblNhapCTK.Name = "lblNhapCTK";
            this.lblNhapCTK.Size = new System.Drawing.Size(150, 17);
            this.lblNhapCTK.TabIndex = 23;
            this.lblNhapCTK.Text = "Nhập chuỗi tìm kiếm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tìm kiếm theo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "TÌM KIẾM";
            // 
            // frmTimKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 184);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimKiemSach);
            this.Controls.Add(this.txtChuoiTK);
            this.Controls.Add(this.cboTImKiemDocGia);
            this.Controls.Add(this.lblNhapCTK);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTimKiemSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiemSach;
        private System.Windows.Forms.TextBox txtChuoiTK;
        private System.Windows.Forms.ComboBox cboTImKiemDocGia;
        private System.Windows.Forms.Label lblNhapCTK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
    }
}