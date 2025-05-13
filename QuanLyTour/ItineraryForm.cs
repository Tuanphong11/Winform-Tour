using DevExpress.XtraEditors;
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
    public partial class ItineraryForm : DevExpress.XtraEditors.XtraForm
    {
        private string connectionString = KetNoi.str;
        private int selectedItineraryId = -1;

        public ItineraryForm()
        {
            InitializeComponent();
            LoadTours();
            LoadItineraries();
        }

        private void LoadTours()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TourID, TourName FROM Tour";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                cboTour.DataSource = table;
                cboTour.DisplayMember = "TourName";
                cboTour.ValueMember = "TourID";
            }
        }

        private void LoadItineraries()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT i.ItineraryID, i.TourID, t.TourName, i.DayNumber, i.Title, i.Details
                                 FROM Itinerary i
                                 JOIN Tour t ON i.TourID = t.TourID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvItineraries.DataSource = table;
            }
            ClearFields();
        }

        private void ClearFields()
        {
            cboTour.SelectedIndex = -1;
            numDayNumber.Value = 1;
            txtTitle.Clear();
            txtDetails.Clear();
            selectedItineraryId = -1;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboTour.SelectedIndex < 0) return;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Itinerary (TourID, DayNumber, Title, Details)
                                 VALUES (@TourID, @DayNumber, @Title, @Details)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TourID", cboTour.SelectedValue);
                cmd.Parameters.AddWithValue("@DayNumber", (int)numDayNumber.Value);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@Details", txtDetails.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadItineraries();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedItineraryId <= 0 || cboTour.SelectedIndex < 0) return;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Itinerary
                                 SET TourID=@TourID, DayNumber=@DayNumber, Title=@Title, Details=@Details
                                 WHERE ItineraryID=@ItineraryID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TourID", cboTour.SelectedValue);
                cmd.Parameters.AddWithValue("@DayNumber", (int)numDayNumber.Value);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@Details", txtDetails.Text);
                cmd.Parameters.AddWithValue("@ItineraryID", selectedItineraryId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadItineraries();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedItineraryId <= 0) return;
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa lịch trình này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Itinerary WHERE ItineraryID=@ItineraryID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ItineraryID", selectedItineraryId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadItineraries();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvItineraries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvItineraries.Rows[e.RowIndex];
                selectedItineraryId = Convert.ToInt32(row.Cells["ItineraryID"].Value);
                cboTour.SelectedValue = Convert.ToInt32(row.Cells["TourID"].Value);
                numDayNumber.Value = Convert.ToInt32(row.Cells["DayNumber"].Value);
                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtDetails.Text = row.Cells["Details"].Value.ToString();

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
    }
}
