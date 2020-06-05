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
    public partial class FormChiTietPhieuNhap : Form
    {
        Quan_Ly_KhoEntities db = new Quan_Ly_KhoEntities();
        public static string MaPN;
        //public FormChiTietPhieuNhap()
        //{
        //    InitializeComponent();
        //}
        //PhieuNhap pn;
        //private string MaCTPN;
        //private void FormChiTietPhieuNhap_Load(object sender, EventArgs e)
        //{   
        //    pn = db.PhieuNhaps.SingleOrDefault(x => x.maPN == MaPN);
            
        //    pn.tongTien = 0;
        //    listViewCtpn.Items.Clear();
        //    lbPhieuNhap.Text = "Chi tiết phiếu nhập " + MaPN;
        //    List<Chitietnhap> dsCTPN = db.Chitietnhaps.Where(x => x.maPN == MaPN).ToList();

        //    foreach(Chitietnhap ctpn in dsCTPN)
        //    {
        //        ListViewItem newItem = new ListViewItem(ctpn.maCTN);
        //        HangHoa hh = db.HangHoas.SingleOrDefault(x => x.maHH == ctpn.maHH);
        //        newItem.SubItems.Add(hh.tenHH);
        //        newItem.SubItems.Add(ctpn.soLuong.ToString());
        //        newItem.SubItems.Add(ctpn.donGia.ToString());
        //        listViewCtpn.Items.Add(newItem);
        //    }

        //    cbSanPham.DataSource = db.HangHoas.ToList();
        //    cbSanPham.DisplayMember = "tenHH";
        //    cbSanPham.ValueMember = "maHH";
        //}

        //private void btThem_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Bạn có muốn thêm thông tin vừa nhập cho phiếu nhập đã chọn không?", "Thông báo", MessageBoxButtons.YesNo)
        //        == System.Windows.Forms.DialogResult.Yes)
        //    {
        //        try
        //        {
        //            Chitietnhap ctPN = new Chitietnhap()
        //            {
        //                maCTN = txtMaCTPN.Text,
        //                maPN = MaPN,
        //                maHH = cbSanPham.SelectedValue.ToString(),
        //                soLuong=int.Parse(txtSoLuong.Text),
        //                donGia=decimal.Parse(txtDonGia.Text)
        //            };
        //            pn.tongTien += ctPN.soLuong * ctPN.donGia;

        //            HangHoa hh = db.HangHoas.Single(x => x.maHH == ctPN.maHH);
        //            hh.soluong += ctPN.soLuong;
                    
        //            db.Chitietnhaps.Add(ctPN);
        //            db.SaveChanges();
        //            FormChiTietPhieuNhap_Load(sender, e);
        //            MessageBox.Show("Thêm thành công!");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //}

        //private void btSua_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Bạn có muốn sửa thông tin đã chọn không?", "Thông báo", MessageBoxButtons.YesNo)
        //        == System.Windows.Forms.DialogResult.Yes)
        //    {
        //        try
        //        {
        //            Chitietnhap ctPN = db.Chitietnhaps.SingleOrDefault(x => x.maCTN == MaCTPN);
        //            int soLuongHHcu = int.Parse(ctPN.soLuong.ToString());
        //            decimal donGiaCu = decimal.Parse(ctPN.donGia.ToString());

        //            ctPN.maHH = cbSanPham.SelectedValue.ToString();
        //            ctPN.soLuong = int.Parse(txtSoLuong.Text);
        //            ctPN.donGia = decimal.Parse(txtDonGia.Text);

        //            decimal thanhTienCu = soLuongHHcu * donGiaCu;
        //            decimal thanhTienMoi = decimal.Parse(ctPN.donGia.ToString()) * int.Parse(ctPN.soLuong.ToString());

        //            pn.tongTien += (thanhTienMoi - thanhTienCu);

        //            HangHoa hh = db.HangHoas.Single(x => x.maHH == ctPN.maHH);
        //            hh.soluong = soLuongHHcu - ctPN.soLuong;

        //            db.SaveChanges();
        //            FormChiTietPhieuNhap_Load(sender, e);
        //            MessageBox.Show("Sửa thành công!");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //}
        //private void btXoa_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Bạn có muốn xóa thông tin đã chọn không?", "Thông báo", MessageBoxButtons.YesNo)
        //        == System.Windows.Forms.DialogResult.Yes)
        //    {
        //        try
        //        {
        //            Chitietnhap ctPN = db.Chitietnhaps.SingleOrDefault(x => x.maCTN == MaCTPN);

        //            pn.tongTien -= ctPN.soLuong * ctPN.donGia;

        //            HangHoa hh = db.HangHoas.SingleOrDefault(x => x.maHH == ctPN.maHH);
        //            hh.soluong += ctPN.soLuong;

        //            db.Chitietnhaps.Remove(ctPN);
        //            db.SaveChanges();
        //            FormChiTietPhieuNhap_Load(sender, e);
        //            MessageBox.Show("Xóa thành công!");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //}
        //private void listViewCtpn_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if(listViewCtpn.SelectedItems.Count>0)
        //    {
        //        ListViewItem selectedItem = listViewCtpn.SelectedItems[0];
        //        MaCTPN = selectedItem.SubItems[0].Text;
        //        txtMaCTPN.Text = MaPN;
        //        cbSanPham.Text = selectedItem.SubItems[1].Text;
        //        txtSoLuong.Text = selectedItem.SubItems[2].Text;
        //        txtDonGia.Text= selectedItem.SubItems[3].Text;
        //    }    
        //}
    }
}
