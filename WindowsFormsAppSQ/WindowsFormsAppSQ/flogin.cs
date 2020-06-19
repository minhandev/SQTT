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
    public partial class fLogin : Form
    {
        SQTTEntities db = new SQTTEntities();
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            var data = db.NguoiDungs.Where(x => x.Taikhoan == txtTenDangNhap.Text && x.Matkhau == txtPassword.Text).Single();
            if (data != null)
            {
                fmain f = new fmain();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
    }
}
