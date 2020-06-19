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
    public partial class fnhomthietbi : Form
    {
        SQTTEntities db = new SQTTEntities();
        public fnhomthietbi()
        {
            InitializeComponent();
            LoadData();
            Biding();
        }
        private void LoadData()
        {
            var data = from c in db.NhomThietBis select new { Mã = c.MaNhom, Tên = c.TenNhom, Ghi_chú = c.GhiChu };
            dataGridView.DataSource = data.ToList();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Biding()
        {
            txtm.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Mã"));
            txtt.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Tên"));
            txtg.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Ghi_chú"));
        }
        private void btlThem_Click(object sender, EventArgs e)
        {
            txtm.Enabled = true;
            txtg.Text = " ";
            txtt.Text = " ";
            txtg.Text = " ";
        }

        private void btlXoa_Click(object sender, EventArgs e)
        {
            var a = db.NhomThietBis.Find(Convert.ToInt32(txtm.Text));
            db.NhomThietBis.Remove(a);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btlSua_Click(object sender, EventArgs e)
        {
            var a = db.NhomThietBis.Find(Convert.ToInt32(txtm.Text));
            a.TenNhom = txtt.Text;
            a.GhiChu = txtt.Text;
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btlLuu_Click(object sender, EventArgs e)
        {
            var a = new NhomThietBi()
            {
                MaNhom = Convert.ToInt32(txtm.Text),
                TenNhom = txtt.Text,
                GhiChu = txtg.Text
            };
            db.NhomThietBis.Add(a);
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
            fmain f = new fmain();
            this.Hide();
            f.Show();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtm.Enabled = false;
        }

        private void fnhomthietbi_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmain f = new fmain();
            this.Hide();
            f.Show();
        }
    }
}
