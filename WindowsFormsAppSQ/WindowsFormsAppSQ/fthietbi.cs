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
    public partial class fthietbi : Form
    {
        SQTTEntities db = new SQTTEntities();
        public fthietbi()
        {
            InitializeComponent();
            LoadData();
            Biding();
        }
        private void LoadData()
        {
            var data = from c in db.ThietBis select new { Mã = c.MaTB , Tên = c.TenThietBi, Nhà_cung_cấp = c.NhaCungCap.TenNhaCungCap, Loại_thiết_bị = c.NhomThietBi.TenNhom, Đơn_vị = c.DonVi.TenDonVi, Số_lượng = c.SoLuong};
            dataGridView.DataSource = data.ToList();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ccbncc.DataSource = db.NhaCungCaps.ToList();
            ccbncc.ValueMember = "MaNCC";
            ccbncc.DisplayMember = "TenNhaCungCap";
           
            ccbtb.DataSource = db.NhomThietBis.ToList();
            ccbtb.ValueMember = "MaNhom";
            ccbtb.DisplayMember = "TenNhom";

            ccbdv.DataSource = db.DonVis.ToList();
            ccbdv.ValueMember = "MaDV";
            ccbdv.DisplayMember = "TenDonVi";


        }

        private void Biding()
        {
            txtm.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Mã"));
            txtt.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Tên"));
            ccbncc.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Nhà_cung_cấp"));
            ccbtb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Loại_thiết_bị"));
            ccbdv.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Đơn_vị"));
            txtsl.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Số_lượng"));
        }

        private void btlThem_Click(object sender, EventArgs e)
        {

        }

        private void btlXoa_Click(object sender, EventArgs e)
        {
            txtm.Enabled = false;
            var a = db.ThietBis.Find(Convert.ToInt32(txtm.Text));
            db.ThietBis.Remove(a);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btlSua_Click(object sender, EventArgs e)
        {
            txtm.Enabled = false;
            var a = db.ThietBis.Find(Convert.ToInt32(txtm.Text));
            a.MaTB = Convert.ToInt32(txtm.Text);
            a.TenThietBi = txtt.Text;
            a.MaNCC = Convert.ToInt32(ccbncc.SelectedValue);
            a.SoLuong = txtsl.Text;
            a.MaNhom = Convert.ToInt32(ccbtb.SelectedValue);
            a.MaDV = Convert.ToInt32(ccbdv.SelectedValue);

            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btlLuu_Click(object sender, EventArgs e)
        {
            ThietBi a = new ThietBi()
            {
                MaTB = Convert.ToInt32(txtm.Text),
                TenThietBi = txtt.Text,
                MaNCC = Convert.ToInt32(ccbncc.SelectedValue),
                MaNhom = Convert.ToInt32(ccbtb.SelectedValue),
                MaDV = Convert.ToInt32(ccbdv.SelectedValue),
                SoLuong = txtsl.Text,

            };
            db.ThietBis.Add(a);
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
    }
}
