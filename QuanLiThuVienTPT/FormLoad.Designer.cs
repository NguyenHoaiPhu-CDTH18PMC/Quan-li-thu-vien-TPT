namespace QuanLiThuVienTPT
{
    partial class frmLoad
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
            this.pgbLoad = new System.Windows.Forms.ProgressBar();
            this.lbvidu = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.timerLoad = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pgbLoad
            // 
            this.pgbLoad.Location = new System.Drawing.Point(12, 56);
            this.pgbLoad.Name = "pgbLoad";
            this.pgbLoad.Size = new System.Drawing.Size(788, 13);
            this.pgbLoad.TabIndex = 0;
            // 
            // lbvidu
            // 
            this.lbvidu.AutoSize = true;
            this.lbvidu.BackColor = System.Drawing.Color.White;
            this.lbvidu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvidu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbvidu.Location = new System.Drawing.Point(358, 9);
            this.lbvidu.Name = "lbvidu";
            this.lbvidu.Size = new System.Drawing.Size(80, 20);
            this.lbvidu.TabIndex = 1;
            this.lbvidu.Text = "Loading...";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Red;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(362, 86);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 28);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // timerLoad
            // 
            this.timerLoad.Tick += new System.EventHandler(this.timerLoad_Tick);
            // 
            // frmLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 140);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbvidu);
            this.Controls.Add(this.pgbLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoad";
            this.Load += new System.EventHandler(this.FormLoad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbvidu;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Timer timerLoad;
        private System.Windows.Forms.ProgressBar pgbLoad;
    }
}