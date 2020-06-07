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
    public partial class FormCTXuat : Form
    {
        Quan_Ly_KhoEntities db = new Quan_Ly_KhoEntities();
        PhieuXuat px;
        string selectedMaHH;
        public static string MaPX { get; set; }
        public FormCTXuat()
        {
            InitializeComponent();
        }

        private void FormCTXuat_Load(object sender, EventArgs e)
        {
            px = db.PhieuXuats.SingleOrDefault(x => x.maPX == MaPX);
            listViewCTX.Items.Clear();
            labelMaPX.Text = MaPX;
            List<Chitietxuat> dsCTX = db.Chitietxuats.Where(x => x.maPX == MaPX).ToList();

            foreach (Chitietxuat ctx in dsCTX)
            {
                HangHoa hh = db.HangHoas.SingleOrDefault(x => x.maHH == ctx.maHH);
                ListViewItem newItem = new ListViewItem(hh.tenHH);
                newItem.SubItems.Add(hh.tenHH);
                newItem.SubItems.Add(ctx.soLuong.ToString());
                newItem.SubItems.Add(ctx.thanhTien.ToString());
                listViewCTX.Items.Add(newItem);
            }

            comboBoxMaHH.DataSource = db.HangHoas.ToList();
            comboBoxMaHH.DisplayMember = "tenHH";
            comboBoxMaHH.ValueMember = "maHH";
        }

        private void listViewCTX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCTX.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewCTX.SelectedItems[0];
                selectedMaHH = selectedItem.SubItems[0].Text;
                comboBoxMaHH.Text = selectedMaHH;
                textBoxSL.Text = selectedItem.SubItems[1].Text;
                textBoxDonGia.Text = selectedItem.SubItems[2].Text;
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                Chitietxuat ctx = new Chitietxuat()
                {
                    maPX = MaPX,
                    maHH = comboBoxMaHH.SelectedValue.ToString(),
                    soLuong = int.Parse(textBoxSL.Text),
                    thanhTien = decimal.Parse(textBoxDonGia.Text)
                };
                px.tongTien += ctx.soLuong * ctx.thanhTien;

                HangHoa hh = db.HangHoas.Single(x => x.maHH == ctx.maHH);
                hh.soluong += ctx.soLuong;

                db.Chitietxuats.Add(ctx);
                db.SaveChanges();
                FormCTXuat_Load(sender, e);
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                Chitietxuat ctx = db.Chitietxuats.SingleOrDefault(x => x.maPX == MaPX && x.maHH == selectedMaHH);
                int soLuongHHcu = int.Parse(ctx.soLuong.ToString());
                decimal donGiaCu = decimal.Parse(ctx.thanhTien.ToString());

                ctx.maHH = comboBoxMaHH.SelectedValue.ToString();
                ctx.soLuong = int.Parse(textBoxSL.Text);
                ctx.thanhTien = decimal.Parse(textBoxDonGia.Text);

                decimal thanhTienCu = soLuongHHcu * donGiaCu;
                decimal thanhTienMoi = decimal.Parse(ctx.thanhTien.ToString()) * int.Parse(ctx.soLuong.ToString());

                px.tongTien += (thanhTienMoi - thanhTienCu);

                HangHoa hh = db.HangHoas.Single(x => x.maHH == ctx.maHH);
                hh.soluong = soLuongHHcu - ctx.soLuong;

                db.SaveChanges();
                FormCTXuat_Load(sender, e);
                MessageBox.Show("Sửa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban muon xoa?", "Thong bao", MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    Chitietxuat ctx = db.Chitietxuats.SingleOrDefault(x => x.maPX == MaPX && x.maHH == selectedMaHH);

                    px.tongTien -= ctx.soLuong * ctx.thanhTien;

                    HangHoa hh = db.HangHoas.SingleOrDefault(x => x.maHH == ctx.maHH);
                    hh.soluong += ctx.soLuong;

                    db.Chitietxuats.Remove(ctx);
                    db.SaveChanges();
                    FormCTXuat_Load(sender, e);
                    MessageBox.Show("Xóa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            FormMain fm = new FormMain();
            this.Hide();
            fm.ShowDialog();
            this.Show();
        }
    }
    
}
