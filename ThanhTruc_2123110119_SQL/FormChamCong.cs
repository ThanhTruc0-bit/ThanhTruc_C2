using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ThanhTruc_2123110119_SQL
{
    public partial class FormChamCong : Form
    {
        // Nhớ đổi tên Server cho đúng với máy bạn
        string strConn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNhanVien;Integrated Security=True";
        int currentMaCong = -1;

        public FormChamCong()
        {
            InitializeComponent();
        }

        private void FormChamCong_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            LoadData();
            tbThang.Text = DateTime.Now.Month.ToString();
            tbNam.Text = DateTime.Now.Year.ToString();
        }

        private void LoadNhanVien()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT MaNV, HoTen FROM NhanVien", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cbMaNV.DataSource = dt;
                    cbMaNV.DisplayMember = "HoTen";
                    cbMaNV.ValueMember = "MaNV";
                }
            }
            catch { }
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    // Dùng JOIN để lấy được cả tên nhân viên cho bảng đẹp
                    string sql = @"SELECT cc.MaCong, cc.MaNV, nv.HoTen, cc.Thang, cc.Nam, cc.SoNgayCong 
                                   FROM ChamCong cc JOIN NhanVien nv ON cc.MaNV = nv.MaNV";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvChamCong.DataSource = dt;

                    // Đặt tên cột tiếng Việt
                    dgvChamCong.Columns["MaCong"].HeaderText = "ID";
                    dgvChamCong.Columns["MaNV"].HeaderText = "Mã NV";
                    dgvChamCong.Columns["HoTen"].HeaderText = "Tên NV";
                    dgvChamCong.Columns["Thang"].HeaderText = "Tháng";
                    dgvChamCong.Columns["Nam"].HeaderText = "Năm";
                    dgvChamCong.Columns["SoNgayCong"].HeaderText = "Ngày Công";
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải bảng: " + ex.Message); }
        }

        // Khi click vào bảng, đổ ngược dữ liệu lên các ô thông tin
        private void dgvChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvChamCong.Rows[e.RowIndex];
                currentMaCong = Convert.ToInt32(r.Cells["MaCong"].Value);

                tbMaCong.Text = currentMaCong.ToString(); // Hiện ID
                tbMaNV.Text = r.Cells["MaNV"].Value.ToString(); // Hiện Mã NV
                cbMaNV.SelectedValue = r.Cells["MaNV"].Value.ToString(); // Chọn đúng Tên
                tbThang.Text = r.Cells["Thang"].Value.ToString();
                tbNam.Text = r.Cells["Nam"].Value.ToString();
                numNgayCong.Value = Convert.ToDecimal(r.Cells["SoNgayCong"].Value);
            }
        }

        // Khi chọn Tên trong ComboBox, tự nhảy Mã NV vào ô TextBox
        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaNV.SelectedValue != null && cbMaNV.ValueMember != "")
            {
                tbMaNV.Text = cbMaNV.SelectedValue.ToString();
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    // Không chèn MaCong vì nó tự tăng (Identity)
                    string sql = "INSERT INTO ChamCong (MaNV, Thang, Nam, SoNgayCong) VALUES (@Ma, @T, @N, @S)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Ma", cbMaNV.SelectedValue);
                    cmd.Parameters.AddWithValue("@T", tbThang.Text);
                    cmd.Parameters.AddWithValue("@N", tbNam.Text);
                    cmd.Parameters.AddWithValue("@S", numNgayCong.Value);

                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: Không được thêm trùng Mã NV trong cùng 1 tháng!"); }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (currentMaCong == -1) { MessageBox.Show("Hãy chọn 1 dòng!"); return; }
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    // Sửa dựa trên ID (MaCong)
                    string sql = "UPDATE ChamCong SET SoNgayCong=@S, Thang=@T, Nam=@N WHERE MaCong=@ID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@S", numNgayCong.Value);
                    cmd.Parameters.AddWithValue("@T", tbThang.Text);
                    cmd.Parameters.AddWithValue("@N", tbNam.Text);
                    cmd.Parameters.AddWithValue("@ID", currentMaCong);

                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi cập nhật: " + ex.Message); }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (currentMaCong == -1) return;
            if (MessageBox.Show("Xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM ChamCong WHERE MaCong=@ID", conn);
                    cmd.Parameters.AddWithValue("@ID", currentMaCong);
                    cmd.ExecuteNonQuery();
                    LoadData();
                    btRead_Click(null, null);
                }
            }
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            currentMaCong = -1;
            tbMaCong.Clear();
            numNgayCong.Value = 0;
            LoadData();
        }

        private void btExit_Click(object sender, EventArgs e) => this.Close();
    }
}