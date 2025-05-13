using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyTour
{
    public partial class FormLogin : Form
    {
        private string connectionString = KetNoi.str;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblStatus.Text = "Vui lòng nhập tên đăng nhập và mật khẩu.";
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Truy vấn kiểm tra tài khoản và mật khẩu
                string query = @"
                    SELECT u.UserID, u.UserName, u.PasswordHash, u.FullName, u.RoleID, r.RoleName 
                    FROM UserAccount u
                    INNER JOIN Role r ON u.RoleID = r.RoleID
                    WHERE u.UserName = @UserName AND u.PasswordHash = @Password";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@Password", password); 

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    // Đăng nhập thành công, lấy RoleName và mở FormMain
                    string roleName = dt.Rows[0]["RoleName"].ToString();
                    RibbonForm1 formMain = new RibbonForm1(roleName); 
                    formMain.Show();
                    this.Hide(); 
                }
                else
                {
                    lblStatus.Text = "Tên đăng nhập hoặc mật khẩu không chính xác.";
                }
            }
        }
    }
}
