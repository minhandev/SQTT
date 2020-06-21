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
    public partial class fdonvitinh : Form
    {
        SQTTEntities db = new SQTTEntities();
        public fdonvitinh()
        {
            InitializeComponent();
            LoadData();
            Biding();
        }

        private void LoadData()
        {
            var data = from c in db.DonViTinhs select new { Mã = c.MaDVT, Tên = c.TenDVT };
            dataGridView.DataSource = data.ToList();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Biding()
        {
            txtm.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Mã"));
            txtt.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Tên"));
        }

        private void btlThem_Click(object sender, EventArgs e)
        {
            txtm.Enabled = true;
            txtm.Text = " ";
            txtt.Text = " ";
        }

        private void btlXoa_Click(object sender, EventArgs e)
        {
            var a = db.DonViTinhs.Find(Convert.ToInt32(txtm.Text));
            db.DonViTinhs.Remove(a);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btlSua_Click(object sender, EventArgs e)
        {
            var a = db.DonViTinhs.Find(Convert.ToInt32(txtm.Text));
            a.TenDVT = txtt.Text;
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btlLuu_Click(object sender, EventArgs e)
        {
            DonViTinh a = new DonViTinh()
            {
                MaDVT = Convert.ToInt32(txtm.Text),
                TenDVT = txtt.Text
            };
            db.DonViTinhs.Add(a);
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
            f.Show();
            this.Hide();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtm.Enabled = false;
        }
    }
}
