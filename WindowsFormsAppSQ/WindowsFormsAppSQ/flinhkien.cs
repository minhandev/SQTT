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
    public partial class flinhkien : Form
    {
        SQTTEntities db = new SQTTEntities();
        public flinhkien()
        {
            InitializeComponent();
            LoadData();
            Biding();
        }

        private void LoadData()
        {
            var data = from c in db.LinhKiens select new { Mã = c.MaLK, Tên = c.TenLK, Năm_SX = c.NamSX, Đơn_vị = c.DonViTinh.TenDVT };
            dataGridView.DataSource = data.ToList();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            comboBox.DataSource = db.DonViTinhs.ToList();
            comboBox.DisplayMember = "TenDVT";
            comboBox.ValueMember = "MaDVT";
        }

        private void Biding()
        {
            txtm.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Mã"));
            txtt.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Tên"));
            comboBox.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Đơn_vị"));
            txtd.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Năm_SX"));
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btlSua_Click(object sender, EventArgs e)
        {
            txtm.Enabled = false;
            var a = db.LinhKiens.Find(Convert.ToInt32(txtm.Text));
            a.TenLK = txtt.Text;
            a.NamSX = txtm.Text;
            a.MaDVT = Convert.ToInt32(comboBox.SelectedValue);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btlXoa_Click(object sender, EventArgs e)
        {
            txtm.Enabled = false;
            var a = db.LinhKiens.Find(Convert.ToInt32(txtm.Text));
            db.LinhKiens.Remove(a);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btlLuu_Click(object sender, EventArgs e)
        {
            LinhKien a = new LinhKien()
            {
                MaLK = Convert.ToInt32(txtm.Text),
                TenLK = txtt.Text,
                NamSX = txtd.Text,
                MaDVT = Convert.ToInt32(comboBox.SelectedValue)
            };
            db.LinhKiens.Add(a);
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
