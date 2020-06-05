using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Ly_Kho.Controller;
using Quan_Ly_Kho.View;

namespace Quan_Ly_Kho.Controller
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPhieuNhap pn = new FormPhieuNhap();
            this.Hide();
            pn.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormThongKeHH tkhh = new FormThongKeHH();
            this.Hide();
            tkhh.ShowDialog();
            this.Show();
        }
    }
}
