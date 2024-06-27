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

namespace BTLthu2
{
    public partial class formThem : Form
    {
        SqlCommand cmd;
        SqlConnection conn;
        string str = @"Data Source=PHAMPHUBANG;Initial Catalog=qlThuVien2;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public formThem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into qlDocGia(MaDocGia,TenDocGia,DiaChi,CCCD,NgaySinh)values('" + txtMaDocGia.Text + "', '" + txtTenDocGia.Text + "', '" + txtDiaChi.Text + "', '" + txtCCCD.Text + "', '" + txtNgaySinh.Text + "')";
            cmd.ExecuteNonQuery();
            
        }
    }
}
