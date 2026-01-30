namespace ThanhTruc_2123110119_SQL
{
    partial class Form1
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
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btChooseImage = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbBirth = new System.Windows.Forms.Label();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.lbGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lbAddr = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lbDept = new System.Windows.Forms.Label();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.lbPos = new System.Windows.Forms.Label();
            this.cbPos = new System.Windows.Forms.ComboBox();
            this.lbSalary = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.btRead = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.gbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomer.ColumnHeadersHeight = 45;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomer.EnableHeadersVisualStyles = false;
            this.dgvCustomer.Location = new System.Drawing.Point(38, 102);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(846, 661);
            this.dgvCustomer.TabIndex = 3;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.picAvatar);
            this.gbDetail.Controls.Add(this.btChooseImage);
            this.gbDetail.Controls.Add(this.lbId);
            this.gbDetail.Controls.Add(this.tbId);
            this.gbDetail.Controls.Add(this.lbName);
            this.gbDetail.Controls.Add(this.tbName);
            this.gbDetail.Controls.Add(this.lbBirth);
            this.gbDetail.Controls.Add(this.dtpBirth);
            this.gbDetail.Controls.Add(this.lbGender);
            this.gbDetail.Controls.Add(this.cbGender);
            this.gbDetail.Controls.Add(this.lbAddr);
            this.gbDetail.Controls.Add(this.tbAddress);
            this.gbDetail.Controls.Add(this.lbDept);
            this.gbDetail.Controls.Add(this.cbDept);
            this.gbDetail.Controls.Add(this.lbPos);
            this.gbDetail.Controls.Add(this.cbPos);
            this.gbDetail.Controls.Add(this.lbSalary);
            this.gbDetail.Controls.Add(this.tbSalary);
            this.gbDetail.Controls.Add(this.btRead);
            this.gbDetail.Controls.Add(this.btNew);
            this.gbDetail.Controls.Add(this.btEdit);
            this.gbDetail.Controls.Add(this.btDelete);
            this.gbDetail.Controls.Add(this.btExit);
            this.gbDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.gbDetail.Location = new System.Drawing.Point(903, 91);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(434, 672);
            this.gbDetail.TabIndex = 4;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = " THÔNG TIN CHI TIẾT ";
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.picAvatar.Location = new System.Drawing.Point(137, 27);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(160, 160);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // btChooseImage
            // 
            this.btChooseImage.Location = new System.Drawing.Point(137, 192);
            this.btChooseImage.Name = "btChooseImage";
            this.btChooseImage.Size = new System.Drawing.Size(160, 27);
            this.btChooseImage.TabIndex = 1;
            this.btChooseImage.Text = "Chọn ảnh";
            this.btChooseImage.UseVisualStyleBackColor = true;
            this.btChooseImage.Click += new System.EventHandler(this.btChooseImage_Click);
            // 
            // lbId
            // 
            this.lbId.Location = new System.Drawing.Point(23, 235);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(114, 25);
            this.lbId.TabIndex = 2;
            this.lbId.Text = "Mã NV:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(143, 235);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(251, 27);
            this.tbId.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(23, 272);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(114, 25);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Họ Tên:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(143, 272);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(251, 27);
            this.tbName.TabIndex = 5;
            // 
            // lbBirth
            // 
            this.lbBirth.Location = new System.Drawing.Point(23, 309);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(114, 25);
            this.lbBirth.TabIndex = 6;
            this.lbBirth.Text = "Ngày Sinh:";
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(143, 309);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(251, 27);
            this.dtpBirth.TabIndex = 7;
            // 
            // lbGender
            // 
            this.lbGender.Location = new System.Drawing.Point(23, 347);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(114, 25);
            this.lbGender.TabIndex = 8;
            this.lbGender.Text = "Giới Tính:";
            // 
            // cbGender
            // 
            this.cbGender.Location = new System.Drawing.Point(143, 347);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(251, 28);
            this.cbGender.TabIndex = 9;
            // 
            // lbAddr
            // 
            this.lbAddr.Location = new System.Drawing.Point(23, 384);
            this.lbAddr.Name = "lbAddr";
            this.lbAddr.Size = new System.Drawing.Size(114, 25);
            this.lbAddr.TabIndex = 10;
            this.lbAddr.Text = "Địa Chỉ:";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(143, 384);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(251, 27);
            this.tbAddress.TabIndex = 11;
            // 
            // lbDept
            // 
            this.lbDept.Location = new System.Drawing.Point(23, 421);
            this.lbDept.Name = "lbDept";
            this.lbDept.Size = new System.Drawing.Size(114, 25);
            this.lbDept.TabIndex = 12;
            this.lbDept.Text = "Mã Phòng:";
            // 
            // cbDept
            // 
            this.cbDept.Location = new System.Drawing.Point(143, 421);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(251, 28);
            this.cbDept.TabIndex = 13;
            // 
            // lbPos
            // 
            this.lbPos.Location = new System.Drawing.Point(23, 459);
            this.lbPos.Name = "lbPos";
            this.lbPos.Size = new System.Drawing.Size(114, 25);
            this.lbPos.TabIndex = 14;
            this.lbPos.Text = "Chức Vụ:";
            // 
            // cbPos
            // 
            this.cbPos.Location = new System.Drawing.Point(143, 459);
            this.cbPos.Name = "cbPos";
            this.cbPos.Size = new System.Drawing.Size(251, 28);
            this.cbPos.TabIndex = 15;
            // 
            // lbSalary
            // 
            this.lbSalary.Location = new System.Drawing.Point(23, 496);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(114, 25);
            this.lbSalary.TabIndex = 16;
            this.lbSalary.Text = "Lương CB:";
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(143, 496);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(251, 27);
            this.tbSalary.TabIndex = 17;
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(29, 565);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(114, 37);
            this.btRead.TabIndex = 18;
            this.btRead.Text = "Làm mới";
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(154, 565);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(114, 37);
            this.btNew.TabIndex = 19;
            this.btNew.Text = "Thêm";
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(280, 565);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(114, 37);
            this.btEdit.TabIndex = 20;
            this.btEdit.Text = "Sửa";
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(29, 613);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(177, 37);
            this.btDelete.TabIndex = 21;
            this.btDelete.Text = "Xóa";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(217, 613);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(177, 37);
            this.btExit.TabIndex = 22;
            this.btExit.Text = "Thoát";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbTitle.Location = new System.Drawing.Point(0, 11);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1371, 48);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "QUẢN LÝ NHÂN VIÊN CHUYÊN NGHIỆP";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(212, 66);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(285, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbSearch.ForeColor = System.Drawing.Color.White;
            this.lbSearch.Location = new System.Drawing.Point(34, 64);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(160, 27);
            this.lbSearch.TabIndex = 1;
            this.lbSearch.Text = "🔍 Tìm Tên/Mã:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1371, 800);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.gbDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btChooseImage;
        private System.Windows.Forms.TextBox tbId, tbName, tbAddress, tbSalary, txtSearch;
        private System.Windows.Forms.ComboBox cbGender, cbDept, cbPos;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label lbId, lbName, lbBirth, lbGender, lbAddr, lbDept, lbPos, lbSalary, lbTitle, lbSearch;
        private System.Windows.Forms.Button btRead, btNew, btEdit, btDelete, btExit;
    }
}