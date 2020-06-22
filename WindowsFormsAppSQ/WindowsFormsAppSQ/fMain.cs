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
            fthietbi f = new fthietbi();
            f.Show();
            this.Hide();
        }

        private void DonViStrip_Click(object sender, EventArgs e)
        {
            fdonvi f = new fdonvi();
            this.Hide();
            f.Show();
        }

        private void NguoiPhuTrachStrip_Click(object sender, EventArgs e)
        {
            fnhacungcap f = new fnhacungcap();
            f.Show();
            this.Hide();
        }

        private void NVKTStrip_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyStrip_Click(object sender, EventArgs e)
        {
            fnphutrach f = new fnphutrach();
            this.Hide();
            f.Show();
        }

        private void nhómThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fnhomthietbi f = new fnhomthietbi();
            f.Show();
            this.Hide();
        }

        private void TTBaoHanhStrip_Click(object sender, EventArgs e)
        {
            fsuachua f = new fsuachua();
            this.Hide();
            f.Show();
        }

        private void TTBaoTriStrip_Click(object sender, EventArgs e)
        {
            fthuhoi f = new fthuhoi();
            this.Hide();
            f.Show();
        }

        private void nhómSửaChữaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            floaisuachua f = new floaisuachua();
            f.Show();
            this.Hide();
        }

        private void nhómThuHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            floaithuhoi f = new floaithuhoi();
            f.Show();
            this.Hide();
        }

        private void nhómĐơnVịTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fdonvitinh f = new fdonvitinh();
            f.Show();
            this.Hide();
        }
    }
}
