using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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

namespace QuanLyTour
{
    public partial class BookingForm : DevExpress.XtraEditors.XtraForm
    {
        private string connectionString = KetNoi.str;
        private int selectedBookingId = -1;

        public BookingForm()
        {
            InitializeComponent();
            LoadCustomers();
            LoadTours();
            LoadBookings();
        }

        private void LoadCustomers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand("SELECT CustomerID, FullName FROM Customer", conn);
                var adapter = new SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                cboCustomer.DataSource = table;
                cboCustomer.DisplayMember = "FullName";
                cboCustomer.ValueMember = "CustomerID";
            }
        }

        private void LoadTours()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                var cmd = new SqlCommand("SELECT TourID, TourName FROM Tour", conn);
                var adapter = new SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                cboTour.DataSource = table;
                cboTour.DisplayMember = "TourName";
                cboTour.ValueMember = "TourID";
            }
        }

        private void LoadBookings()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Lấy luôn CustomerID và TourID để bind SelectedValue
                string query = @"
SELECT 
    b.BookingID, 
    b.CustomerID, 
    c.FullName AS Customer, 
    b.TourID, 
    t.TourName   AS Tour,
    b.BookingDate, 
    b.DepositAmount, 
    b.TotalAmount, 
    b.Status
FROM Booking b
JOIN Customer c ON b.CustomerID = c.CustomerID
JOIN Tour      t ON b.TourID      = t.TourID
";
                var adapter = new SqlDataAdapter(query, conn);
                var table = new DataTable();
                adapter.Fill(table);
                dgvBookings.DataSource = table;
            }
            ClearFields();
        }
        private void ClearFields()
        {
            cboCustomer.SelectedIndex = -1;
            cboTour.SelectedIndex = -1;
            dtpBookingDate.Value = DateTime.Now;
            txtDeposit.Text = "0";
            txtTotal.Text = string.Empty;
            txtStatus.Text = string.Empty;
            selectedBookingId = -1;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboCustomer.SelectedIndex < 0 || cboTour.SelectedIndex < 0) return;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Booking (CustomerID, TourID, BookingDate, DepositAmount, TotalAmount, Status)
                                 VALUES (@CustomerID,@TourID,@BookingDate,@DepositAmount,@TotalAmount,@Status)";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", cboCustomer.SelectedValue);
                cmd.Parameters.AddWithValue("@TourID", cboTour.SelectedValue);
                cmd.Parameters.AddWithValue("@BookingDate", dtpBookingDate.Value);
                cmd.Parameters.AddWithValue("@DepositAmount", decimal.Parse(txtDeposit.Text));
                cmd.Parameters.AddWithValue("@TotalAmount", decimal.Parse(txtTotal.Text));
                cmd.Parameters.AddWithValue("@Status", txtStatus.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadBookings();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedBookingId <= 0) return;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Booking SET CustomerID=@CustomerID, TourID=@TourID, BookingDate=@BookingDate,
                                 DepositAmount=@DepositAmount, TotalAmount=@TotalAmount, Status=@Status
                                 WHERE BookingID=@BookingID";
                var cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", cboCustomer.SelectedValue);
                cmd.Parameters.AddWithValue("@TourID", cboTour.SelectedValue);
                cmd.Parameters.AddWithValue("@BookingDate", dtpBookingDate.Value);
                cmd.Parameters.AddWithValue("@DepositAmount", decimal.Parse(txtDeposit.Text));
                cmd.Parameters.AddWithValue("@TotalAmount", decimal.Parse(txtTotal.Text));
                cmd.Parameters.AddWithValue("@Status", txtStatus.Text);
                cmd.Parameters.AddWithValue("@BookingID", selectedBookingId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadBookings();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedBookingId <= 0) return;
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa đặt tour này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    var cmd = new SqlCommand("DELETE FROM Booking WHERE BookingID=@BookingID", conn);
                    cmd.Parameters.AddWithValue("@BookingID", selectedBookingId);
                    conn.Open(); cmd.ExecuteNonQuery();
                }
                LoadBookings();
            }
        }

        private void dgvBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvBookings.Rows[e.RowIndex];

            // 1. Lấy đúng BookingID
            selectedBookingId = Convert.ToInt32(row.Cells["BookingID"].Value);

            // 2. Gán đúng CustomerID và TourID vào SelectedValue
            cboCustomer.SelectedValue = Convert.ToInt32(row.Cells["CustomerID"].Value);
            cboTour.SelectedValue = Convert.ToInt32(row.Cells["TourID"].Value);

            // 3. Các control khác giữ nguyên
            dtpBookingDate.Value = Convert.ToDateTime(row.Cells["BookingDate"].Value);
            txtDeposit.Text = row.Cells["DepositAmount"].Value.ToString();
            txtTotal.Text = row.Cells["TotalAmount"].Value.ToString();
            txtStatus.Text = row.Cells["Status"].Value.ToString();

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 0. Kiểm tra có chọn dòng nào không
            if (selectedBookingId <= 0)
            {
                MessageBox.Show("Vui lòng chọn một đặt tour trước khi in.", "Thông báo");
                return;
            }

            // 1. Tạo DataTable chứa chi tiết booking theo ID
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT 
            b.BookingID, 
            c.FullName AS FullName, 
            c.Phone,
            c.Email,
            t.TourName AS TourName,
            t.StartDate,        
            t.EndDate,
            b.TotalAmount
        FROM Booking b
        JOIN Customer c ON b.CustomerID = c.CustomerID
        JOIN Tour t ON b.TourID = t.TourID
        WHERE b.BookingID = @BookingID"; 

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookingID", selectedBookingId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy dữ liệu đặt tour.", "Lỗi");
                return;
            }

            // 2. Gán vào report
            rptPhieuTour report = new rptPhieuTour();
            report.DataSource = dt;

            // 3. Gán biểu thức nếu cần (ví dụ gộp ngày đi - ngày về)
            // => nếu trong report đã dùng expression: FormatString('{0:dd/MM/yyyy} đến {1:dd/MM/yyyy}', [StartDate], [EndDate]) thì không cần đoạn dưới

            // 4. Hiển thị preview
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }


    }
}