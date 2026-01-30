using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ThanhTruc_2123110119_SQL
{
    public partial class FormChucVu : Form
    {
        string strConn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNhanVien;Integrated Security=True";
        string oldMaCV = "";

        public FormChucVu()
        {
            InitializeComponent();
        }

        private void FormChucVu_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadData();
        }

        private void SetupGrid()
        {
            dgvChucVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChucVu.AllowUserToAddRows = false;
            dgvChucVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChucVu.ReadOnly = true;
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ChucVu", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvChucVu.DataSource = dt;
                    dgvChucVu.Columns["MaChucVu"].HeaderText = "Mã Chức Vụ";
                    dgvChucVu.Columns["TenChucVu"].HeaderText = "Tên Chức Vụ";
                    dgvChucVu.Columns["PhuCap"].HeaderText = "Phụ Cấp";
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private bool CheckMaCVExists(string ma)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM ChucVu WHERE MaChucVu=@ma", conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private void btRead_Click(object sender, EventArgs e) => LoadData();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ma = txtMaCV.Text.Trim();
            if (CheckMaCVExists(ma)) { MessageBox.Show("Mã chức vụ đã tồn tại!"); return; }
            ExecuteSQL("INSERT INTO ChucVu VALUES (@ma, @ten, @pc)", "Thêm chức vụ thành công!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(oldMaCV))
            {
                MessageBox.Show("Vui lòng chọn chức vụ từ danh sách!");
                return;
            }

            string newMa = txtMaCV.Text.Trim();

            // Nếu người dùng cố tình đổi Mã Chức Vụ
            if (newMa != oldMaCV)
            {
                // 1. Kiểm tra xem mã mới có bị trùng với chức vụ khác không
                if (CheckMaCVExists(newMa))
                {
                    MessageBox.Show("Mã '" + newMa + "' đã tồn tại ở chức vụ khác!", "Thông báo");
                    return;
                }

                // 2. Nếu mã mới chưa tồn tại, cho phép sửa luôn cả Mã (Dùng UPDATE cả mã)
                ExecuteSQL("UPDATE ChucVu SET MaChucVu=@ma, TenChucVu=@ten, PhuCap=@pc WHERE MaChucVu=@maOld", "Cập nhật thành công!");
                oldMaCV = newMa; // Cập nhật lại biến tạm
            }
            else
            {
                // Nếu không đổi mã, chỉ cập nhật Tên và Phụ cấp
                ExecuteSQL("UPDATE ChucVu SET TenChucVu=@ten, PhuCap=@pc WHERE MaChucVu=@maOld", "Cập nhật thành công!");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(oldMaCV)) return;
            if (MessageBox.Show("Xác nhận xóa chức vụ " + oldMaCV + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                ExecuteSQL("DELETE FROM ChucVu WHERE MaChucVu=@maOld", "Đã xóa chức vụ!");
        }

        private void ExecuteSQL(string sql, string msg)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", txtMaCV.Text.Trim());
                    cmd.Parameters.AddWithValue("@maOld", oldMaCV);
                    cmd.Parameters.AddWithValue("@ten", txtTenCV.Text.Trim());

                    // Xử lý kiểu số cho Phụ Cấp
                    double pc = 0;
                    double.TryParse(txtPhuCap.Text, out pc);
                    cmd.Parameters.AddWithValue("@pc", pc);

                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show(msg);
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChucVu.Rows[e.RowIndex];
                txtMaCV.Text = oldMaCV = row.Cells["MaChucVu"].Value.ToString().Trim();
                txtTenCV.Text = row.Cells["TenChucVu"].Value.ToString();
                txtPhuCap.Text = row.Cells["PhuCap"].Value.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => this.Close();

        private void dgvChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvChucVu_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}