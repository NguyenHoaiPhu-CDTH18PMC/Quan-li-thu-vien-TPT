using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace QuanLiThuVienTPT
{
    public partial class frmLoad : Form
    {
        public frmLoad()
        {
            InitializeComponent();
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            pgbLoad.PerformStep();
        }

        private void FormLoad_Load(object sender, EventArgs e)
        {
            timerLoad.Start();
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
