using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ThanhTruc_2123110119_SQL
{
    public partial class FormPhongBan : Form
    {
        string strConn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNhanVien;Integrated Security=True";
        string oldMaPhong = "";

        public FormPhongBan()
        {
            InitializeComponent();
        }

        private void FormPhongBan_Load(object sender, EventArgs e)
        {
            SetupGrid();
            LoadData();
        }

        private void SetupGrid()
        {
            dgvPhongBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhongBan.AllowUserToAddRows = false;
            dgvPhongBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhongBan.ReadOnly = true;
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PhongBan", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPhongBan.DataSource = dt;
                    dgvPhongBan.Columns["MaPhong"].HeaderText = "Mã Phòng";
                    dgvPhongBan.Columns["TenPhong"].HeaderText = "Tên Phòng";
                    dgvPhongBan.Columns["SDT_Phong"].HeaderText = "Số Điện Thoại";
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private bool CheckMaExists(string ma)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM PhongBan WHERE MaPhong=@ma", conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private void btRead_Click(object sender, EventArgs e) => LoadData();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ma = txtMaPhong.Text.Trim();
            if (CheckMaExists(ma)) { MessageBox.Show("Mã phòng đã tồn tại!"); return; }
            ExecuteSQL("INSERT INTO PhongBan VALUES (@ma, @ten, @sdt)", "Thêm thành công!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(oldMaPhong)) return;
            string newMa = txtMaPhong.Text.Trim();

            if (newMa != oldMaPhong)
            {
                if (CheckMaExists(newMa))
                    MessageBox.Show("Lỗi: Mã phòng '" + newMa + "' đã tồn tại!", "Thông báo");
                else
                    MessageBox.Show("Lỗi: Không được sửa Mã Phòng (Foreign Key Constraint)!", "Thông báo");

                txtMaPhong.Text = oldMaPhong;
            }
            ExecuteSQL("UPDATE PhongBan SET TenPhong=@ten, SDT_Phong=@sdt WHERE MaPhong=@maOld", "Cập nhật thành công!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(oldMaPhong)) return;
            if (MessageBox.Show("Xóa phòng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                ExecuteSQL("DELETE FROM PhongBan WHERE MaPhong=@maOld", "Đã xóa!");
        }

        private void ExecuteSQL(string sql, string msg)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", txtMaPhong.Text.Trim());
                    cmd.Parameters.AddWithValue("@maOld", oldMaPhong);
                    cmd.Parameters.AddWithValue("@ten", txtTenPhong.Text.Trim());
                    cmd.Parameters.AddWithValue("@sdt", txtSDT.Text.Trim());
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show(msg);
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhongBan.Rows[e.RowIndex];
                txtMaPhong.Text = oldMaPhong = row.Cells["MaPhong"].Value.ToString().Trim();
                txtTenPhong.Text = row.Cells["TenPhong"].Value.ToString();
                txtSDT.Text = row.Cells["SDT_Phong"].Value.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => this.Close();

        private void dgvPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}