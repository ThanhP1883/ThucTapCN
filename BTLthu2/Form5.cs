        using System;
        using System.Collections;
        using System.Collections.Generic;
        using System.ComponentModel;
        using System.Data;
        using System.Data.SqlClient;
        using System.Drawing;
        using System.Linq;
        using System.Text;
        using System.Text.RegularExpressions;
        using System.Threading.Tasks;
        using System.Windows.Forms;
        using static System.Windows.Forms.VisualStyles.VisualStyleElement;

        namespace BTLthu2
        {
            public partial class Form5 : Form
            {
                public class DocGiaInfo
                {
                    public string MaDocGia { get; set; }
                    public string TenDocGia { get; set; }

                    public override string ToString()
                    {
                        // Khi được hiển thị trong ComboBox, kết hợp cả mã và tên độc giả
                        return $"{MaDocGia}";
                    }
                }
                public class SachInfo
                {
                    public string MaSach { get; set; }
                    public string TenSach { get; set; }

                    public override string ToString()
                    {
                        // Khi được hiển thị trong ComboBox, kết hợp cả mã và tên sách
                        return $"{MaSach}";
                    }
                }
                SqlCommand cmd;
                SqlConnection conn;
                string str = @"Data Source=PHAMPHUBANG;Initial Catalog=qlThuVien2;Integrated Security=True";
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                void loaddata()
                {
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT\r\n    mt.MaMuon,\r\n    dg.MaDocGia,\r\n    dg.TenDocGia,\r\n    s.MaSach,\r\n    s.TenSach,\r\n    mt.NgayMuon,\r\n    mt.NgayTra\r\nFROM\r\n    qlMuonTra mt\r\nJOIN\r\n    qlDocGia dg ON mt.MaDocGia = dg.MaDocGia\r\nJOIN\r\n    qlSach s ON mt.MaSach = s.MaSach;";
                    adapter.SelectCommand = cmd;
                    dt.Clear();
                    adapter.Fill(dt);
                    dataGVqlMuonTra.DataSource = dt;
                }
                private void LoadDataIntoComboBox()
                {
                    string connectionString = "Data Source=PHAMPHUBANG;Initial Catalog=qlThuVien2;Integrated Security=True";
                    string query = "SELECT MaDocGia, TenDocGia FROM qlDocGia";

                    List<DocGiaInfo> dataList = new List<DocGiaInfo>();

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            DocGiaInfo docGia = new DocGiaInfo
                            {
                                MaDocGia = reader["MaDocGia"].ToString(),
                                TenDocGia = reader["TenDocGia"].ToString()
                            };

                            dataList.Add(docGia);
                        }

                        reader.Close();
                    }


                    // Gán danh sách đối tượng làm nguồn dữ liệu cho ComboBox
                    comboBoxDocGia.DataSource = dataList;
                    string maDocGia = comboBoxDocGia.SelectedValue.ToString();
                }
                private void LoadDataIntoComboBox1()
                {
                    string connectionString = "Data Source=PHAMPHUBANG;Initial Catalog=qlThuVien2;Integrated Security=True";
                    string query = "SELECT MaSach, TenSach FROM qlSach"; // Thay đổi truy vấn của bạn tại đây

                    List<SachInfo> dataList = new List<SachInfo>();

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            SachInfo sach = new SachInfo
                            {
                                MaSach = reader["MaSach"].ToString(),
                                TenSach = reader["TenSach"].ToString()
                            };

                            dataList.Add(sach);
                        }

                        reader.Close();
                    }

                    // Gán danh sách đối tượng làm nguồn dữ liệu cho ComboBox của sách
                    comboBoxSach.DataSource = dataList;
            
                }
                public Form5()
                {
                    InitializeComponent();
                    LoadDataIntoComboBox();
                    LoadDataIntoComboBox1();
                }

                private void button6_Click(object sender, EventArgs e)
                {
                    this.Hide();
                    Form1 frm1 = new Form1();
                    frm1.ShowDialog();
                    this.Close();
                }

                private void Form5_Load(object sender, EventArgs e)
                {
                    conn = new SqlConnection(str);
                    conn.Open();
                    loaddata();
                }

                private void button2_Click(object sender, EventArgs e)
                {
                    string bookId = comboBoxSach.SelectedValue.ToString();

                    // Kiểm tra nếu có dữ liệu nhập vào
                    if (string.IsNullOrEmpty(bookId))
                    {
                        MessageBox.Show("Vui lòng nhập mã sách");
                        return;
                    }

                    try
                    {
                        cmd = conn.CreateCommand();
                        cmd.CommandText = "UPDATE qlSach SET SoLuong = SoLuong - 1 WHERE MaSach = '" + comboBoxDocGia.DisplayMember.ToString() + "'";
                        cmd.ExecuteNonQuery();
                        loaddata();
                        MessageBox.Show("Mượn thành công");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                }

                private void dataGVqlMuonTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
                {
         
                    txtMaMuon.ReadOnly = true;
                    int i;
                    i = dataGVqlMuonTra.CurrentRow.Index;
                    txtMaMuon.Text = dataGVqlMuonTra.Rows[i].Cells[0].Value.ToString();
                    comboBoxDocGia.Text = dataGVqlMuonTra.Rows[i].Cells[1].Value.ToString();
                    comboBoxSach.Text = dataGVqlMuonTra.Rows[i].Cells[3].Value.ToString();
                    txtNgayMuon.Text = dataGVqlMuonTra.Rows[i].Cells[5].Value.ToString();
                    txtNgayTra.Text = dataGVqlMuonTra.Rows[i].Cells[6].Value.ToString();
                }

                private void button3_Click(object sender, EventArgs e)
                {
                    string bookId = comboBoxSach.SelectedValue.ToString();

                    // Kiểm tra nếu có dữ liệu nhập vào
                    if (string.IsNullOrEmpty(bookId))
                    {
                        MessageBox.Show("Vui lòng nhập mã sách");
                        return;
                    }

                    try
                    {
                        cmd = conn.CreateCommand();
                        cmd.CommandText = "UPDATE qlSach SET SoLuong = SoLuong + 1 WHERE MaSach = '" + comboBoxSach.SelectedValue.ToString() + "'";
                        cmd.ExecuteNonQuery();
                        loaddata();
                        MessageBox.Show("Trả thành công");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                }

                private void button5_Click(object sender, EventArgs e)
                {
                    try
                    {
                        cmd = conn.CreateCommand();
                        cmd.CommandText = "insert into qlMuonTra(MaMuon,MaSach,MaDocGia,NgayMuon,NgayTra) values ('" + txtMaMuon.Text + "','" + comboBoxSach.SelectedValue.ToString() + "','" + comboBoxDocGia.SelectedValue.ToString() + "','" + txtNgayMuon.Text + "','" + txtNgayTra.Text + "')";
                        cmd.ExecuteNonQuery();
                        loaddata();
                        MessageBox.Show("Thêm thành công");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                }

                private void button1_Click(object sender, EventArgs e)
                {
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "update qlMuonTra set MaDocGia='" + comboBoxDocGia.SelectedValue.ToString() + "',MaSach='" + comboBoxSach.SelectedValue.ToString() + "',NgayMuon='" + txtNgayMuon.Text + "',NgayTra='" + txtNgayTra.Text + "' where MaMuon='" + txtMaMuon.Text + "'";
                    cmd.ExecuteNonQuery();
                    loaddata();
                    MessageBox.Show("Sửa thành công");
                }

                private void button4_Click(object sender, EventArgs e)
                {
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "delete from qlMuonTra where MaMuon = '" + txtMaMuon.Text + "'";
                    cmd.ExecuteNonQuery();
                    loaddata();
                }

                private void button3_Click_1(object sender, EventArgs e)
                {
                    txtMaMuon.ReadOnly = false;
                    txtMaMuon.Text = "";
                    comboBoxDocGia.Text = "";
                    comboBoxSach.Text = "";
                    txtNgayMuon.Text = "";
                    txtNgayTra.Text = "";
                }

                private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
                {

                    string maDocGia = comboBoxDocGia.SelectedValue.ToString();
                    string tenDocGia1 = comboBoxDocGia.Text;
            
                    if (comboBoxDocGia.SelectedItem != null && comboBoxDocGia.SelectedValue != null)
                    {
                        SqlConnection conn = new SqlConnection("Data Source=PHAMPHUBANG;Initial Catalog=qlThuVien2;Integrated Security=True");
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "SELECT TenDocGia FROM qlDocGia WHERE MaDocGia = @MaDocGia";
                        cmd.Parameters.AddWithValue("@MaDocGia", comboBoxDocGia.SelectedValue.ToString());
                        conn.Open();
                        string tenDocGia = (string)cmd.ExecuteScalar();
                        conn.Close();

                        if (tbDocGia != null)
                        {
                            tbDocGia.Text = tenDocGia;
                        }
                        else
                        {
                            MessageBox.Show("TextBox tbDocGia is not initialized.");
                        }
                    }
                }
                private void comboBoxSach_SelectedIndexChanged(object sender, EventArgs e)
                {
                    string maSach = comboBoxSach.SelectedValue.ToString();
            
                    string tenSach1 = comboBoxSach.Text;
            
                    if (comboBoxSach.SelectedItem != null && comboBoxSach.SelectedValue != null)
                    {
                        SqlConnection conn = new SqlConnection("Data Source=PHAMPHUBANG;Initial Catalog=qlThuVien2;Integrated Security=True");
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT TenSach FROM qlSach WHERE MaSach = @MaSach";
                    cmd.Parameters.AddWithValue("@MaSach", comboBoxSach.SelectedValue.ToString());
                    conn.Open();
                    string tenSach = (string)cmd.ExecuteScalar();
                    conn.Close();
                        if (tbDocGia != null)
                        {
                            tbSach.Text = tenSach;
                        }
                        else
                        {
                            MessageBox.Show("TextBox tbDocGia is not initialized.");
                        }
                    }


                }

                private void tbSach_TextChanged(object sender, EventArgs e)
                {
            
                }
            }
        }