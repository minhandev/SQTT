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
            var data = from c in db.SuaChuas select new { Mã = c.MaSC, Tên = c.ThietBi.TenThietBi, Sửa_Chữa = c.LoaiSuaChua.TenLoaiSuaChua, Chất_lượng = c.ChatLuong, Thời_Gian = c.thoigian, Tình_trạng = c.TinhTrang, Ghi_Chú = c.GhiChu };
            dataGridView.DataSource = data.ToList();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Biding()
        {
            //txtmpt.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Mã"));
            //txttpt.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Tên"));
            //comboBox.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Đơn_vị"));
            //txtSdt.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Số_ĐT"));
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

        private void btlXoa_Click(object sender, EventArgs e)
        {

        }

        private void btlSua_Click(object sender, EventArgs e)
        {

        }

        private void btlLuu_Click(object sender, EventArgs e)
        {

        }

        private void btlXemLai_Click(object sender, EventArgs e)
        {

        }

        private void btlThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
