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
    public partial class floaisuachua : Form
    {
        SQTTEntities db = new SQTTEntities();
        public floaisuachua()
        {
            InitializeComponent();
            LoadData();
            Biding();
        }
        private void LoadData()
        {
            var data = from c in db.LoaiSuaChuas select new { Mã = c.MaLSC, Tên = c.TenLoaiSuaChua, Linh_kiện = c.LKThay };
            dataGridView.DataSource = data.ToList();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Biding()
        {
            txtm.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Mã"));
            txtt.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Tên"));
            txttt.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Linh_kiện"));
        }

        private void btlThem_Click(object sender, EventArgs e)
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

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
