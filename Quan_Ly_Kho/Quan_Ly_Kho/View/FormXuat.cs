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
    public partial class FormXuat : Form
    {
        Quan_Ly_KhoEntities db = new Quan_Ly_KhoEntities();
        public static string MaPX { get; set; }
        public FormXuat()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormXuat_Load(object sender, EventArgs e)
        {
            List<PhieuXuat> dspx = db.PhieuXuats.ToList();
            listViewPhieuXuat.Items.Clear();
            foreach(PhieuXuat px in dspx)
            {
                ListViewItem item = new ListViewItem(px.maPX);
                item.SubItems.Add(px.ngayXuat.ToString());
                item.SubItems.Add(px.tongTien.ToString());
                listViewPhieuXuat.Items.Add(item);
            }
        }

        private void listViewPhieuXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPhieuXuat.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewPhieuXuat.SelectedItems[0];
                MaPX = selectedItem.SubItems[0].Text;
                textBoxMaPX.Text = MaPX;
                dateTimeNX.Value = DateTime.Parse(selectedItem.SubItems[1].Text);
                textBoxTT.Text = selectedItem.SubItems[2].Text;
            }

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuXuat px = new PhieuXuat()
                {
                    maPX = textBoxMaPX.Text,
                    ngayXuat = dateTimeNX.Value,
                    tongTien = decimal.Parse(textBoxTT.Text)
                };
                db.PhieuXuats.Add(px);
                db.SaveChanges();
                MessageBox.Show("Them thanh cong!!!");
                FormXuat_Load(sender, e);
                FormCTXuat.MaPX = textBoxMaPX.Text;
                if (MessageBox.Show("Vui long them chi tiet phieu xuat!!", "Thông báo", MessageBoxButtons.YesNo)
                           == System.Windows.Forms.DialogResult.Yes)
                {
                    FormCTXuat ctpn = new FormCTXuat();
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

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuXuat selectedItem = db.PhieuXuats.SingleOrDefault(x => x.maPX == MaPX);
                selectedItem.ngayXuat = dateTimeNX.Value;
                db.SaveChanges();
                FormXuat_Load(sender, e);
                MessageBox.Show("Sua thanh cong!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa phiếu nhập vừa chọn không?", "Thông báo", MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    PhieuXuat selectedItem = db.PhieuXuats.SingleOrDefault(x => x.maPX == MaPX);
                    List<Chitietxuat> dsX = db.Chitietxuats.Where(x => x.maPX == MaPX).ToList();
                    foreach (Chitietxuat ct in dsX)
                    {
                        db.Chitietxuats.Remove(ct);
                    }
                    db.SaveChanges();

                    db.PhieuXuats.Remove(selectedItem);
                    db.SaveChanges();
                    FormXuat_Load(sender, e);

                    MessageBox.Show("Xóa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonCT_Click(object sender, EventArgs e)
        {
            if (MaPX == "")
            {
                MessageBox.Show("Chon phieu xuat truoc!", "Thông báo");
            }
            else
            {
                FormCTXuat ctx = new FormCTXuat();
                FormCTXuat.MaPX = MaPX;
                this.Hide();
                ctx.ShowDialog();
                this.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCTXuat hh = new FormCTXuat();
            this.Hide();
            hh.ShowDialog();
            this.Show();
        }
    }
}

