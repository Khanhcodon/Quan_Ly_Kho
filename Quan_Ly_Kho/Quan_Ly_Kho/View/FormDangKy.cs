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

namespace Quan_Ly_Kho.View
{
    public partial class FormDangKy : Form
    {
        Quan_Ly_KhoEntities db = new Quan_Ly_KhoEntities();
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn đăng ký tài khoản mới không?", "Thông báo", MessageBoxButtons.YesNo)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    TaiKhoan resUser = db.TaiKhoans.SingleOrDefault(x => x.account == textBoxUserName.Text);
                    if (resUser == null)
                    {
                        TaiKhoan newUser = TaoUser();
                        db.TaiKhoans.Add(newUser);
                        db.SaveChanges();
                        MessageBox.Show("Chúc mừng bạn đã đăng ký thành công!", "Thông báo");
                        FormDangNhap DN = new FormDangNhap();
                        this.Hide();
                        DN.ShowDialog();
                        this.Close();
                    }
                    else MessageBox.Show("Tài khoản đã có người sử dụng!", "Thông báo");
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex.Message, "Thông báo"); }
        }
        TaiKhoan TaoUser()
        {
            TaiKhoan newUser = new TaiKhoan()
            {
                email = textBoxEmail.Text,
                account = textBoxUserName.Text,
                pass = textBoxPassWord.Text
            };
            return newUser;
        }
    }
}
