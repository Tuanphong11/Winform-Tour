using DevExpress.XtraEditors;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace QuanLyTour
{
    public partial class CustomerForm : DevExpress.XtraEditors.XtraForm
    {
        private string connectionString = KetNoi.str;
        private int selectedCustomerId = -1;

        public CustomerForm()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT CustomerID, FullName, Phone, Email, Address, CreatedAt FROM Customer";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvCustomers.DataSource = table;
            }
            ClearFields();
        }

        private void ClearFields()
        {
            txtFullName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            selectedCustomerId = -1;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Customer (FullName, Phone, Email, Address) VALUES (@FullName, @Phone, @Email, @Address)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadCustomers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId <= 0) return;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Customer SET FullName=@FullName, Phone=@Phone, Email=@Email, Address=@Address WHERE CustomerID=@CustomerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@CustomerID", selectedCustomerId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadCustomers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId <= 0) return;
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Customer WHERE CustomerID=@CustomerID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CustomerID", selectedCustomerId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadCustomers();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];
                selectedCustomerId = Convert.ToInt32(row.Cells["CustomerID"].Value);
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Thiết lập context cho EPPlus 6 (phi thương mại)
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            if (dgvCustomers.Rows.Count == 0)
                return;

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var package = new ExcelPackage())
                    {
                        var ws = package.Workbook.Worksheets.Add("Danh sách khách hàng");

                        // Header
                        for (int i = 0; i < dgvCustomers.Columns.Count; i++)
                        {
                            ws.Cells[1, i + 1].Value = dgvCustomers.Columns[i].HeaderText;
                        }

                        // Dữ liệu
                        for (int r = 0; r < dgvCustomers.Rows.Count; r++)
                        {
                            for (int c = 0; c < dgvCustomers.Columns.Count; c++)
                            {
                                var value = dgvCustomers.Rows[r].Cells[c].Value;
                                ws.Cells[r + 2, c + 1].Value = value != null ? value.ToString() : "";
                            }
                        }

                        // Tự điều chỉnh cột
                        ws.Cells[ws.Dimension.Address].AutoFitColumns();

                        // Lưu file
                        File.WriteAllBytes(sfd.FileName, package.GetAsByteArray());
                    }

                    MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void SearchCustomers(string keyword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT CustomerID, FullName, Phone, Email, Address, CreatedAt " +
                               "FROM Customer " +
                               "WHERE FullName LIKE @Keyword OR Phone LIKE @Keyword";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvCustomers.DataSource = table;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
                SearchCustomers(keyword);
            else
                LoadCustomers(); 
        }

    }
}