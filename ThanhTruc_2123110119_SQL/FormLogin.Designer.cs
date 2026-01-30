namespace ThanhTruc_2123110119_SQL
{
    partial class FormLogin
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lbSubTitle = new System.Windows.Forms.Label();
            this.lbLogo = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlPassLine = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassTag = new System.Windows.Forms.Label();
            this.pnlUserLine = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbUserTag = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();

            // --- PANEL TRÁI: SIDEBAR (MIDNIGHT BLUE) ---
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(33, 47, 61);
            this.pnlSidebar.Controls.Add(this.lbSubTitle);
            this.pnlSidebar.Controls.Add(this.lbLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Size = new System.Drawing.Size(300, 480);
            this.pnlSidebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);

            this.lbLogo.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lbLogo.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.lbLogo.Location = new System.Drawing.Point(0, 160);
            this.lbLogo.Size = new System.Drawing.Size(300, 70);
            this.lbLogo.Text = "HRM";
            this.lbLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lbSubTitle.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbSubTitle.ForeColor = System.Drawing.Color.FromArgb(174, 182, 191);
            this.lbSubTitle.Location = new System.Drawing.Point(0, 230);
            this.lbSubTitle.Size = new System.Drawing.Size(300, 60);
            this.lbSubTitle.Text = "Smart Management Solution\nDesign by Thanh Truc";
            this.lbSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // --- PANEL PHẢI: FORM (CLEAN WHITE) ---
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.btnExit);
            this.pnlMain.Controls.Add(this.btnLogin);
            this.pnlMain.Controls.Add(this.pnlPassLine);
            this.pnlMain.Controls.Add(this.txtPassword);
            this.pnlMain.Controls.Add(this.lbPassTag);
            this.pnlMain.Controls.Add(this.pnlUserLine);
            this.pnlMain.Controls.Add(this.txtUsername);
            this.pnlMain.Controls.Add(this.lbUserTag);
            this.pnlMain.Controls.Add(this.lbWelcome);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(300, 0);
            this.pnlMain.Size = new System.Drawing.Size(500, 480);
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);

            this.lbWelcome.Font = new System.Drawing.Font("Segoe UI Semilight", 22F);
            this.lbWelcome.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lbWelcome.Location = new System.Drawing.Point(40, 60);
            this.lbWelcome.Size = new System.Drawing.Size(300, 50);
            this.lbWelcome.Text = "Login to System";

            // Username
            this.lbUserTag.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbUserTag.ForeColor = System.Drawing.Color.DarkGray;
            this.lbUserTag.Location = new System.Drawing.Point(50, 150);
            this.lbUserTag.Text = "USERNAME";

            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsername.Location = new System.Drawing.Point(50, 175);
            this.txtUsername.Size = new System.Drawing.Size(380, 27);

            this.pnlUserLine.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.pnlUserLine.Location = new System.Drawing.Point(50, 205);
            this.pnlUserLine.Size = new System.Drawing.Size(380, 2);

            // Password
            this.lbPassTag.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbPassTag.ForeColor = System.Drawing.Color.DarkGray;
            this.lbPassTag.Location = new System.Drawing.Point(50, 235);
            this.lbPassTag.Text = "PASSWORD";

            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.Location = new System.Drawing.Point(50, 260);
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(380, 27);

            this.pnlPassLine.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.pnlPassLine.Location = new System.Drawing.Point(50, 290);
            this.pnlPassLine.Size = new System.Drawing.Size(380, 2);

            // Buttons
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(50, 340);
            this.btnLogin.Size = new System.Drawing.Size(380, 50);
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Location = new System.Drawing.Point(190, 410);
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.Text = "Exit App";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // Finalize Form
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlSidebar.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar, pnlMain, pnlUserLine, pnlPassLine;
        private System.Windows.Forms.Label lbLogo, lbSubTitle, lbWelcome, lbUserTag, lbPassTag;
        private System.Windows.Forms.TextBox txtUsername, txtPassword;
        private System.Windows.Forms.Button btnLogin, btnExit;
    }
}