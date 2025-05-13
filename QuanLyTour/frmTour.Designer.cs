// File: frmTour.Designer.cs
namespace QuanLyTour
{
    partial class frmTour
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvTour;
        private System.Windows.Forms.TextBox txtTourName;
        private System.Windows.Forms.ComboBox cbTourType;
        private System.Windows.Forms.ComboBox cbTransport;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpCreatedAt;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTourName;
        private System.Windows.Forms.Label lblTourType;
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Label lblImage;

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
            this.dgvTour = new System.Windows.Forms.DataGridView();
            this.txtTourName = new System.Windows.Forms.TextBox();
            this.cbTourType = new System.Windows.Forms.ComboBox();
            this.cbTransport = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpCreatedAt = new System.Windows.Forms.DateTimePicker();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTourName = new System.Windows.Forms.Label();
            this.lblTourType = new System.Windows.Forms.Label();
            this.lblTransport = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSearchBudget = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTour
            // 
            this.dgvTour.AllowUserToAddRows = false;
            this.dgvTour.AllowUserToDeleteRows = false;
            this.dgvTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTour.Location = new System.Drawing.Point(12, 12);
            this.dgvTour.MultiSelect = false;
            this.dgvTour.Name = "dgvTour";
            this.dgvTour.ReadOnly = true;
            this.dgvTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTour.Size = new System.Drawing.Size(956, 250);
            this.dgvTour.TabIndex = 0;
            this.dgvTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellClick);
            // 
            // txtTourName
            // 
            this.txtTourName.Location = new System.Drawing.Point(15, 341);
            this.txtTourName.Name = "txtTourName";
            this.txtTourName.Size = new System.Drawing.Size(200, 20);
            this.txtTourName.TabIndex = 2;
            // 
            // cbTourType
            // 
            this.cbTourType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTourType.Location = new System.Drawing.Point(224, 340);
            this.cbTourType.Name = "cbTourType";
            this.cbTourType.Size = new System.Drawing.Size(200, 21);
            this.cbTourType.TabIndex = 4;
            // 
            // cbTransport
            // 
            this.cbTransport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransport.Location = new System.Drawing.Point(464, 341);
            this.cbTransport.Name = "cbTransport";
            this.cbTransport.Size = new System.Drawing.Size(200, 21);
            this.cbTransport.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(681, 340);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(87, 20);
            this.txtPrice.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 384);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(400, 118);
            this.txtDescription.TabIndex = 10;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(461, 398);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 12;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(461, 439);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 14;
            // 
            // dtpCreatedAt
            // 
            this.dtpCreatedAt.Location = new System.Drawing.Point(461, 482);
            this.dtpCreatedAt.Name = "dtpCreatedAt";
            this.dtpCreatedAt.Size = new System.Drawing.Size(200, 20);
            this.dtpCreatedAt.TabIndex = 16;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(681, 390);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 112);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 18;
            this.pictureBox.TabStop = false;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Location = new System.Drawing.Point(837, 390);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(75, 23);
            this.btnChooseImage.TabIndex = 19;
            this.btnChooseImage.Text = "Chọn ảnh";
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 510);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(100, 510);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(181, 510);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTourName
            // 
            this.lblTourName.Location = new System.Drawing.Point(15, 321);
            this.lblTourName.Name = "lblTourName";
            this.lblTourName.Size = new System.Drawing.Size(100, 13);
            this.lblTourName.TabIndex = 1;
            this.lblTourName.Text = "Tên Tour";
            // 
            // lblTourType
            // 
            this.lblTourType.Location = new System.Drawing.Point(227, 320);
            this.lblTourType.Name = "lblTourType";
            this.lblTourType.Size = new System.Drawing.Size(100, 13);
            this.lblTourType.TabIndex = 3;
            this.lblTourType.Text = "Loại Tour";
            // 
            // lblTransport
            // 
            this.lblTransport.Location = new System.Drawing.Point(461, 320);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(100, 18);
            this.lblTransport.TabIndex = 5;
            this.lblTransport.Text = "Phương tiện";
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(678, 321);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 14);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Giá";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(15, 370);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 11);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Mô tả";
            // 
            // lblStartDate
            // 
            this.lblStartDate.Location = new System.Drawing.Point(461, 383);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(100, 12);
            this.lblStartDate.TabIndex = 11;
            this.lblStartDate.Text = "Ngày bắt đầu";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Location = new System.Drawing.Point(461, 421);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(100, 15);
            this.lblEndDate.TabIndex = 13;
            this.lblEndDate.Text = "Ngày kết thúc";
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.Location = new System.Drawing.Point(459, 462);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(100, 17);
            this.lblCreatedAt.TabIndex = 15;
            this.lblCreatedAt.Text = "Ngày tạo";
            // 
            // lblImage
            // 
            this.lblImage.Location = new System.Drawing.Point(678, 370);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(42, 17);
            this.lblImage.TabIndex = 17;
            this.lblImage.Text = "Ảnh";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Clear";
            this.button1.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 510);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Xuất excel";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(461, 510);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Search";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(771, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ngân sách";
            // 
            // cbSearchBudget
            // 
            this.cbSearchBudget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchBudget.Items.AddRange(new object[] {
            "Dưới 1.000.000",
            "Từ 1.000.000 đến 2.000.000",
            "Từ 2.000.000 đến 4.000.000",
            "Trên 4.000.000"});
            this.cbSearchBudget.Location = new System.Drawing.Point(774, 341);
            this.cbSearchBudget.Name = "cbSearchBudget";
            this.cbSearchBudget.Size = new System.Drawing.Size(200, 21);
            this.cbSearchBudget.TabIndex = 29;
            // 
            // frmTour
            // 
            this.ClientSize = new System.Drawing.Size(980, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSearchBudget);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTour);
            this.Controls.Add(this.lblTourName);
            this.Controls.Add(this.txtTourName);
            this.Controls.Add(this.lblTourType);
            this.Controls.Add(this.cbTourType);
            this.Controls.Add(this.lblTransport);
            this.Controls.Add(this.cbTransport);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblCreatedAt);
            this.Controls.Add(this.dtpCreatedAt);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTour";
            this.Text = "Quản lý Tour";
            this.Load += new System.EventHandler(this.frmTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSearchBudget;
    }
}
