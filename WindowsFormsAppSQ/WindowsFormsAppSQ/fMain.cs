using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSQ
{
    public partial class fmain : Form
    {
        public fmain()
        {
            InitializeComponent();
        }

        private void DanhXuatTool_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            this.Hide();
            f.Show();
        }

        private void ThoatTool_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            this.Hide();
            f.Show();
        }

        private void NguoiDungTool_Click(object sender, EventArgs e)
        {

        }

        private void ThietBiStrip_Click(object sender, EventArgs e)
        {

        }

        private void DonViStrip_Click(object sender, EventArgs e)
        {

        }

        private void NguoiPhuTrachStrip_Click(object sender, EventArgs e)
        {
            fnphutrach f = new fnphutrach();
            this.Hide();
            f.Show();
        }

        private void NVKTStrip_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyStrip_Click(object sender, EventArgs e)
        {

        }

        private void nhómThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
