namespace QuanLyTour
{
    partial class frmLoaiTour
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvLoaiTour;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;

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
            this.dgvLoaiTour = new System.Windows.Forms.DataGridView();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTour)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoaiTour
            // 
            this.dgvLoaiTour.AllowUserToAddRows = false;
            this.dgvLoaiTour.AllowUserToDeleteRows = false;
            this.dgvLoaiTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiTour.Location = new System.Drawing.Point(12, 12);
            this.dgvLoaiTour.MultiSelect = false;
            this.dgvLoaiTour.Name = "dgvLoaiTour";
            this.dgvLoaiTour.ReadOnly = true;
            this.dgvLoaiTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiTour.Size = new System.Drawing.Size(956, 425);
            this.dgvLoaiTour.TabIndex = 0;
            this.dgvLoaiTour.SelectionChanged += new System.EventHandler(this.dgvLoaiTour_SelectionChanged);
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(117, 455);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(200, 20);
            this.txtTypeName.TabIndex = 2;
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Location = new System.Drawing.Point(53, 458);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(48, 13);
            this.lblTypeName.TabIndex = 1;
            this.lblTypeName.Text = "Tên loại:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(341, 453);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(422, 453);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(503, 453);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmLoaiTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 502);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.lblTypeName);
            this.Controls.Add(this.dgvLoaiTour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoaiTour";
            this.Text = "Quản lý loại tour";
            this.Load += new System.EventHandler(this.frmLoaiTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
