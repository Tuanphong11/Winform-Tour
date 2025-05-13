using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyTour
{
    public partial class frmPhuongTien : Form
    {
        private string connectionString = KetNoi.str;

        public frmPhuongTien()
        {
            InitializeComponent();
        }

        private void frmPhuongTien_Load(object sender, EventArgs e)
        {
            LoadTransportationMethods();
        }

        private void LoadTransportationMethods()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TransportID, MethodName FROM dbo.TransportationMethod";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvPhuongTien.DataSource = table;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("INSERT INTO dbo.TransportationMethod(MethodName) VALUES(@MethodName)", conn))
            {
                cmd.Parameters.AddWithValue("@MethodName", txtMethodName.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadTransportationMethods();
            ClearInputs();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPhuongTien.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvPhuongTien.CurrentRow.Cells["TransportID"].Value);
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("UPDATE dbo.TransportationMethod SET MethodName = @MethodName WHERE TransportID = @ID", conn))
            {
                cmd.Parameters.AddWithValue("@MethodName", txtMethodName.Text);
                cmd.Parameters.AddWithValue("@ID", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            LoadTransportationMethods();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPhuongTien.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvPhuongTien.CurrentRow.Cells["TransportID"].Value);
            var result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("DELETE FROM dbo.TransportationMethod WHERE TransportID = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadTransportationMethods();
                ClearInputs();
            }
        }

        private void dgvPhuongTien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhuongTien.CurrentRow != null)
                txtMethodName.Text = dgvPhuongTien.CurrentRow.Cells["MethodName"].Value.ToString();
        }

        private void ClearInputs()
        {
            txtMethodName.Clear();
        }
    }
}