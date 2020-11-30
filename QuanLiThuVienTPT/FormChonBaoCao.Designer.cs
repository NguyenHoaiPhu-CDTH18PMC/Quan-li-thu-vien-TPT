namespace QuanLiThuVienTPT
{
    partial class frmChonBaoCao
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
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.radNhomDS = new System.Windows.Forms.RadioButton();
            this.radTheoDauSach = new System.Windows.Forms.RadioButton();
            this.radPhat = new System.Windows.Forms.RadioButton();
            this.cboDS = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTatCa.Location = new System.Drawing.Point(88, 68);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(66, 20);
            this.radTatCa.TabIndex = 0;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất cả";
            this.radTatCa.UseVisualStyleBackColor = true;
            // 
            // radNhomDS
            // 
            this.radNhomDS.AutoSize = true;
            this.radNhomDS.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNhomDS.Location = new System.Drawing.Point(88, 162);
            this.radNhomDS.Name = "radNhomDS";
            this.radNhomDS.Size = new System.Drawing.Size(157, 20);
            this.radNhomDS.TabIndex = 1;
            this.radNhomDS.TabStop = true;
            this.radNhomDS.Text = "Theo nhóm đầu sách";
            this.radNhomDS.UseVisualStyleBackColor = true;
            // 
            // radTheoDauSach
            // 
            this.radTheoDauSach.AutoSize = true;
            this.radTheoDauSach.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTheoDauSach.Location = new System.Drawing.Point(88, 113);
            this.radTheoDauSach.Name = "radTheoDauSach";
            this.radTheoDauSach.Size = new System.Drawing.Size(118, 20);
            this.radTheoDauSach.TabIndex = 2;
            this.radTheoDauSach.TabStop = true;
            this.radTheoDauSach.Text = "Theo đầu sách";
            this.radTheoDauSach.UseVisualStyleBackColor = true;
            // 
            // radPhat
            // 
            this.radPhat.AutoSize = true;
            this.radPhat.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPhat.Location = new System.Drawing.Point(88, 214);
            this.radPhat.Name = "radPhat";
            this.radPhat.Size = new System.Drawing.Size(127, 20);
            this.radPhat.TabIndex = 3;
            this.radPhat.TabStop = true;
            this.radPhat.Text = "Xuất phiếu phạt";
            this.radPhat.UseVisualStyleBackColor = true;
            // 
            // cboDS
            // 
            this.cboDS.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDS.FormattingEnabled = true;
            this.cboDS.Location = new System.Drawing.Point(250, 113);
            this.cboDS.Name = "cboDS";
            this.cboDS.Size = new System.Drawing.Size(238, 23);
            this.cboDS.TabIndex = 4;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.Red;
            this.btnXem.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(213, 293);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(145, 41);
            this.btnXem.TabIndex = 5;
            this.btnXem.Text = "Xem báo cáo";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // frmChonBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(569, 366);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cboDS);
            this.Controls.Add(this.radPhat);
            this.Controls.Add(this.radTheoDauSach);
            this.Controls.Add(this.radNhomDS);
            this.Controls.Add(this.radTatCa);
            this.Name = "frmChonBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn báo cáo";
            this.Load += new System.EventHandler(this.frmChonBaoCao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.RadioButton radNhomDS;
        private System.Windows.Forms.RadioButton radTheoDauSach;
        private System.Windows.Forms.RadioButton radPhat;
        private System.Windows.Forms.ComboBox cboDS;
        private System.Windows.Forms.Button btnXem;
    }
}