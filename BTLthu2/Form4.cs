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
    public partial class Form4 : Form
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
            dataGVThongTin.DataSource = dt;
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = txtTenSach.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    string query = @"SELECT * FROM qlSach WHERE MaSach LIKE @SearchText OR TenSach LIKE @SearchText OR TheLoai LIKE @SearchText OR [Nhà Xuất Bản] LIKE @SearchText OR [Ngày Xuất Bản] LIKE @SearchText OR SoLuong LIKE @SearchText";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGVThongTin.DataSource = dataTable;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập văn bản.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string searchText = txtTenSach.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    string query = @"SELECT * FROM qlSach WHERE MaSach LIKE @SearchText ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGVThongTin.DataSource = dataTable;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập văn bản.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string searchText = txtTenSach.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    string query = @"SELECT * FROM qlSach WHERE TenSach LIKE @SearchText ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGVThongTin.DataSource = dataTable;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập văn bản.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string searchText = txtTenSach.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    string query = @"SELECT * FROM qlSach WHERE [Nhà Xuất Bản] LIKE @SearchText ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGVThongTin.DataSource = dataTable;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập văn bản.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string searchText = txtTenSach.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    string query = @"SELECT * FROM qlSach WHERE [Tác Giả] LIKE @SearchText ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGVThongTin.DataSource = dataTable;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn cần nhập văn bản.");
            }
        }
    }
}
