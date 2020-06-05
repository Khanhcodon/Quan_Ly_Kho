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
using Quan_Ly_Kho.Controller;

namespace Quan_Ly_Kho.View
{
    public partial class FormDangNhap : Form
    {
        Quan_Ly_KhoEntities db = new Quan_Ly_KhoEntities();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan resUser = db.TaiKhoans.SingleOrDefault(x => x.account == textBoxUserName.Text && x.pass == textBoxPassWord.Text);
                if (resUser != null)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                    FormMain fm = new FormMain();
                    this.Hide();
                    fm.ShowDialog();
                    this.Close();
                }
                else MessageBox.Show("Tài khoản đã hoặc mật khẩu không đúng, mời đăng nhập lại !", "Thông báo");
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDangKy dk = new FormDangKy();
            this.Hide();
            dk.ShowDialog();
            this.Show();
        }
   }
}
