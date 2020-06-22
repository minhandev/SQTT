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
    public partial class fnhacungcap : Form
    {
        SQTTEntities db = new SQTTEntities();
        public fnhacungcap()
        {
            InitializeComponent();
            LoadData();
            Biding();
        }

        private void LoadData()
        {
            var data = from c in db.NhaCungCaps select new { Mã = c.MaNCC, Tên = c.TenNhaCungCap, Số_ĐT = c.SDT, Địa_Điểm = c.DiaChi };
            dataGridView.DataSource = data.ToList();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Biding()
        {
            txtm.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Mã"));
            txtt.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Tên"));
            txts.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Số_ĐT"));
            txtd.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Địa_Điểm"));
        }

        private void btlThem_Click(object sender, EventArgs e)
        {
            txtm.Enabled = true;
            txtm.Text = " ";
            txts.Text = " ";
            txtd.Text = " ";
            txtt.Text = " ";
        }

        private void btlXoa_Click(object sender, EventArgs e)
        {
            var a = db.NhaCungCaps.Find(Convert.ToInt32(txtm.Text));
            db.NhaCungCaps.Remove(a);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btlSua_Click(object sender, EventArgs e)
        {
            var a = db.NhaCungCaps.Find(Convert.ToInt32(txtm.Text));
            a.TenNhaCungCap = txtt.Text;
            a.DiaChi = txtd.Text;
            a.SDT = txts.Text;
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btlLuu_Click(object sender, EventArgs e)
        {
            NhaCungCap a = new NhaCungCap()
            {
                MaNCC = Convert.ToInt32(txtm.Text),
                TenNhaCungCap = txtt.Text.ToString(),
                DiaChi = txtd.Text.ToString(),
                SDT = txts.Text.ToString(),
            };
            db.NhaCungCaps.Add(a);
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

        private void fnhacungcap_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmain f = new fmain();
            f.Show();
            this.Hide();
        }
    }
}
