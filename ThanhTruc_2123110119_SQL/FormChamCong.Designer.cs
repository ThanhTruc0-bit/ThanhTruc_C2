namespace ThanhTruc_2123110119_SQL
{
    partial class FormChamCong
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
            System.Windows.Forms.DataGridViewCellStyle cellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.tbMaCong = new System.Windows.Forms.TextBox();
            this.lbMaCong = new System.Windows.Forms.Label();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.numNgayCong = new System.Windows.Forms.NumericUpDown();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.tbNam = new System.Windows.Forms.TextBox();
            this.tbThang = new System.Windows.Forms.TextBox();
            this.lbNgay = new System.Windows.Forms.Label();
            this.lbNam = new System.Windows.Forms.Label();
            this.lbThang = new System.Windows.Forms.Label();
            this.lbNV = new System.Windows.Forms.Label();
            this.btNew = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNgayCong)).BeginInit();
            this.SuspendLayout();

            // lbTitle
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
            this.lbTitle.Location = new System.Drawing.Point(0, 10);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1200, 45);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "QUẢN LÝ CHẤM CÔNG NHÂN VIÊN";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // dgvChamCong
            this.dgvChamCong.AllowUserToAddRows = false;
            this.dgvChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamCong.BackgroundColor = System.Drawing.Color.FromArgb(37, 42, 64);
            this.dgvChamCong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            cellStyle1.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            cellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvChamCong.ColumnHeadersDefaultCellStyle = cellStyle1;
            this.dgvChamCong.ColumnHeadersHeight = 45;
            cellStyle2.BackColor = System.Drawing.Color.FromArgb(37, 42, 64);
            cellStyle2.ForeColor = System.Drawing.Color.White;
            cellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            this.dgvChamCong.DefaultCellStyle = cellStyle2;
            this.dgvChamCong.EnableHeadersVisualStyles = false;
            this.dgvChamCong.Location = new System.Drawing.Point(30, 85);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.RowHeadersVisible = false;
            this.dgvChamCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChamCong.Size = new System.Drawing.Size(740, 630);
            this.dgvChamCong.TabIndex = 1;
            this.dgvChamCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamCong_CellClick);

            // gbInfo
            this.gbInfo.Controls.Add(this.tbMaCong);
            this.gbInfo.Controls.Add(this.lbMaCong);
            this.gbInfo.Controls.Add(this.tbMaNV);
            this.gbInfo.Controls.Add(this.lbMaNV);
            this.gbInfo.Controls.Add(this.numNgayCong);
            this.gbInfo.Controls.Add(this.cbMaNV);
            this.gbInfo.Controls.Add(this.tbNam);
            this.gbInfo.Controls.Add(this.tbThang);
            this.gbInfo.Controls.Add(this.lbNgay);
            this.gbInfo.Controls.Add(this.lbNam);
            this.gbInfo.Controls.Add(this.lbThang);
            this.gbInfo.Controls.Add(this.lbNV);
            this.gbInfo.Controls.Add(this.btRead);
            this.gbInfo.Controls.Add(this.btNew);
            this.gbInfo.Controls.Add(this.btEdit);
            this.gbInfo.Controls.Add(this.btDelete);
            this.gbInfo.Controls.Add(this.btExit);
            this.gbInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbInfo.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
            this.gbInfo.Location = new System.Drawing.Point(790, 85);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(380, 630);
            this.gbInfo.TabIndex = 2;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = " THÔNG TIN CHẤM CÔNG ";

            // Tọa độ đã fix cứng số để tránh lỗi Designer
            this.lbMaCong.Text = "ID Tự Động:";
            this.lbMaCong.Location = new System.Drawing.Point(20, 50);
            this.tbMaCong.Location = new System.Drawing.Point(125, 50);
            this.tbMaCong.Size = new System.Drawing.Size(220, 25);
            this.tbMaCong.ReadOnly = true;

            this.lbMaNV.Text = "Mã NV:";
            this.lbMaNV.Location = new System.Drawing.Point(20, 100);
            this.tbMaNV.Location = new System.Drawing.Point(125, 100);
            this.tbMaNV.Size = new System.Drawing.Size(220, 25);
            this.tbMaNV.ReadOnly = true;

            this.lbNV.Text = "Họ Tên:";
            this.lbNV.Location = new System.Drawing.Point(20, 150);
            this.cbMaNV.Location = new System.Drawing.Point(125, 150);
            this.cbMaNV.Size = new System.Drawing.Size(220, 25);
            this.cbMaNV.SelectedIndexChanged += new System.EventHandler(this.cbMaNV_SelectedIndexChanged);

            this.lbThang.Text = "Tháng:";
            this.lbThang.Location = new System.Drawing.Point(20, 200);
            this.tbThang.Location = new System.Drawing.Point(125, 200);
            this.tbThang.Size = new System.Drawing.Size(220, 25);

            this.lbNam.Text = "Năm:";
            this.lbNam.Location = new System.Drawing.Point(20, 250);
            this.tbNam.Location = new System.Drawing.Point(125, 250);
            this.tbNam.Size = new System.Drawing.Size(220, 25);

            this.lbNgay.Text = "Số Ngày:";
            this.lbNgay.Location = new System.Drawing.Point(20, 300);
            this.numNgayCong.Location = new System.Drawing.Point(125, 300);
            this.numNgayCong.Size = new System.Drawing.Size(220, 25);

            // --- NÚT BẤM STYLE FORM1 ---
            this.btRead.Location = new System.Drawing.Point(25, 530);
            this.btRead.Size = new System.Drawing.Size(100, 35);
            this.btRead.Text = "Làm mới";
            this.btRead.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.btRead.ForeColor = System.Drawing.Color.White;
            this.btRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRead.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);

            this.btNew.Location = new System.Drawing.Point(135, 530);
            this.btNew.Size = new System.Drawing.Size(100, 35);
            this.btNew.Text = "Thêm";
            this.btNew.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.btNew.ForeColor = System.Drawing.Color.White;
            this.btNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);

            this.btEdit.Location = new System.Drawing.Point(245, 530);
            this.btEdit.Size = new System.Drawing.Size(100, 35);
            this.btEdit.Text = "Sửa";
            this.btEdit.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.btEdit.ForeColor = System.Drawing.Color.White;
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);

            this.btDelete.Location = new System.Drawing.Point(25, 575);
            this.btDelete.Size = new System.Drawing.Size(155, 35);
            this.btDelete.Text = "Xóa dòng";
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);

            this.btExit.Location = new System.Drawing.Point(190, 575);
            this.btExit.Size = new System.Drawing.Size(155, 35);
            this.btExit.Text = "Thoát";
            this.btExit.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);

            // FormChamCong
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.dgvChamCong);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChamCong";
            this.Load += new System.EventHandler(this.FormChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNgayCong)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TextBox tbMaCong;
        private System.Windows.Forms.Label lbMaCong;
        private System.Windows.Forms.TextBox tbMaNV;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.NumericUpDown numNgayCong;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.TextBox tbNam;
        private System.Windows.Forms.TextBox tbThang;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Label lbNam;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.Label lbNV;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Button btExit;
    }
}