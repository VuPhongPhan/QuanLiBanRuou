using System;
using System.Windows.Forms;
using Quản_Lý_Rượu.Excel;
using DataTable = System.Data.DataTable;

namespace Quản_Lý_Rượu
{
    public partial class fHoaDon : Form
    {
        DataProvider data = new DataProvider();
        public fHoaDon()
        {
            InitializeComponent();
        }

        private void fHoaDon_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            string query = "Select [dbo].[HDBan].HDB, MaNV, MaHH, MaKH, SoLuong, NgayBan, ThanhTien " +
                           "from [dbo].[HDBan] join [dbo].[ChiTietHDB] on [dbo].[HDBan].HDB = [dbo].[ChiTietHDB].HDB";
            dtgvHDB.DataSource = data.ExecQuery(query);
            //dtgvHDB.AutoResizeColumns();
            dtgvHDB.AutoResizeRows();
            dtgvHDB.Columns[5].Width = 150;
            dtgvHDB.Columns[6].Width = 160;
        }
        public void resert()
        {
            txtHDB.Text = "";
            txtMaKH.Text = "";
            txtNV.Text = "";
            txtTongtien.Text = "";
            txtSoluong.Text = "";
            txtMaHH.Text = "";
            txtNgayBan.Text = "";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            btnResert.Enabled = true;
            string query = "Select [dbo].[HDBan].HDB, MaNV, MaHH, MaKH, SoLuong, NgayBan, ThanhTien " +
                           "from [dbo].[HDBan] join [dbo].[ChiTietHDB] on [dbo].[HDBan].HDB = [dbo].[ChiTietHDB].HDB " +
                           "where [dbo].[HDBan].HDB is not null";
            if (txtMaKH.Text != "")
            {
                query += " and MaKH like N'" + txtMaKH.Text + "'";
            }
            if (txtHDB.Text != "")
            {
                query += " and [dbo].[HDBan].HDB like N'" + txtHDB.Text + "'";
            }
            if (txtNV.Text != "")
            {
                query += " and MaNV like N'" + txtNV.Text + "'";
            }
            if (txtMaHH.Text != "")
            {
                query += " and MaHH like N'" + txtMaHH.Text + "'";
            }
            if (txtTongtien.Text != "")
            {
                query += " and [TongTien] like N'" + txtTongtien.Text + "'";
            }
           /* if (txtNgayBan.Text != "")
            {
                query += " and NgayBan like N'" + txtNgayBan.Text + "'";
            }*/
            dtgvHDB.DataSource = data.ExecQuery(query);
           
            resert();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(checkhd() == 1)
            {
                if (txtHDB.Text == "")
                {
                    MessageBox.Show("Bạn chưa thêm mã hóa đơn", " Thông báo");
                    txtHDB.Focus();
                }
                else if (txtMaKH.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo");
                }
                else if (txtNV.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã nhân viên", "Thông báo");
                }
                else if (txtMaHH.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
                }
                else if (txtSoluong.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
                }
                else
                {
                    btnResert.Enabled = true;
                    data.ExecQuery("Insert into [dbo].[ChiTietHDB] values('" + txtHDB.Text + "','" + txtMaHH.Text + "',"
                                                         + txtSoluong.Text + ", NULL," + txtTongtien.Text + ")");
                    dtgvHDB.DataSource = data.ExecQuery("Insert into [dbo].[HDBan] values('" + txtHDB.Text + "','" + txtNV.Text + "','"
                                                         + txtNgayBan.Text + "', '" + txtMaKH.Text + "'," + txtTongtien.Text + ")");
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    load();
                    resert();
                }
            }
            int checkhd()
            {
                int check = 1;
                for (int i = 0; i < dtgvHDB.RowCount - 1; i++)
                {
                    if (txtHDB.Text.Equals(dtgvHDB.Rows[i].Cells[0].Value.ToString().Trim()))
                    {
                        check = 0;
                        MessageBox.Show("Mã hóa đơn này đã có", "Thông báo");
                        break;
                    }
                }
                return check;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResert_Click(object sender, EventArgs e)
        {
            resert();
            load();
        }

        private void dtgvHDB_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*btnXoa.Enabled = true;
            btnResert.Enabled = true;
            DateTime date = Convert.ToDateTime(dtgvHDB[5, e.RowIndex].Value.ToString());
            txtHDB.Text = dtgvHDB[0, e.RowIndex].Value.ToString();
            txtMaHH.Text = dtgvHDB[2, e.RowIndex].Value.ToString();
            txtMaKH.Text = dtgvHDB[3, e.RowIndex].Value.ToString();
            txtNgayBan.Text = date.ToString();
            txtNV.Text = dtgvHDB[1, e.RowIndex].Value.ToString();
            txtSoluong.Text = dtgvHDB[4, e.RowIndex].Value.ToString();
            txtTongtien.Text = dtgvHDB[6, e.RowIndex].Value.ToString();*/
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var id = dtgvHDB.SelectedCells[0].Value.ToString();
            data.ExecQuery("Delete from HDBan where HDB = '" + id + "'");
            data.ExecQuery("Delete from ChiTietHDB where HDB = '" + id + "'");
            MessageBox.Show("Xóa thành công", "Thông báo");
            resert();
            load();
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = "Update ChiTietHDB set MaHH = '" + txtMaHH.Text + "',SoLuong = " + txtSoluong.Text + " where HDB = '" + txtHDB.Text + "'";
            string query2 = "Update HDBan set MaNV = '" + txtNV.Text + "',NgayBan = '" + txtNgayBan.Text + "',MaKH = '" + txtMaKH.Text + "' where HDB = '" + txtHDB.Text + "'";
            data.ExecQuery(query);
            data.ExecQuery(query2);
            MessageBox.Show("Sửa thành công", "Thông báo");
            load();
        }
        private void txtSoluong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSoluong.Text == "")
            {
               
            }
            else
            {
                string query = "Select GiaBan from DMHangHoa where MaHH = '" + txtMaHH.Text + "'";

                dtgvThanhTien.DataSource = data.ExecQuery(query);

                txtmoney.Text = dtgvThanhTien.Rows[0].Cells[0].Value.ToString();

                int tien = Convert.ToInt32(txtSoluong.Text) * Convert.ToInt32(txtmoney.Text);

                txtTongtien.Text = tien.ToString();
            }
        }
        private void dtgvHDB_Click(object sender, EventArgs e)
        {
            try
            {
                btnXoa.Enabled = true;
                btnResert.Enabled = true;
                DateTime date = Convert.ToDateTime(dtgvHDB.CurrentRow.Cells[5].Value.ToString());
                txtHDB.Text = dtgvHDB.CurrentRow.Cells[0].Value.ToString();
                txtMaHH.Text = dtgvHDB.CurrentRow.Cells[2].Value.ToString();
                txtMaKH.Text = dtgvHDB.CurrentRow.Cells[3].Value.ToString();
                txtNgayBan.Text = date.ToString();
                txtNV.Text = dtgvHDB.CurrentRow.Cells[1].Value.ToString();
                txtSoluong.Text = dtgvHDB.CurrentRow.Cells[4].Value.ToString();
                txtTongtien.Text = dtgvHDB.CurrentRow.Cells[6].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Thư mục rỗng", "Thông báo");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ExportToExcelHDBan excel = new ExportToExcelHDBan();

            DataTable dt = (DataTable)dtgvHDB.DataSource;

            excel.Export(dt, "Danh sach", "DANH SÁCH CÁC HÓA ĐƠN");
        }

        private void txtSoluong_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (txtSoluong.Text == "")
            {

            }
            else
            {
                string query = "Select GiaBan from DMHangHoa where MaHH = '" + txtMaHH.Text + "'";

                dtgvThanhTien.DataSource = data.ExecQuery(query);

                txtmoney.Text = dtgvThanhTien.Rows[0].Cells[0].Value.ToString();

                int tien = Convert.ToInt32(txtSoluong.Text) * Convert.ToInt32(txtmoney.Text);

                txtTongtien.Text = tien.ToString();
            }
        }

        private void txtMaHH_TextChanged(object sender, EventArgs e)
        {
            txtSoluong.Enabled = true;
        }
    }
}
