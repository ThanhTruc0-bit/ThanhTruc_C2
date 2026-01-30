namespace ThanhTruc_2123110119_SQL
{
    partial class FormChucVu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvChucVu = new System.Windows.Forms.DataGridView();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.lbMa = new System.Windows.Forms.Label();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.lbPhuCap = new System.Windows.Forms.Label();
            this.txtPhuCap = new System.Windows.Forms.TextBox();
            this.btRead = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            this.gbDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvChucVu
            // 
            this.dgvChucVu.AllowUserToAddRows = false;
            this.dgvChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChucVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.dgvChucVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvChucVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChucVu.ColumnHeadersHeight = 45;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChucVu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChucVu.EnableHeadersVisualStyles = false;
            this.dgvChucVu.Location = new System.Drawing.Point(30, 85);
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.RowHeadersVisible = false;
            this.dgvChucVu.RowHeadersWidth = 51;
            this.dgvChucVu.RowTemplate.Height = 40;
            this.dgvChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChucVu.Size = new System.Drawing.Size(740, 630);
            this.dgvChucVu.TabIndex = 1;
            this.dgvChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChucVu_CellClick);
            this.dgvChucVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChucVu_CellContentClick_1);
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.lbMa);
            this.gbDetail.Controls.Add(this.txtMaCV);
            this.gbDetail.Controls.Add(this.lbTen);
            this.gbDetail.Controls.Add(this.txtTenCV);
            this.gbDetail.Controls.Add(this.lbPhuCap);
            this.gbDetail.Controls.Add(this.txtPhuCap);
            this.gbDetail.Controls.Add(this.btRead);
            this.gbDetail.Controls.Add(this.btnAdd);
            this.gbDetail.Controls.Add(this.btnEdit);
            this.gbDetail.Controls.Add(this.btnDelete);
            this.gbDetail.Controls.Add(this.btnExit);
            this.gbDetail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.gbDetail.Location = new System.Drawing.Point(790, 75);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(380, 640);
            this.gbDetail.TabIndex = 2;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = " THÔNG TIN CHI TIẾT ";
            // 
            // lbMa
            // 
            this.lbMa.ForeColor = System.Drawing.Color.White;
            this.lbMa.Location = new System.Drawing.Point(20, 60);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(100, 23);
            this.lbMa.TabIndex = 0;
            this.lbMa.Text = "Mã CV:";
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(125, 57);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(220, 30);
            this.txtMaCV.TabIndex = 1;
            // 
            // lbTen
            // 
            this.lbTen.ForeColor = System.Drawing.Color.White;
            this.lbTen.Location = new System.Drawing.Point(20, 110);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(100, 23);
            this.lbTen.TabIndex = 2;
            this.lbTen.Text = "Tên CV:";
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(125, 107);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(220, 30);
            this.txtTenCV.TabIndex = 3;
            // 
            // lbPhuCap
            // 
            this.lbPhuCap.ForeColor = System.Drawing.Color.White;
            this.lbPhuCap.Location = new System.Drawing.Point(20, 160);
            this.lbPhuCap.Name = "lbPhuCap";
            this.lbPhuCap.Size = new System.Drawing.Size(100, 23);
            this.lbPhuCap.TabIndex = 4;
            this.lbPhuCap.Text = "Phụ Cấp:";
            // 
            // txtPhuCap
            // 
            this.txtPhuCap.Location = new System.Drawing.Point(125, 157);
            this.txtPhuCap.Name = "txtPhuCap";
            this.txtPhuCap.Size = new System.Drawing.Size(220, 30);
            this.txtPhuCap.TabIndex = 5;
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(25, 540);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(100, 35);
            this.btRead.TabIndex = 6;
            this.btRead.Text = "Làm mới";
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(135, 540);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(245, 540);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 35);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(25, 585);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(190, 585);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 35);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbTitle.Location = new System.Drawing.Point(0, 15);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1200, 50);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "QUẢN LÝ CHỨC VỤ";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormChucVu
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dgvChucVu);
            this.Controls.Add(this.gbDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChucVu;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.TextBox txtMaCV, txtTenCV, txtPhuCap;
        private System.Windows.Forms.Label lbMa, lbTen, lbPhuCap, lbTitle;
        private System.Windows.Forms.Button btRead, btnAdd, btnEdit, btnDelete, btnExit;
    }
}