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
    public partial class fnphutrach : Form
    {
        SQTTEntities db = new SQTTEntities();
        public fnphutrach()
        {
            InitializeComponent();
            LoadData();
            Biding();
        }

        private void fnphutrach_Load(object sender, EventArgs e)
        {
            comboBox.DataSource = db.DonVis.ToList();
            comboBox.DisplayMember = "TenDonVi";
            comboBox.ValueMember = "MaDV";
        }

        private void LoadData()
        {
            var data = from c in db.NguoiPhuTraches select new { Mã = c.MaNguoiPhuTrach, Tên = c.TenNguoiPhuTrach, Số_ĐT = c.SDT, Thêm_vào = c.ThoiGian, Đơn_vị = c.DonVi.TenDonVi };
            dataGridView.DataSource = data.ToList();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Biding()
        {
            txtmpt.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Mã"));
            txttpt.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Tên"));
            comboBox.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Đơn_vị"));
            txtSdt.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Số_ĐT"));
        }

        private void btlThem_Click(object sender, EventArgs e)
        {
            txtmpt.Enabled = true;
            txtmpt.Text = " ";
            txttpt.Text = " ";
            txtSdt.Text = " ";
        }

        private void btlXoa_Click(object sender, EventArgs e)
        {
            txtmpt.Enabled = false;
            var a = db.NguoiPhuTraches.Find(Convert.ToInt32(txtmpt.Text));
            db.NguoiPhuTraches.Remove(a);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btlSua_Click(object sender, EventArgs e)
        {
            txtmpt.Enabled = false;
            var a = db.NguoiPhuTraches.Find(Convert.ToInt32(txtmpt.Text));
            a.TenNguoiPhuTrach = txttpt.Text;
            a.SDT = txtSdt.Text;
            a.MaDV = Convert.ToInt32(comboBox.SelectedValue);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btlLuu_Click(object sender, EventArgs e)
        {
            NguoiPhuTrach a = new NguoiPhuTrach()
            {
                MaNguoiPhuTrach = Convert.ToInt32(txtmpt.Text),
                TenNguoiPhuTrach = txttpt.Text,
                ThoiGian = DateTime.Now,
                MaDV = Convert.ToInt32(comboBox.SelectedValue),
                SDT = txtSdt.Text
            };
            db.NguoiPhuTraches.Add(a);

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

        private void comboBox_DropDownStyleChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmpt.Enabled = false;
        }

        private void fnphutrach_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmain f = new fmain();
            f.Show();
            this.Hide();
        }
    }
}
