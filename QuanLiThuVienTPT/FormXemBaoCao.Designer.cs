namespace QuanLiThuVienTPT
{
    partial class FormXemBaoCao
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
            this.rptBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptBaoCao
            // 
            this.rptBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptBaoCao.Location = new System.Drawing.Point(0, 0);
            this.rptBaoCao.Name = "rptBaoCao";
            this.rptBaoCao.Size = new System.Drawing.Size(992, 641);
            this.rptBaoCao.TabIndex = 0;
            this.rptBaoCao.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // FormXemBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 641);
            this.Controls.Add(this.rptBaoCao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormXemBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormXemBaoCao";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptBaoCao;
    }
}