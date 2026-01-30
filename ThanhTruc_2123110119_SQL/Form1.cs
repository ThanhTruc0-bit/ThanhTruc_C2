using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ThanhTruc_2123110119_SQL
{
    public partial class Form1 : Form
    {
        string strConn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNhanVien;Integrated Security=True";
        string currentImagePath = "";
        string oldMaNV = ""; // Biến quan trọng để sửa đúng người

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupGrid();
            cbGender.Items.Clear();
            cbGender.Items.AddRange(new string[] { "Nam", "Nữ" });
            cbGender.SelectedIndex = 0;
            LoadCategories();
            LoadData(); // Load ngay khi mở để tránh lỗi DBNull như ảnh 1
        }

        private void LoadData(string keyword = "")
        {
            try
            {
                dgvCustomer.Rows.Clear();
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    string sql = "SELECT * FROM NhanVien";
                    if (!string.IsNullOrEmpty(keyword)) sql += " WHERE MaNV LIKE @key OR HoTen LIKE @key";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    if (!string.IsNullOrEmpty(keyword)) cmd.Parameters.AddWithValue("@key", "%" + keyword + "%");

                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        // Xử lý Ngày sinh (Ảnh 1 bị lỗi vì chỗ này không kiểm tra NULL)
                        string ngaySinhStr = "";
                        if (r["NgaySinh"] != DBNull.Value)
                            ngaySinhStr = Convert.ToDateTime(r["NgaySinh"]).ToString("dd/MM/yyyy");

                        string path = r["HinhAnh"]?.ToString() ?? "";
                        Image img = null;
                        if (!string.IsNullOrEmpty(path) && File.Exists(path))
                        {
                            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                                img = Image.FromStream(fs);
                        }

                        dgvCustomer.Rows.Add(
                            r["MaNV"]?.ToString().Trim() ?? "",
                            r["HoTen"]?.ToString() ?? "",
                            r["GioiTinh"]?.ToString() ?? "",
                            ngaySinhStr,
                            r["DiaChi"]?.ToString() ?? "",
                            r["MaPhong"]?.ToString() ?? "",
                            r["MaChucVu"]?.ToString() ?? "",
                            r["LuongCoBan"]?.ToString() ?? "0",
                            img,
                            path
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách: " + ex.Message, "Thông báo");
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbId.Text)) { MessageBox.Show("Vui lòng nhập Mã nhân viên!", "Nhắc nhở"); return; }
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    string sql = @"INSERT INTO NhanVien (MaNV, HoTen, GioiTinh, NgaySinh, DiaChi, MaPhong, MaChucVu, HinhAnh, LuongCoBan) 
                                   VALUES (@Ma, @Ten, @GT, @NS, @DC, @MP, @MCV, @Anh, @L)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Ma", tbId.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ten", tbName.Text.Trim());
                    cmd.Parameters.AddWithValue("@GT", cbGender.Text);
                    cmd.Parameters.AddWithValue("@NS", dtpBirth.Value);
                    cmd.Parameters.AddWithValue("@DC", tbAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@MP", cbDept.Text);
                    cmd.Parameters.AddWithValue("@MCV", cbPos.Text);
                    cmd.Parameters.AddWithValue("@Anh", currentImagePath);
                    decimal luong = 0; decimal.TryParse(tbSalary.Text, out luong);
                    cmd.Parameters.AddWithValue("@L", luong);

                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Đã thêm nhân viên thành công!", "Thành công");
                }
            }
            catch (SqlException ex)
            {
                // Thay thế thông báo tiếng Anh "Violation of PRIMARY KEY" (Ảnh 2)
                if (ex.Number == 2627) MessageBox.Show("Mã nhân viên này đã có trong máy rồi, không thể thêm trùng!", "Lỗi trùng mã");
                else MessageBox.Show("Lỗi cơ sở dữ liệu: " + ex.Message, "Lỗi");
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(oldMaNV)) { MessageBox.Show("Vui lòng chọn nhân viên cần sửa từ bảng!", "Thông báo"); return; }
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    string sql = @"UPDATE NhanVien SET MaNV=@Ma, HoTen=@Ten, GioiTinh=@GT, NgaySinh=@NS, 
                                   DiaChi=@DC, MaPhong=@MP, MaChucVu=@MCV, HinhAnh=@Anh, LuongCoBan=@L 
                                   WHERE MaNV=@Old";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Ma", tbId.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ten", tbName.Text.Trim());
                    cmd.Parameters.AddWithValue("@GT", cbGender.Text);
                    cmd.Parameters.AddWithValue("@NS", dtpBirth.Value);
                    cmd.Parameters.AddWithValue("@DC", tbAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@MP", cbDept.Text);
                    cmd.Parameters.AddWithValue("@MCV", cbPos.Text);
                    cmd.Parameters.AddWithValue("@Anh", currentImagePath);
                    decimal luong = 0; decimal.TryParse(tbSalary.Text, out luong);
                    cmd.Parameters.AddWithValue("@L", luong);
                    cmd.Parameters.AddWithValue("@Old", oldMaNV);

                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Đã cập nhật thông tin nhân viên thành công!", "Thành công");
                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi trùng mã khi sửa (Ảnh 3, 4)
                if (ex.Number == 2627) MessageBox.Show("Không thể đổi sang mã này vì đã có nhân viên khác dùng rồi!", "Lỗi");
                else MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi");
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvCustomer.Rows[e.RowIndex];
                tbId.Text = oldMaNV = r.Cells["MaNV"].Value?.ToString() ?? "";
                tbName.Text = r.Cells["HoTen"].Value?.ToString() ?? "";
                cbGender.Text = r.Cells["GioiTinh"].Value?.ToString() ?? "Nam";
                tbAddress.Text = r.Cells["DiaChi"].Value?.ToString() ?? "";
                cbDept.Text = r.Cells["MaPhong"].Value?.ToString() ?? "";
                cbPos.Text = r.Cells["MaChucVu"].Value?.ToString() ?? "";
                tbSalary.Text = r.Cells["LuongCoBan"].Value?.ToString() ?? "0";
                currentImagePath = r.Cells["HinhAnh"].Value?.ToString() ?? "";

                string valNgay = r.Cells["NgaySinh"].Value?.ToString();
                if (!string.IsNullOrEmpty(valNgay))
                {
                    try { dtpBirth.Value = DateTime.ParseExact(valNgay, "dd/MM/yyyy", null); }
                    catch { dtpBirth.Value = DateTime.Now; }
                }
                picAvatar.Image = r.Cells["AnhHienThi"].Value as Image;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbId.Text)) return;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(strConn))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM NhanVien WHERE MaNV=@Ma", conn);
                        cmd.Parameters.AddWithValue("@Ma", tbId.Text.Trim());
                        cmd.ExecuteNonQuery();
                        btRead_Click(sender, e); // Xóa trắng form sau khi xóa
                        MessageBox.Show("Đã xóa nhân viên khỏi hệ thống!", "Thông báo");
                    }
                }
                catch { MessageBox.Show("Không thể xóa nhân viên này (có dữ liệu liên quan)!", "Lỗi"); }
            }
        }


        private void btRead_Click(object sender, EventArgs e)
        {
            tbId.Clear(); tbName.Clear(); tbAddress.Clear(); tbSalary.Clear();
            currentImagePath = ""; picAvatar.Image = null; oldMaNV = "";
            LoadData();
        }

        private void LoadCategories()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    SqlCommand cmdD = new SqlCommand("SELECT MaPhong FROM PhongBan", conn);
                    SqlDataReader rD = cmdD.ExecuteReader();
                    cbDept.Items.Clear();
                    while (rD.Read()) cbDept.Items.Add(rD["MaPhong"].ToString());
                    rD.Close();

                    SqlCommand cmdP = new SqlCommand("SELECT MaChucVu FROM ChucVu", conn);
                    SqlDataReader rP = cmdP.ExecuteReader();
                    cbPos.Items.Clear();
                    while (rP.Read()) cbPos.Items.Add(rP["MaChucVu"].ToString());
                    rP.Close();
                }
            }
            catch { }
        }

        private void SetupGrid()
        {
            dgvCustomer.Columns.Clear();
            dgvCustomer.Columns.Add("MaNV", "Mã NV");
            dgvCustomer.Columns.Add("HoTen", "Họ Tên");
            dgvCustomer.Columns.Add("GioiTinh", "Phái");
            dgvCustomer.Columns.Add("NgaySinh", "Ngày Sinh");
            dgvCustomer.Columns.Add("DiaChi", "Địa Chỉ");
            dgvCustomer.Columns.Add("MaPhong", "Phòng");
            dgvCustomer.Columns.Add("MaChucVu", "Chức Vụ");
            dgvCustomer.Columns.Add("LuongCoBan", "Lương CB");
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn { Name = "AnhHienThi", HeaderText = "Ảnh", ImageLayout = DataGridViewImageCellLayout.Zoom };
            dgvCustomer.Columns.Add(imgCol);
            dgvCustomer.Columns.Add("HinhAnh", "Path");
            dgvCustomer.Columns["HinhAnh"].Visible = false;
        }

        private void btChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Ảnh|*.jpg;*.png;*.jpeg" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                currentImagePath = ofd.FileName;
                picAvatar.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => LoadData(txtSearch.Text);
        private void btExit_Click(object sender, EventArgs e) => Application.Exit();

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}