using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Kho.View
{
    public partial class FormHangHoa : Form
    {
        SqlConnection con = new SqlConnection("server = ADMIN\\SQLEXPRESS;database = Quan_Ly_Kho; integrated security = SSPI");

        public FormHangHoa()
        {
            InitializeComponent();
        }
        private void HienThi(string truyvan)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(truyvan, con); // lay du lieu vao da
            DataTable tb = new DataTable();
            da.Fill(tb); // do du lieu vao table
            dtgr.DataSource = tb; // do table len view
            con.Close();
        }
        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            HienThi("select * from HangHoa");
        }

        private void dtgr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHH.Text = dtgr.CurrentRow.Cells[0].Value.ToString();
            txtTenHH.Text = dtgr.CurrentRow.Cells[1].Value.ToString();
            txtMaNCC.Text = dtgr.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text = dtgr.CurrentRow.Cells[3].Value.ToString();
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string q = string.Format("select * from HangHoa where maHH like '%{0}%'", txt_TimKiem.Text);
            HienThi(q);
        }
    }
}
