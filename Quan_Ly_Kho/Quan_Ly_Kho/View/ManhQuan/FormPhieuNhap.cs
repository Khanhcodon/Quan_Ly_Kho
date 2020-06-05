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

namespace Quan_Ly_Kho.View.ManhQuan
{
    public partial class FormPhieuNhap : Form
    {
        Quan_Ly_KhoEntities db = new Quan_Ly_KhoEntities();
        public static string MaPN { get; set; }
        public FormPhieuNhap()
        {
            InitializeComponent();
        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            List<PhieuNhap> dsPN = db.PhieuNhaps.ToList();
            listViewPhieuNhap.Items.Clear();
            foreach (PhieuNhap pn in dsPN)
            {
                ListViewItem newItem = new ListViewItem(pn.maPN);
                newItem.SubItems.Add(pn.ngayNhap.ToString());
                newItem.SubItems.Add(pn.tongTien.ToString());
                listViewPhieuNhap.Items.Add(newItem);
            }
        }

        private void listViewPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPhieuNhap.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewPhieuNhap.SelectedItems[0];
                MaPN = selectedItem.SubItems[0].Text;
                txtMaPN.Text = MaPN;
                dtNgayViet.Value = DateTime.Parse(selectedItem.SubItems[1].Text);
                lbThanhTien.Text = selectedItem.SubItems[2].Text;
            }
        }

        private void ThemPN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm 1 phiếu nhập mới không?", "Thông báo", MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    PhieuNhap newPN = new PhieuNhap()
                    {
                        maPN = txtMaPN.Text,
                        ngayNhap = dtNgayViet.Value,
                        tongTien = 0
                    };
                    db.PhieuNhaps.Add(newPN);
                    db.SaveChanges();
                    FormPhieuNhap_Load(sender, e);
                    MessageBox.Show("Thêm thành công!");
                    FormChiTietPhieuNhap.MaPN = txtMaPN.Text;
                    if (MessageBox.Show("Bạn có muốn thêm 1 phiếu nhập mới không?", "Thông báo", MessageBoxButtons.YesNo)
                            == System.Windows.Forms.DialogResult.Yes)
                    {
                        ManhQuan.FormChiTietPhieuNhap ctpn = new FormChiTietPhieuNhap();
                        this.Hide();
                        ctpn.ShowDialog();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SuaPN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa phiếu nhập vừa chọn không?", "Thông báo", MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    PhieuNhap selectedItem = db.PhieuNhaps.SingleOrDefault(x => x.maPN == MaPN);
                    selectedItem.ngayNhap = dtNgayViet.Value;
                    db.SaveChanges();
                    FormPhieuNhap_Load(sender, e);
                    MessageBox.Show("Sửa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void XoaPN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa phiếu nhập vừa chọn không?", "Thông báo", MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    PhieuNhap selectedItem = db.PhieuNhaps.SingleOrDefault(x => x.maPN == MaPN);
                    List<Chitietnhap> dsSp = db.Chitietnhaps.Where(x => x.maPN == MaPN).ToList();
                    foreach (Chitietnhap ct in dsSp)
                    {
                        db.Chitietnhaps.Remove(ct);
                    }
                    db.SaveChanges();

                    db.PhieuNhaps.Remove(selectedItem);
                    db.SaveChanges();
                    FormPhieuNhap_Load(sender, e);

                    MessageBox.Show("Xóa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btChiTietPN_Click(object sender, EventArgs e)
        {
            if (MaPN == "")
            {
                MessageBox.Show("Bạn phải chọn phiếu nhập trước!", "Thông báo");
            }
            else
            {
                ManhQuan.FormChiTietPhieuNhap ctpn = new FormChiTietPhieuNhap();
                ManhQuan.FormChiTietPhieuNhap.MaPN = MaPN;
                this.Hide();
                ctpn.ShowDialog();
                this.Show();
            }
        }
    }
}
