using Microsoft.Reporting.WinForms;
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
    public partial class frpthietbi : Form
    {
        SQTTEntities db = new SQTTEntities();
        public frpthietbi()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var query = from a in db.ThietBis
                        join b in db.NhaCungCaps on a.MaNCC equals b.MaNCC
                        join c in db.DonVis on a.MaDV equals c.MaDV
                        from f in db.NhomThietBis.Where(x => x.MaNhom == a.MaNhom).DefaultIfEmpty()
                        select new
                        {
                            a.MaTB,
                            a.TenThietBi,
                            b.TenNhaCungCap,
                            a.SoLuong,
                            f.TenNhom,
                            c.TenDonVi
                        };

            ReportDataSource rds = new ReportDataSource("DataSettb", query);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\minhandev\Desktop\SQTT\WindowsFormsAppSQ\WindowsFormsAppSQ\ReportTB.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void frpthietbi_FormClosed(object sender, FormClosedEventArgs e)
        {
            fmain f = new fmain();
            f.Show();
            this.Hide();
        }
    }
}
