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
    public partial class Form3 : Form
    {
        SqlCommand cmd;
        SqlConnection conn;
        string str = @"Data Source=PHAMPHUBANG;Initial Catalog=qlThuVien2;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        void loaddata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from qlDocGia";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataGVqlDocGia.DataSource = dt;
        }
            public Form3()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loaddata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formThem frm1 = new formThem();
            frm1.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE qlDocGia SET TenDocGia='" + txtTenDocGia.Text + "',DiaChi='" + txtDiaChi.Text + "',CCCD='" + txtCCCD.Text + "',NgaySinh='" + txtNgaySinh.Text + "' WHERE MaDocGia = '" + txtMaDocGia.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "delete from qlSach where MaDocGia = '" + txtMaDocGia.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaDocGia.Text = "";
            txtTenDocGia.Text = "";
            txtDiaChi.Text = "";
            txtCCCD.Text = "";
            txtNgaySinh.Text = "";

        }

        private void dataGVqlDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDocGia.ReadOnly = true;
            int i;
            i = dataGVqlDocGia.CurrentRow.Index;
            txtMaDocGia.Text = dataGVqlDocGia.Rows[i].Cells[0].Value.ToString();
            txtTenDocGia.Text = dataGVqlDocGia.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dataGVqlDocGia.Rows[i].Cells[2].Value.ToString();
            txtCCCD.Text = dataGVqlDocGia.Rows[i].Cells[3].Value.ToString();
            txtNgaySinh.Text = dataGVqlDocGia.Rows[i].Cells[4].Value.ToString();
        }
    }
}
