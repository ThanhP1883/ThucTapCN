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
    public partial class DangNhap : Form
    {
        SqlCommand cmd;
        SqlConnection conn;
        string str = @"Data Source=PHAMPHUBANG;Initial Catalog=qlThuVien2;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void ckbHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienThiMK.Checked)
            {
                txtMK.PasswordChar = (char)0;
            }
            else
            {
                txtMK.PasswordChar = '*';
            }
        }

        private void btbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btbDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDN.Text.Trim();
            string password = txtMK.Text;

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

                    // Kiểm tra xem tên đăng nhập và mật khẩu có khớp với dữ liệu trong cơ sở dữ liệu không
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        this.Hide();
                        Form1 frm1 = new Form1();
                        frm1.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKy frmDk = new DangKy();
            frmDk.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBatDau frm1 = new FormBatDau();
            frm1.ShowDialog();
            this.Close();
        }
    }
}
