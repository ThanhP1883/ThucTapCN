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
    public partial class Form2 : Form
    {
        SqlCommand cmd;
        SqlConnection conn;
        string str = @"Data Source=PHAMPHUBANG;Initial Catalog=qlThuVien2;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        void loaddata()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from qlSach";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataGV2.DataSource = dt;
        }
            public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loaddata();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cmd= conn.CreateCommand();              
            cmd.CommandText = "insert into qlSach(MaSach,TenSach,TheLoai,[Nhà xuất bản],[Năm xuất bản],SoLuong) values ('" + txtMaSach.Text + "',N'" + txtTenSach.Text + "',N'" + txtTheLoai.Text + "',N'" + txtNhaXuatBan.Text + "','" + txtNgayXuatBan.Text + "'," + txtSoLuong.Text + " )";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE qlSach SET TenSach = N'" + txtTenSach.Text + "',Theloai=N'" + txtTheLoai.Text+"',[Nhà xuất bản]=N'"+txtNhaXuatBan.Text+"',[Năm xuất bản]='"+txtNgayXuatBan.Text+"',SoLuong='"+txtSoLuong.Text+"' WHERE MaSach = '" + txtMaSach.Text + "'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "delete from qlSach where MaSach = '" +txtMaSach.Text+"'";
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGV2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSach.ReadOnly = true;
            int i;
            i = dataGV2.CurrentRow.Index;

            txtMaSach.Text= dataGV2.Rows[i].Cells[0].Value.ToString();
            txtTenSach.Text = dataGV2.Rows[i].Cells[1].Value.ToString();
            txtTheLoai.Text = dataGV2.Rows[i].Cells[2].Value.ToString();
            txtNhaXuatBan.Text = dataGV2.Rows[i].Cells[3].Value.ToString();
            txtNgayXuatBan.Text = dataGV2.Rows[i].Cells[4].Value.ToString();
            txtSoLuong.Text = dataGV2.Rows[i].Cells[5].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtTheLoai.Text = "";
            txtNhaXuatBan.Text = "";
            txtNgayXuatBan.Text = "";
            txtSoLuong.Text = "";
        }
    }
}
