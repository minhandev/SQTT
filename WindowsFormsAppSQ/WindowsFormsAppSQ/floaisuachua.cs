﻿using System;
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
            txtm.Text = " ";
            txttt.Text = " ";
            txtt.Text = " ";
            txtm.Enabled = true;
        }

        private void btlXoa_Click(object sender, EventArgs e)
        {
            var a = db.LoaiSuaChuas.Find(Convert.ToInt32(txtm.Text));
            db.LoaiSuaChuas.Remove(a);
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btlSua_Click(object sender, EventArgs e)
        {
            var a = db.LoaiSuaChuas.Find(Convert.ToInt32(txtm.Text));
            a.TenLoaiSuaChua = txtt.Text;
            a.LKThay = txttt.Text;
            if (db.SaveChanges() > 0)
            {
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                LoadData();
            }
            else MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }

        private void btlLuu_Click(object sender, EventArgs e)
        {
            LoaiSuaChua a = new LoaiSuaChua()
            {
                MaLSC = Convert.ToInt32(txtm.Text),
                TenLoaiSuaChua = txtt.Text,
                LKThay = txttt.Text
            };
            db.LoaiSuaChuas.Add(a);
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
