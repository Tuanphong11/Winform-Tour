namespace QuanLyTour
{
    partial class rptPhieuTour
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Designer generated code

        /// <summary> 
        /// Required method for Designer support – do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptPhieuTour));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lblTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.cutLine = new DevExpress.XtraReports.UI.XRLine();
            this.lblBookingIDLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.lblBookingID = new DevExpress.XtraReports.UI.XRLabel();
            this.lblFullNameLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.lblFullName = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPhoneLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.lblPhone = new DevExpress.XtraReports.UI.XRLabel();
            this.lblEmailLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.lblEmail = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTourNameLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTourName = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTimeLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTime = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTotalLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTotal = new DevExpress.XtraReports.UI.XRLabel();
            this.lblThanks = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 50F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 50F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblTitle,
            this.cutLine,
            this.lblBookingIDLabel,
            this.lblBookingID,
            this.lblFullNameLabel,
            this.lblFullName,
            this.lblPhoneLabel,
            this.lblPhone,
            this.lblEmailLabel,
            this.lblEmail,
            this.lblTourNameLabel,
            this.lblTourName,
            this.lblTimeLabel,
            this.lblTime,
            this.lblTotalLabel,
            this.lblTotal,
            this.lblThanks});
            this.Detail.HeightF = 320F;
            this.Detail.Name = "Detail";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new DevExpress.Drawing.DXFont("Arial", 16F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblTitle.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10F);
            this.lblTitle.Multiline = true;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.lblTitle.SizeF = new System.Drawing.SizeF(650F, 30F);
            this.lblTitle.Text = "VÉ THAM GIA TOUR DU LỊCH";
            this.lblTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // cutLine
            // 
            this.cutLine.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.cutLine.LocationFloat = new DevExpress.Utils.PointFloat(0F, 45F);
            this.cutLine.Name = "cutLine";
            this.cutLine.SizeF = new System.Drawing.SizeF(650F, 2F);
            // 
            // lblBookingIDLabel
            // 
            this.lblBookingIDLabel.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblBookingIDLabel.LocationFloat = new DevExpress.Utils.PointFloat(10F, 60F);
            this.lblBookingIDLabel.Multiline = true;
            this.lblBookingIDLabel.Name = "lblBookingIDLabel";
            this.lblBookingIDLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.lblBookingIDLabel.SizeF = new System.Drawing.SizeF(100F, 20F);
            this.lblBookingIDLabel.Text = "Mã đơn:";
            // 
            // lblBookingID
            // 
            this.lblBookingID.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BookingID]")});
            this.lblBookingID.LocationFloat = new DevExpress.Utils.PointFloat(110F, 60F);
            this.lblBookingID.Multiline = true;
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.lblBookingID.SizeF = new System.Drawing.SizeF(200F, 20F);
            // 
            // lblFullNameLabel
            // 
            this.lblFullNameLabel.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblFullNameLabel.LocationFloat = new DevExpress.Utils.PointFloat(10F, 85F);
            this.lblFullNameLabel.Multiline = true;
            this.lblFullNameLabel.Name = "lblFullNameLabel";
            this.lblFullNameLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.lblFullNameLabel.SizeF = new System.Drawing.SizeF(100F, 20F);
            this.lblFullNameLabel.Text = "Họ tên:";
            // 
            // lblFullName
            // 
            this.lblFullName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FullName]")});
            this.lblFullName.LocationFloat = new DevExpress.Utils.PointFloat(110F, 85F);
            this.lblFullName.Multiline = true;
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.lblFullName.SizeF = new System.Drawing.SizeF(300F, 20F);
            // 
            // lblPhoneLabel
            // 
            this.lblPhoneLabel.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblPhoneLabel.LocationFloat = new DevExpress.Utils.PointFloat(10F, 110F);
            this.lblPhoneLabel.Multiline = true;
            this.lblPhoneLabel.Name = "lblPhoneLabel";
            this.lblPhoneLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.lblPhoneLabel.SizeF = new System.Drawing.SizeF(100F, 20F);
            this.lblPhoneLabel.Text = "Điện thoại:";
            // 
            // lblPhone
            // 
            this.lblPhone.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Phone]")});
            this.lblPhone.LocationFloat = new DevExpress.Utils.PointFloat(110F, 110F);
            this.lblPhone.Multiline = true;
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.lblPhone.SizeF = new System.Drawing.SizeF(200F, 20F);
            // 
            // lblEmailLabel
            // 
            this.lblEmailLabel.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblEmailLabel.LocationFloat = new DevExpress.Utils.PointFloat(10F, 135F);
            this.lblEmailLabel.Multiline = true;
            this.lblEmailLabel.Name = "lblEmailLabel";
            this.lblEmailLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.lblEmailLabel.SizeF = new System.Drawing.SizeF(100F, 20F);
            this.lblEmailLabel.Text = "Email:";
            // 
            // lblEmail
            // 
            this.lblEmail.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Email]")});
            this.lblEmail.LocationFloat = new DevExpress.Utils.PointFloat(110F, 135F);
            this.lblEmail.Multiline = true;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.lblEmail.SizeF = new System.Drawing.SizeF(300F, 20F);
            // 
            // lblTourNameLabel
            // 
            this.lblTourNameLabel.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblTourNameLabel.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 163.75F);
            this.lblTourNameLabel.Multiline = true;
            this.lblTourNameLabel.Name = "lblTourNameLabel";
            this.lblTourNameLabel.SizeF = new System.Drawing.SizeF(100F, 20F);
            this.lblTourNameLabel.Text = "Tên tour:";
            // 
            // lblTourName
            // 
            this.lblTourName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TourName]")});
            this.lblTourName.LocationFloat = new DevExpress.Utils.PointFloat(110F, 163.75F);
            this.lblTourName.Multiline = true;
            this.lblTourName.Name = "lblTourName";
            this.lblTourName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.lblTourName.SizeF = new System.Drawing.SizeF(400F, 20F);
            // 
            // lblTimeLabel
            // 
            this.lblTimeLabel.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblTimeLabel.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 188.75F);
            this.lblTimeLabel.Multiline = true;
            this.lblTimeLabel.Name = "lblTimeLabel";
            this.lblTimeLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.lblTimeLabel.SizeF = new System.Drawing.SizeF(100F, 20F);
            this.lblTimeLabel.Text = "Thời gian:";
            // 
            // lblTime
            // 
            this.lblTime.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString(\'{0:dd/MM/yyyy} đến {1:dd/MM/yyyy}\', [StartDate], [EndDate])")});
            this.lblTime.LocationFloat = new DevExpress.Utils.PointFloat(110F, 188.75F);
            this.lblTime.Multiline = true;
            this.lblTime.Name = "lblTime";
            this.lblTime.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.lblTime.SizeF = new System.Drawing.SizeF(300F, 20F);
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblTotalLabel.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 213.75F);
            this.lblTotalLabel.Multiline = true;
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.lblTotalLabel.SizeF = new System.Drawing.SizeF(100F, 20F);
            this.lblTotalLabel.Text = "Tổng tiền:";
            // 
            // lblTotal
            // 
            this.lblTotal.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString(\'{0:N0} VNĐ\', [TotalAmount])")});
            this.lblTotal.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.LocationFloat = new DevExpress.Utils.PointFloat(110F, 213.75F);
            this.lblTotal.Multiline = true;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.lblTotal.SizeF = new System.Drawing.SizeF(200F, 20F);
            // 
            // lblThanks
            // 
            this.lblThanks.Font = new DevExpress.Drawing.DXFont("Arial", 10F, DevExpress.Drawing.DXFontStyle.Italic);
            this.lblThanks.LocationFloat = new DevExpress.Utils.PointFloat(0F, 254.7916F);
            this.lblThanks.Multiline = true;
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.lblThanks.SizeF = new System.Drawing.SizeF(650F, 25F);
            this.lblThanks.Text = "Cảm ơn quý khách đã đồng hành cùng chúng tôi!";
            this.lblThanks.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // rptPhieuTour
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.Detail,
            this.BottomMargin});
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(100F, 100F, 50F, 50F);
            this.Version = "22.2";
            this.Watermark.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("rptPhieuTour.Watermark.ImageSource"));
            this.Watermark.ImageTransparency = 82;
            this.Watermark.ShowBehind = false;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel lblTitle;
        private DevExpress.XtraReports.UI.XRLine cutLine;
        private DevExpress.XtraReports.UI.XRLabel lblBookingIDLabel;
        private DevExpress.XtraReports.UI.XRLabel lblBookingID;
        private DevExpress.XtraReports.UI.XRLabel lblFullNameLabel;
        private DevExpress.XtraReports.UI.XRLabel lblFullName;
        private DevExpress.XtraReports.UI.XRLabel lblPhoneLabel;
        private DevExpress.XtraReports.UI.XRLabel lblPhone;
        private DevExpress.XtraReports.UI.XRLabel lblEmailLabel;
        private DevExpress.XtraReports.UI.XRLabel lblEmail;
        private DevExpress.XtraReports.UI.XRLabel lblTourNameLabel;
        private DevExpress.XtraReports.UI.XRLabel lblTourName;
        private DevExpress.XtraReports.UI.XRLabel lblTimeLabel;
        private DevExpress.XtraReports.UI.XRLabel lblTime;
        private DevExpress.XtraReports.UI.XRLabel lblTotalLabel;
        private DevExpress.XtraReports.UI.XRLabel lblTotal;
        private DevExpress.XtraReports.UI.XRLabel lblThanks;
    }
}
