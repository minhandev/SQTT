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
    public partial class fthuhoi : Form
    {
        SQTTEntities db = new SQTTEntities();
        public fthuhoi()
        {
            InitializeComponent();
            LoadData();
            Biding();
        }

        private void LoadData()
        {
            var data = from c in db.ThuHois select new { Mã = c.MaTH, Tên_thiết_bị = c.ThietBi.TenThietBi, Loại_thu_hồi = c.LoaiThuHoi.TenLoaiThuHoi, Thời_gian = c.Thoigian, Ghi_chú = c.GhiChu };
            dataGridView.DataSource = data.ToList();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Biding()
        {
            txtm.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Mã"));
            cbbt.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Tên_thiết_bị"));
            cbbl.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Loại_thu_hồi"));
            txtgc.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Ghi_chú"));
        }
        private void btlXoa_Click(object sender, EventArgs e)
        {
            var a = db.ThuHois.Find(Convert.ToInt32(txtm.Text));
            db.ThuHois.Remove(a);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btlThem_Click(object sender, EventArgs e)
        {
            txtm.Enabled = true;
        }

        private void btlSua_Click(object sender, EventArgs e)
        {
            var a = db.ThuHois.Find(Convert.ToInt32(txtm.Text));
            a.MaTH = Convert.ToInt32(txtm.Text);
            a.MaLTH = Convert.ToInt32(cbbl.SelectedValue);
            a.MaTB = Convert.ToInt32(cbbt.SelectedValue);
            a.GhiChu = txtm.Text;
            
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btlLuu_Click(object sender, EventArgs e)
        {
            ThuHoi a = new ThuHoi()
            {
                MaTH = Convert.ToInt32(txtm.Text),
                MaTB = Convert.ToInt32(cbbt.SelectedValue),
                GhiChu = txtgc.Text,
                Thoigian = DateTime.Now,
                MaLTH = Convert.ToInt32(cbbl.SelectedValue)
        };
            db.ThuHois.Add(a);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btlXemLai_Click(object sender, EventArgs e)
        {

        }

        private void btlThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
