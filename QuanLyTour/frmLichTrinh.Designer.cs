namespace QuanLyTour
{
    partial class frmLichTrinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leTour = new DevExpress.XtraEditors.LookUpEdit();
            this.acItinerary = new DevExpress.XtraBars.Navigation.AccordionControl();
            ((System.ComponentModel.ISupportInitialize)(this.leTour.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acItinerary)).BeginInit();
            this.SuspendLayout();
            // 
            // leTour
            // 
            this.leTour.Location = new System.Drawing.Point(12, 12);
            this.leTour.Name = "leTour";
            this.leTour.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leTour.Properties.NullText = "[Chọn tour]";
            this.leTour.Size = new System.Drawing.Size(300, 20);
            this.leTour.TabIndex = 0;
            this.leTour.EditValueChanged += new System.EventHandler(this.leTour_EditValueChanged);
            // 
            // acItinerary
            // 
            this.acItinerary.Location = new System.Drawing.Point(0, 38);
            this.acItinerary.Name = "acItinerary";
            this.acItinerary.Size = new System.Drawing.Size(980, 435);
            this.acItinerary.TabIndex = 1;
            // 
            // frmLichTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 473);
            this.Controls.Add(this.acItinerary);
            this.Controls.Add(this.leTour);
            this.Name = "frmLichTrinh";
            this.Text = "Lịch Trình Tour";
            ((System.ComponentModel.ISupportInitialize)(this.leTour.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acItinerary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit leTour;
        private DevExpress.XtraBars.Navigation.AccordionControl acItinerary;
    }
}