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
    public partial class fdonvi : Form
    {
        SQTTEntities db = new SQTTEntities();
        public fdonvi()
        {
            InitializeComponent();
            LoadData();
            Biding();
        }

        private void LoadData()
        {
            var data = from c in db.DonVis select new { Mã = c.MaDV, Tên = c.TenDonVi, Số_liên_lạc = c.FAX, Địa_điểm = c.DiaDiem };
            dataGridView.DataSource = data.ToList();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Biding()
        {
            txtm.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Mã"));
            txtt.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Tên"));
            txts.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Số_liên_lạc"));
            txtd.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Địa_điểm"));
        }

        private void btlThem_Click(object sender, EventArgs e)
        {
            txtm.Enabled = true;
            txtm.Text = " ";
            txtt.Text = " ";
            txts.Text = " ";
            txtd.Text = " ";
        }

        private void btlXoa_Click(object sender, EventArgs e)
        {
            var a = db.DonVis.Find(Convert.ToInt32(txtm.Text));
            db.DonVis.Remove(a);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btlSua_Click(object sender, EventArgs e)
        {
            var a = db.DonVis.Find(Convert.ToInt32(txtm.Text));
            a.TenDonVi = txtt.Text;
            a.DiaDiem = txtd.Text;
            a.FAX = txts.Text;
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btlLuu_Click(object sender, EventArgs e)
        {
            var a = new DonVi()
            {
                MaDV = Convert.ToInt32(txtm.Text),
                TenDonVi = txtt.Text,
                DiaDiem = txtd.Text,
                FAX = txts.Text,
            };
            db.DonVis.Add(a);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btlXemLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btlThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            fmain f = new fmain();
            f.Show();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtm.Enabled = false;
        }

        private void fdonvi_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void fdonvi_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmain f = new fmain();
            this.Hide();
            f.Show();
        }
    }
}
