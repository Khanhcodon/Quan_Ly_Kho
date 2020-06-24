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

namespace Quan_Ly_Kho.View.ManhQuan
{
    public partial class FormChiTietPhieuNhap : Form
    {
        Quan_Ly_KhoEntities db = new Quan_Ly_KhoEntities();
        public static string MaPN { get; set; }
        public FormChiTietPhieuNhap()
        {
            InitializeComponent();
        }
        PhieuNhap pn;
        string selectedMaHH;
        private void FormChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            pn = db.PhieuNhaps.SingleOrDefault(x => x.maPN == MaPN);

            listViewCtpn.Items.Clear();
            lbPhieuNhap.Text = "Chi tiết phiếu nhập " + MaPN;
            List<Chitietnhap> dsCTPN = db.Chitietnhaps.Where(x => x.maPN == MaPN).ToList();

            foreach (Chitietnhap ctpn in dsCTPN)
            {
                ListViewItem newItem = new ListViewItem(ctpn.maHH);
                newItem.SubItems.Add(ctpn.HangHoa.tenHH);
                newItem.SubItems.Add(ctpn.soLuong.ToString());
                newItem.SubItems.Add(ctpn.thanhTien.Value.ToString("#,##"));
                listViewCtpn.Items.Add(newItem);
            }

            cbSanPham.DataSource = db.HangHoas.ToList();
            cbSanPham.DisplayMember = "tenHH";
            cbSanPham.ValueMember = "maHH";
        }

        private void listViewCtpn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCtpn.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewCtpn.SelectedItems[0];
                selectedMaHH = selectedItem.SubItems[0].Text;
                cbSanPham.Text = selectedItem.SubItems[1].Text;
                txtSoLuong.Text = selectedItem.SubItems[2].Text;
                txtDonGia.Text = selectedItem.SubItems[3].Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thêm thông tin vừa nhập cho phiếu nhập đã chọn không?", "Thông báo", MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    Chitietnhap ctpn1 = db.Chitietnhaps.Single(x => x.maPN == pn.maPN && x.maHH == selectedMaHH);
                    if(ctpn1!=null)
                    {
                        ctpn1.soLuong += int.Parse(txtSoLuong.Text);
                        HangHoa hh = db.HangHoas.Single(x => x.maHH == ctpn1.maHH);
                        hh.soluong += ctpn1.soLuong;
                        pn.tongTien += int.Parse(txtSoLuong.Text) * ctpn1.thanhTien;
                    }   
                    else
                    {
                        Chitietnhap ctPN = new Chitietnhap()
                        {
                            maPN = MaPN,
                            maHH = cbSanPham.SelectedValue.ToString(),
                            soLuong = int.Parse(txtSoLuong.Text),
                            thanhTien = decimal.Parse(txtDonGia.Text)
                        };
                        HangHoa hh = db.HangHoas.Single(x => x.maHH == ctPN.maHH);
                        hh.soluong += ctPN.soLuong;

                        db.Chitietnhaps.Add(ctPN);
                        pn.tongTien += ctPN.soLuong * ctPN.thanhTien;
                    }    
                    
                    db.SaveChanges();
                    FormChiTietPhieuNhap_Load(sender, e);
                    MessageBox.Show("Thêm thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin đã chọn không?", "Thông báo", MessageBoxButtons.YesNo)
               == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    Chitietnhap ctPN = db.Chitietnhaps.SingleOrDefault(x => x.maPN == MaPN && x.maHH == selectedMaHH);
                    ctPN.HangHoa.soluong -= ctPN.soLuong;
                    pn.tongTien -= ctPN.soLuong * ctPN.thanhTien.Value;

                    ctPN.maHH = cbSanPham.SelectedValue.ToString();
                    ctPN.soLuong = int.Parse(txtSoLuong.Text);
                    ctPN.thanhTien = decimal.Parse(txtDonGia.Text);

                    pn.tongTien += ctPN.soLuong * ctPN.thanhTien.Value;

                    HangHoa hh = db.HangHoas.Single(x => x.maHH == ctPN.maHH);
                    hh.soluong += ctPN.soLuong;

                    db.SaveChanges();
                    FormChiTietPhieuNhap_Load(sender, e);

                    MessageBox.Show("Sửa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin đã chọn không?", "Thông báo", MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    Chitietnhap ctPN = db.Chitietnhaps.SingleOrDefault(x => x.maPN == MaPN && x.maHH == selectedMaHH);

                    pn.tongTien -= ctPN.soLuong * ctPN.thanhTien;

                    HangHoa hh = db.HangHoas.SingleOrDefault(x => x.maHH == ctPN.maHH);
                    hh.soluong += ctPN.soLuong;

                    db.Chitietnhaps.Remove(ctPN);
                    db.SaveChanges();
                    FormChiTietPhieuNhap_Load(sender, e);
                    MessageBox.Show("Xóa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
