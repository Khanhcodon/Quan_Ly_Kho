using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Ly_Kho.Model;

namespace Quan_Ly_Kho.Controller
{
    public partial class DangNhap : Form
    {
        Quan_Ly_KhoEntities db = new Quan_Ly_KhoEntities();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pBDangNhap_Click(object sender, EventArgs e)
        {
            string name = txtID.Text;
            string pas = txtPass.Text;
            if (name.Length == 0) MessageBox.Show("Bạn Chưa điền tên tài khoản", "thông báo");
            TaiKhoan taikhoan1 = db.TaiKhoans.SingleOrDefault(x => x.id == name && x.pass == pas);
            if (taikhoan1 != null)
            {
              
            }
            else MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "thông báo");
        }

        private void pBDangKy_Click(object sender, EventArgs e)
        {
            DangKy DK = new DangKy();
            this.Hide();
            DK.ShowDialog();
            this.Close();
        }
    }
}
