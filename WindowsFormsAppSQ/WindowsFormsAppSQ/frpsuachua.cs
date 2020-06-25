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
    public partial class frpsuachua : Form
    {
        SQTTEntities db = new SQTTEntities();
        public frpsuachua()
        {
            InitializeComponent();
        }

        private void frpsuachua_Load(object sender, EventArgs e)
        {
            var query = from a in db.SuaChuas
                        join b in db.ThietBis on a.MaTB equals b.MaTB
                        join c in db.LoaiSuaChuas on a.MaLSC equals c.MaLSC
                        join d in db.NhaCungCaps on b.MaNCC equals d.MaNCC
                        from f in db.DonVis.Where(x => b.MaDV == x.MaDV).DefaultIfEmpty()
                        select new
                        {
                            a.MaSC,
                            b.TenThietBi,
                            d.TenNhaCungCap,
                            f.TenDonVi,
                            b.SoLuong,
                            a.TinhTrang,
                            a.ChatLuong
                        };

            ReportDataSource rds = new ReportDataSource("DataSetSC", query);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\minhandev\Desktop\SQTT\WindowsFormsAppSQ\WindowsFormsAppSQ\ReportSuaChua.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
