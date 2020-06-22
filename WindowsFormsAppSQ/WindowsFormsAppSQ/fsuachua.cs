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
    public partial class fsuachua : Form
    {
        SQTTEntities db = new SQTTEntities();
        public fsuachua()
        {
            InitializeComponent();
            LoadData();
            //Biding();
        }

        private void LoadData()
        {
            var data = from c in db.SuaChuas select new { Mã = c.MaSC, Tên_thiết_bị = c.ThietBi.TenThietBi, Loại_sửa_chữa = c.LoaiSuaChua.TenLoaiSuaChua, Chất_lượng = c.ChatLuong, Thời_Gian = c.thoigian, Tình_trạng = c.TinhTrang, Ghi_Chú = c.GhiChu };
            dataGridView.DataSource = data.ToList();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cbbtb.DataSource = db.ThietBis.ToList();
            cbbtb.DisplayMember = "TenThietBi";
            cbbtb.ValueMember = "MaTB";

            ccbsc.DataSource = db.LoaiSuaChuas.ToList();
            ccbsc.DisplayMember = "TenLoaiSuaChua";
            ccbsc.ValueMember = "MaLSC";

        }

        private void Biding()
        {
            txtm.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Mã"));
            cbbtb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Tên_thiết_bị"));
            ccbsc.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Loại_sửa_chữa"));
            txtcl.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Chất_lượng"));
            txtcl.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Tình_trạng"));
            txtgc.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Ghi_Chú"));

        }
       
        private void btlXoa_Click(object sender, EventArgs e)
        {
            var a = db.SuaChuas.Find(Convert.ToInt32(txtm.Text));
            db.SuaChuas.Remove(a);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btlSua_Click(object sender, EventArgs e)
        {
            var a = db.SuaChuas.Find(Convert.ToInt32(txtm.Text));
            a.MaLSC = Convert.ToInt32(ccbsc.SelectedValue);
            a.MaTB = Convert.ToInt32(cbbtb.SelectedValue);
            a.thoigian = DateTime.Now;
            a.ChatLuong = txtcl.Text;
            a.TinhTrang = txttt.Text;
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
            SuaChua a = new SuaChua()
            {
                MaSC = Convert.ToInt32(txtm.Text),
                MaLSC = Convert.ToInt32(ccbsc.SelectedValue),
                MaTB = Convert.ToInt32(cbbtb.SelectedValue),
                thoigian = DateTime.Now,
                ChatLuong = txtcl.Text,
                TinhTrang = txttt.Text,
                GhiChu = txtgc.Text,
            };
            db.SuaChuas.Add(a);
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

        private void fsuachua_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmain f = new fmain();
            f.Show();
            this.Hide();
        }

        private void btlThem_Click(object sender, EventArgs e)
        {
            txtm.Enabled = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ThanhTacVu_RefreshItems(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
