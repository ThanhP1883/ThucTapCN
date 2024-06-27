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
    public partial class DangKy : Form
    {
        SqlCommand cmd;
        SqlConnection conn;
        string str = @"Data Source=DESKTOP-DKC1J2E\\SQLEXPRESS;Initial Catalog=tesst;Integrated Security=True;";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public DangKy()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBatDau frm1 = new FormBatDau();
            frm1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Kiểm tra nếu có dữ liệu nhập vào
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu");
                return;
            }

            try
            {
                // Tạo kết nối
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    // Kiểm tra xem tên đăng nhập đã tồn tại chưa
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại");
                        return;
                    }

                    // Nếu tên đăng nhập chưa tồn tại, thêm tài khoản vào cơ sở dữ liệu
                    query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Đăng ký thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void ckbHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienThiMK.Checked)
            {
                txtPassword.PasswordChar = (char)0;
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
