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
    public partial class floaithuhoi : Form
    {
        SQTTEntities db = new SQTTEntities();
        public floaithuhoi()
        {
            InitializeComponent();
            LoadData();
            Biding();
        }

        private void LoadData()
        {
            var data = from c in db.LoaiThuHois select new { Mã = c.MaLTH, Tên = c.TenLoaiThuHoi, Ghi_chú = c.GhiChu};
            dataGridView.DataSource = data.ToList();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Biding()
        {
            txtm.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Mã"));
            txtt.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Tên"));
            txtgc.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Ghi_chú"));
        }
        private void btlThem_Click(object sender, EventArgs e)
        {
            txtm.Enabled = true;
        }

        private void btlXoa_Click(object sender, EventArgs e)
        {
            var a = db.LoaiThuHois.Find(Convert.ToInt32(txtm.Text));
            db.LoaiThuHois.Remove(a);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btlSua_Click(object sender, EventArgs e)
        {
            var a = db.LoaiThuHois.Find(Convert.ToInt32(txtm.Text));
            a.TenLoaiThuHoi = txtt.Text;
            a.GhiChu = txtgc.Text;
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btlLuu_Click(object sender, EventArgs e)
        {
            LoaiThuHoi a = new LoaiThuHoi()
            {
                MaLTH = Convert.ToInt32(txtm.Text),
                TenLoaiThuHoi = txtt.Text,
                GhiChu = txtgc.Text
            };
            db.LoaiThuHois.Add(a);
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
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtm.Enabled = false;
        }
    }
}
