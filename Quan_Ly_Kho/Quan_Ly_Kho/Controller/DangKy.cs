using Quan_Ly_Kho.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Kho.Controller
{
    public partial class DangKy : Form
    {
        Quan_Ly_KhoEntities db = new Quan_Ly_KhoEntities();
        public DangKy()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string TaiKhoan = txtID.Text;
            TaiKhoan KtrTK = db.TaiKhoans.SingleOrDefault(x => x.id == TaiKhoan);
            if (KtrTK == null)
            {
                TaiKhoan TKmoi = new TaiKhoan()
                {
                    id = txtID.Text,
                    pass = txtPass.Text
                };
                db.TaiKhoans.Add(TKmoi);
                db.SaveChanges();
                MessageBox.Show("Đăng ký thành công", "thông báo");
                DangNhap DN = new DangNhap();
                this.Hide();
                DN.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Tài khoản đã tồn tại", "thông báo");
        }
    }
}
