using DevExpress.XtraBars.Navigation;
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
    public partial class frmLichTrinh : DevExpress.XtraEditors.XtraForm
    {
        private string connStr = KetNoi.str;
        public frmLichTrinh()
        {
            InitializeComponent();
            LoadTours();
        }

        private void LoadTours()
        {
            using (var conn = new SqlConnection(connStr))
            {
                string sql = "SELECT TourID, TourName FROM Tour";
                var da = new SqlDataAdapter(sql, conn);
                var dt = new DataTable();
                da.Fill(dt);

                // bind cho LookUpEdit
                leTour.Properties.DataSource = dt;
                leTour.Properties.DisplayMember = "TourName";
                leTour.Properties.ValueMember = "TourID";
            }
        }

        private void leTour_EditValueChanged(object sender, EventArgs e)
        {
            if (leTour.EditValue == null) return;
            int tourID = Convert.ToInt32(leTour.EditValue);
            LoadItinerary(tourID);
        }

        private void LoadItinerary(int tourID)
        {
            acItinerary.Elements.Clear();

            using (var conn = new SqlConnection(connStr))
            {
                string sql = @"
SELECT DayNumber, Title, Details
FROM Itinerary
WHERE TourID = @TourID
ORDER BY DayNumber";
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TourID", tourID);

                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    int day = Convert.ToInt32(row["DayNumber"]);
                    string title = row["Title"].ToString();
                    string details = row["Details"].ToString();

                    // Mỗi ngày là một AccordionControlElement 
                    var elem = new AccordionControlElement()
                    {
                        Style = ElementStyle.Item,
                        Text = $"Ngày {day}: {title}",
                        Tag = details
                    };
                    elem.Click += Element_Click;
                    acItinerary.Elements.Add(elem);
                }
            }

            if (acItinerary.Elements.Count == 0)
            {
                acItinerary.Elements.Add(new AccordionControlElement()
                {
                    Style = ElementStyle.Item,
                    Text = "Chưa có lịch trình cho tour này."
                });
            }
        }

        // Khi click vào từng bước, hiển thị chi tiết bằng MessageBox hoặc Panel khác tuỳ ý
        private void Element_Click(object sender, EventArgs e)
        {
            var elem = sender as AccordionControlElement;
            if (elem?.Tag is string details)
                XtraMessageBox.Show(details, elem.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
