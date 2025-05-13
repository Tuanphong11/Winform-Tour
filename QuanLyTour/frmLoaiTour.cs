using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyTour
{
    public partial class frmLoaiTour : Form
    {
        private string connectionString = KetNoi.str;

        public frmLoaiTour()
        {
            InitializeComponent();
        }

        private void frmLoaiTour_Load(object sender, EventArgs e)
        {
            LoadTourTypes();
        }

        private void LoadTourTypes()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TourTypeID, TypeName FROM dbo.TourType";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvLoaiTour.DataSource = table;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("INSERT INTO dbo.TourType(TypeName) VALUES(@TypeName)", conn))
            {
                cmd.Parameters.AddWithValue("@TypeName", txtTypeName.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadTourTypes();
            ClearInputs();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvLoaiTour.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvLoaiTour.CurrentRow.Cells["TourTypeID"].Value);
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("UPDATE dbo.TourType SET TypeName = @TypeName WHERE TourTypeID = @ID", conn))
            {
                cmd.Parameters.AddWithValue("@TypeName", txtTypeName.Text);
                cmd.Parameters.AddWithValue("@ID", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadTourTypes();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLoaiTour.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvLoaiTour.CurrentRow.Cells["TourTypeID"].Value);
            var result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("DELETE FROM dbo.TourType WHERE TourTypeID = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadTourTypes();
                ClearInputs();
            }
        }

        private void dgvLoaiTour_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoaiTour.CurrentRow != null)
                txtTypeName.Text = dgvLoaiTour.CurrentRow.Cells["TypeName"].Value.ToString();
        }

        private void ClearInputs()
        {
            txtTypeName.Clear();
        }
    }
}