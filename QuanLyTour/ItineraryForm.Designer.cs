namespace QuanLyTour
{
    partial class ItineraryForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvItineraries;
        private System.Windows.Forms.ComboBox cboTour;
        private System.Windows.Forms.NumericUpDown numDayNumber;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblTourID;
        private System.Windows.Forms.Label lblDayNumber;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvItineraries = new System.Windows.Forms.DataGridView();
            this.cboTour = new System.Windows.Forms.ComboBox();
            this.numDayNumber = new System.Windows.Forms.NumericUpDown();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblTourID = new System.Windows.Forms.Label();
            this.lblDayNumber = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItineraries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDayNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItineraries
            // 
            this.dgvItineraries.AllowUserToAddRows = false;
            this.dgvItineraries.AllowUserToDeleteRows = false;
            this.dgvItineraries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItineraries.Location = new System.Drawing.Point(12, 12);
            this.dgvItineraries.Name = "dgvItineraries";
            this.dgvItineraries.ReadOnly = true;
            this.dgvItineraries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItineraries.Size = new System.Drawing.Size(954, 317);
            this.dgvItineraries.TabIndex = 0;
            this.dgvItineraries.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItineraries_CellClick);
            // 
            // cboTour
            // 
            this.cboTour.Location = new System.Drawing.Point(196, 342);
            this.cboTour.Name = "cboTour";
            this.cboTour.Size = new System.Drawing.Size(100, 21);
            this.cboTour.TabIndex = 2;
            // 
            // numDayNumber
            // 
            this.numDayNumber.Location = new System.Drawing.Point(196, 372);
            this.numDayNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDayNumber.Name = "numDayNumber";
            this.numDayNumber.Size = new System.Drawing.Size(60, 21);
            this.numDayNumber.TabIndex = 4;
            this.numDayNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(402, 335);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(400, 21);
            this.txtTitle.TabIndex = 6;
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(402, 377);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(400, 80);
            this.txtDetails.TabIndex = 8;
            // 
            // lblTourID
            // 
            this.lblTourID.AutoSize = true;
            this.lblTourID.Location = new System.Drawing.Point(108, 345);
            this.lblTourID.Name = "lblTourID";
            this.lblTourID.Size = new System.Drawing.Size(43, 13);
            this.lblTourID.TabIndex = 1;
            this.lblTourID.Text = "Tour ID";
            // 
            // lblDayNumber
            // 
            this.lblDayNumber.AutoSize = true;
            this.lblDayNumber.Location = new System.Drawing.Point(108, 375);
            this.lblDayNumber.Name = "lblDayNumber";
            this.lblDayNumber.Size = new System.Drawing.Size(52, 13);
            this.lblDayNumber.TabIndex = 3;
            this.lblDayNumber.Text = "Ngày thứ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(314, 338);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 13);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Tiêu đề";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(314, 380);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(41, 13);
            this.lblDetails.TabIndex = 7;
            this.lblDetails.Text = "Chi tiết";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(842, 344);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(842, 374);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(842, 404);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(842, 434);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ItineraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 469);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblDayNumber);
            this.Controls.Add(this.numDayNumber);
            this.Controls.Add(this.lblTourID);
            this.Controls.Add(this.cboTour);
            this.Controls.Add(this.dgvItineraries);
            this.Name = "ItineraryForm";
            this.Text = "Quản lý Lịch trình";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItineraries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDayNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}