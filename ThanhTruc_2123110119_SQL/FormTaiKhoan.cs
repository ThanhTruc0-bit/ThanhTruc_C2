using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ThanhTruc_2123110119_SQL
{
    public partial class FormTaiKhoan : Form
    {
        string strConn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNhanVien;Integrated Security=True";

        public FormTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadCB_NhanVien();
            LoadData();
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadCB_NhanVien()
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaNV, HoTen FROM NhanVien", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbMaNV.DataSource = dt;
                cbMaNV.DisplayMember = "HoTen";
                cbMaNV.ValueMember = "MaNV";
            }
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TaiKhoan", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTaiKhoan.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ExecuteSQL("INSERT INTO TaiKhoan VALUES (@user, @pass, @quyen, @ma)", "Thêm tài khoản thành công!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ExecuteSQL("UPDATE TaiKhoan SET MatKhau=@pass, Quyen=@quyen, MaNV=@ma WHERE TenDN=@user", "Sửa thành công!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                ExecuteSQL("DELETE FROM TaiKhoan WHERE TenDN=@user", "Đã xóa!");
        }

        private void ExecuteSQL(string sql, string msg)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@user", txtTenDN.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txtMatKhau.Text.Trim());
                    cmd.Parameters.AddWithValue("@quyen", cbQuyen.Text);
                    cmd.Parameters.AddWithValue("@ma", cbMaNV.SelectedValue);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show(msg);
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];
                txtTenDN.Text = row.Cells["TenDN"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                cbQuyen.Text = row.Cells["Quyen"].Value.ToString();
                cbMaNV.SelectedValue = row.Cells["MaNV"].Value.ToString();
            }
        }

        private void btRead_Click(object sender, EventArgs e) => LoadData();
        private void btnExit_Click(object sender, EventArgs e) => this.Close();

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}