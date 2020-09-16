using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Rượu
{
    public partial class fAccount : Form
    {
        DataProvider data = new DataProvider(); 
        public fAccount()
        {
            InitializeComponent();
        }

        private void fAccount_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            string query = "Select [TaiKhoan] as N'Tài khoản',[TenHienThi] as N'Tên hiện thị',[ChucVu] as N'Chức vụ' from tblDangNhap";
            dtgvAccount.DataSource = data.ExecQuery(query);
            dtgvAccount.AutoResizeColumns();
            dtgvAccount.AutoResizeRows();
            dtgvAccount.Columns[2].Width = 98;
        }

        private void dtgvAccount_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*txtUsername.Text = dtgvAccount[0, e.RowIndex].Value.ToString();
            txtTenhienthi.Text = dtgvAccount[1, e.RowIndex].Value.ToString();
            txtChucvu.Text = dtgvAccount[2, e.RowIndex].Value.ToString();*/
        }

       
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa tài khoản này không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                var id = dtgvAccount.SelectedCells[0].Value.ToString();
                data.ExecQuery("Delete from tblDangNhap where [TaiKhoan] = '" + id + "'");
                MessageBox.Show("Xóa thành công", "Thông báo");
                load();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = "Update tblDangNhap set " +
                           "[TenHienThi] = N'" + txtTenhienthi.Text + "',[ChucVu] = N'" + txtChucvu.Text + "'" +
                           " where [TaiKhoan] = '" + txtUsername.Text + "'";
            dtgvAccount.DataSource = data.ExecQuery(query);
            load();
            MessageBox.Show("Sửa thành công", "Thông báo");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMK.Text != txtReMK.Text)
            {
                MessageBox.Show("Mật khẩu không trùng nhau", "Thông báo");
                txtMK.Focus();
            }
            else
            {
                string query = "Insert into tblDangNhap values" +
                    "('" + txtTenDN.Text + "','" + txtMK.Text + "',N'" + cbbChucVu.Text + "',N'" + txtTenHT.Text + "')";
                data.ExecQuery(query);
                resert();
                load();
                MessageBox.Show("Thêm tài khoản thành công");
            }
        }

        private void resert()
        {
            txtTenHT.Text = "";
            txtTenDN.Text = "";
            txtMK.Text = "";
            txtReMK.Text = "";
            cbbChucVu.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "Select TaiKhoan from tblDangNhap where TaiKhoan = '" + txtTenTK.Text + "'";
            string query2 = "Select MatKhau from tblDangNhap where TaiKhoan = '" + txtTenTK.Text + "'";
            dtgvTK.DataSource = data.ExecQuery(query);
            dtgvMK.DataSource = data.ExecQuery(query2);
            string tk = dtgvTK.Rows[0].Cells[0].Value.ToString();
            string mk = dtgvMK.Rows[0].Cells[0].Value.ToString();
            if(txtTenTK.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản", "Thông báo");
            }
            else if(txtMKmoi.Text != txtReMKnew.Text)
            {
                MessageBox.Show("Mật khẩu không giống nhau", "Thông báo");
            }
            else if(txtMKcu.Text != mk)
            {
                MessageBox.Show("Bạn nhập sai mật khẩu tài khoản", "Thông báo");
            }
            else
            { 
                dtgvAccount.DataSource = data.ExecQuery("Update tblDangNhap set MatKhau = '" + txtMKmoi.Text + "' where TaiKhoan = '" + txtTenTK.Text + "'");
                MessageBox.Show("Bạn đã đổi mật khẩu thành công", "Thông báo");
                load();
            }
        }
        private void dtgvAccount_Click(object sender, EventArgs e)
        {
            try
            {
                txtUsername.Text = dtgvAccount.CurrentRow.Cells[0].Value.ToString();
                txtTenhienthi.Text = dtgvAccount.CurrentRow.Cells[1].Value.ToString();
                txtChucvu.Text = dtgvAccount.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Thư mục rỗng", "Thông báo");
            }
        }
    }
}
