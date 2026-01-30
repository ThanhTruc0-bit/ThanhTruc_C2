using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ThanhTruc_2123110119_SQL
{
    public partial class frmMain : Form
    {
        // Chuỗi kết nối SQL
        string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNhanVien;Integrated Security=True";
        private Form activeForm = null;

        public frmMain()
        {
            InitializeComponent();

            // Cấu hình đồng hồ
            timerClock.Interval = 1000;
            timerClock.Tick += (s, e) => lbTime.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
            timerClock.Start();

            // Gán sự kiện cho các nút menu
            btnDashboard.Click += (s, e) => ShowDashboard(s);
            btnNhanVien.Click += (s, e) => OpenChildForm(new Form1(), "QUẢN LÝ NHÂN VIÊN", s);
            btnChamCong.Click += (s, e) => OpenChildForm(new FormChamCong(), "QUẢN LÝ CHẤM CÔNG", s);
            btnPhongBan.Click += (s, e) => OpenChildForm(new FormPhongBan(), "QUẢN LÝ PHÒNG BAN", s);
            btnChucVu.Click += (s, e) => OpenChildForm(new FormChucVu(), "QUẢN LÝ CHỨC VỤ", s);
            btnTaiKhoan.Click += (s, e) => OpenChildForm(new FormTaiKhoan(), "QUẢN LÝ TÀI KHOẢN", s);

            btnExit.Click += (s, e) => {
                if (MessageBox.Show("Xác nhận đăng xuất?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Exit();
            };
        }

        // Hàm mở Form con vào panel Content
        private void OpenChildForm(Form child, string title, object sender)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = child;
            MoveNavIndicator(sender);
            lbTitle.Text = title;
            pnlContent.Controls.Clear();
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(child);
            child.Show();
        }

        // Hiển thị Dashboard (Tổng quan)
        private void ShowDashboard(object sender)
        {
            if (activeForm != null) activeForm.Close();
            MoveNavIndicator(sender);
            lbTitle.Text = "BẢNG ĐIỀU KHIỂN HỆ THỐNG";
            pnlContent.Controls.Clear();

            int totalNV = GetCount("SELECT COUNT(*) FROM NhanVien");
            int totalPB = GetCount("SELECT COUNT(*) FROM PhongBan");
            int totalTK = GetCount("SELECT COUNT(*) FROM TaiKhoan");

            pnlContent.Controls.Add(CreateCard("TỔNG NHÂN VIÊN", totalNV.ToString(), "Nhân sự", Color.FromArgb(0, 126, 249), 40, 30));
            pnlContent.Controls.Add(CreateCard("PHÒNG BAN", totalPB.ToString(), "Tổ chức", Color.FromArgb(46, 204, 113), 320, 30));
            pnlContent.Controls.Add(CreateCard("TÀI KHOẢN", totalTK.ToString(), "Admin", Color.FromArgb(155, 89, 182), 600, 30));

            double namCount = GetCount("SELECT COUNT(*) FROM NhanVien WHERE GioiTinh = N'Nam'");
            int pNam = totalNV > 0 ? (int)Math.Round((namCount / totalNV) * 100) : 0;
            int pNu = totalNV > 0 ? (100 - pNam) : 0;

            Panel pnlChart = new Panel { Size = new Size(800, 260), Location = new Point(40, 180), BackColor = Color.FromArgb(37, 42, 64) };
            pnlChart.Controls.Add(new Label { Text = "TỶ LỆ GIỚI TÍNH NHÂN VIÊN", ForeColor = Color.White, Font = new Font("Segoe UI", 12, FontStyle.Bold), Location = new Point(20, 20), AutoSize = true });
            pnlChart.Controls.Add(CreateProgress($"Nam ({pNam}%)", pNam, Color.FromArgb(0, 126, 249), 80));
            pnlChart.Controls.Add(CreateProgress($"Nữ ({pNu}%)", pNu, Color.FromArgb(255, 100, 150), 160));
            pnlContent.Controls.Add(pnlChart);
        }

        private int GetCount(string sql)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    return (int)new SqlCommand(sql, conn).ExecuteScalar();
                }
            }
            catch { return 0; }
        }

        private Panel CreateCard(string title, string val, string desc, Color c, int x, int y)
        {
            Panel p = new Panel { Size = new Size(240, 120), Location = new Point(x, y), BackColor = Color.FromArgb(37, 42, 64) };
            p.Controls.Add(new Label { Text = title, ForeColor = Color.Silver, Font = new Font("Segoe UI", 10, FontStyle.Bold), Location = new Point(15, 15), AutoSize = true });
            p.Controls.Add(new Label { Text = val, ForeColor = Color.White, Font = new Font("Segoe UI", 25, FontStyle.Bold), Location = new Point(15, 40), AutoSize = true });
            p.Controls.Add(new Label { Text = desc, ForeColor = c, Font = new Font("Segoe UI", 8), Location = new Point(15, 95), AutoSize = true });
            return p;
        }

        private Panel CreateProgress(string txt, int val, Color c, int y)
        {
            Panel container = new Panel { Size = new Size(750, 50), Location = new Point(20, y) };
            container.Controls.Add(new Label { Text = txt, ForeColor = Color.White, Dock = DockStyle.Top, Height = 25 });
            Panel bg = new Panel { Dock = DockStyle.Bottom, Height = 12, BackColor = Color.FromArgb(46, 51, 73) };
            Panel bar = new Panel { Width = (int)(750 * val / 100.0), Height = 12, BackColor = c };
            bg.Controls.Add(bar);
            container.Controls.Add(bg);
            return container;
        }

        private void MoveNavIndicator(object sender)
        {
            if (sender is Button btn)
            {
                pnlNavIndicator.Top = btn.Top;
                pnlNavIndicator.Height = btn.Height;
                pnlNavIndicator.BringToFront();
            }
        }

        private void frmMain_Load(object sender, EventArgs e) => btnDashboard.PerformClick();

        // Di chuyển Form bằng Header
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}