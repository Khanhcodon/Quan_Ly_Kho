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
    public partial class FormThongKeHH : Form
    {
        Quan_Ly_KhoEntities db = new Quan_Ly_KhoEntities();
        public FormThongKeHH()
        {
            InitializeComponent();
        }

        private void FormThongKeHH_Load(object sender, EventArgs e)
        {
            List<ThongKe> tkhh = db.ThongKes.ToList();
            listViewTK.Items.Clear();
            foreach (ThongKe hh in tkhh)
            {
                ListViewItem newItem = new ListViewItem(hh.tenHH);
                newItem.SubItems.Add(hh.maHH);
                newItem.SubItems.Add(hh.sln.ToString());
                newItem.SubItems.Add(hh.slx.ToString());
                newItem.SubItems.Add(hh.conlai.ToString());
                listViewTK.Items.Add(newItem);
            }
        }

        private void listViewTK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        
    }
}
