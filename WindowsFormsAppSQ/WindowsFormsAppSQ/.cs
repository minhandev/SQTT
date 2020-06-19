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
    public partial class fQuanly : Form
    {
        public fQuanly()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {

        }

        private void btlThem_Click(object sender, EventArgs e)
        {
            txtmaql.Enabled = true;
            cbxnvkt.Text = " ";
            cbbtb.Text = " ";
            cbxnvkt.Text = " ";
            cbbdv.Text = " ";
            txtmaql.Text = " ";
            txtghichu.Text = " ";
        }

        private void btlXoa_Click(object sender, EventArgs e)
        {

        }

        private void btlSua_Click(object sender, EventArgs e)
        {
            txtmaql.Enabled = false;
        }

        private void btlXemLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btlThoat_Click(object sender, EventArgs e)
        {
            fmain f = new fmain();
            this.Hide();
            f.Show();
        }

        private void btlLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
