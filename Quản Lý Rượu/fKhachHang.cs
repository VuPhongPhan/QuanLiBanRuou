using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quản_Lý_Rượu.Excel;

namespace Quản_Lý_Rượu
{
    public partial class fKhachHang : Form
    {
        DataProvider data = new DataProvider();
        public fKhachHang()
        {
            InitializeComponent();
        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            string query = "Select * from [dbo].[KhachHang]";
            dtgvKH.DataSource = data.ExecQuery(query);
            dtgvKH.AutoResizeColumns();
            dtgvKH.AutoResizeRows();
            dtgvKH.Columns[1].Width = 250;
            dtgvKH.Columns[2].Width = 200;
            dtgvKH.Columns[3].Width = 210;

        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            btnResert.Enabled = true;
            string query = "select * from  [dbo].[KhachHang] where MaKH is not null ";
            if (txtMaKH.Text != "")
            {
                query += " and MaKH like N'" + txtMaKH.Text + "'";
            }
            if (txtTenKH.Text != "")
            {
                query += " and TenKH like N'" + txtTenKH.Text + "'";
            }
            if (txtSDT.Text != "")
            {
                query += " and SDT like N'" + txtSDT.Text + "'";
            }
            if (txtDiaChi.Text != "")
            {
                query += " and DiaChi like N'" + txtDiaChi.Text + "'";
            }
            dtgvKH.DataSource = data.ExecQuery(query);
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(checkkh() == 1)
            {
                if (txtMaKH.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo");
                    txtMaKH.Focus();
                }
                else if (txtTenKH.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Thông báo");
                    txtTenKH.Focus();
                }
                else
                {
                    dtgvKH.DataSource = data.ExecQuery("Insert into [dbo].[KhachHang]([MaKH], [TenKH], [Diachi], [SDT])values(N'"
                                                        + txtMaKH.Text + "', N'"
                                                        + txtTenKH.Text + "', N'"
                                                        + txtDiaChi.Text + "', N'"
                                                        + txtSDT.Text + "')");
                    MessageBox.Show("Thêm thành công!");
                    load();
                }
            }
            int checkkh()
            {
                int check = 1;
                for (int i = 0; i < dtgvKH.RowCount - 1; i++)
                {
                    if (txtMaKH.Text.Equals(dtgvKH.Rows[i].Cells[0].Value.ToString().Trim()))
                    {
                        check = 0;
                        MessageBox.Show("Mã khách hàng này đã có", "Thông báo");
                        break;
                    }
                }
                return check;
            }
        }
        public void resert()
        {
            txtDiaChi.Text = "";
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSDT.Text = "";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var id = dtgvKH.SelectedCells[0].Value.ToString();
            string query = "delete [dbo].[KhachHang] where MaKH = '" + id +"'";
            data.ExecQuery(query);
            MessageBox.Show("Xóa thành công!");
            load();
        }
        private void btnResert_Click(object sender, EventArgs e)
        {
            load();
            resert();
        }

        private void dtgvKH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           /* btnXoa.Enabled = true;
            txtMaKH.Text = dtgvKH[0, e.RowIndex].Value.ToString();
            txtTenKH.Text = dtgvKH[1, e.RowIndex].Value.ToString();
            txtDiaChi.Text = dtgvKH[2, e.RowIndex].Value.ToString();
            txtSDT.Text = dtgvKH[3, e.RowIndex].Value.ToString();*/
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = "Update [dbo].[KhachHang] set TenKH = N'" + txtTenKH.Text + "', DiaChi = N'" + txtDiaChi.Text + "', SDT = '" + txtSDT.Text
                                                                     + "' where MaKH = '" + txtMaKH.Text + "'";
            data.ExecQuery(query);
            load();
            resert();
            MessageBox.Show("Sửa thành công!", "Thông báo");
        }

        private void dtgvKH_Click(object sender, EventArgs e)
        {
            try
            {
                btnXoa.Enabled = true;
                txtMaKH.Text = dtgvKH.CurrentRow.Cells[0].Value.ToString();
                txtTenKH.Text = dtgvKH.CurrentRow.Cells[1].Value.ToString();
                txtDiaChi.Text = dtgvKH.CurrentRow.Cells[2].Value.ToString();
                txtSDT.Text = dtgvKH.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Thư mục rỗng", "Thông báo");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ExportToExcelKH excel = new ExportToExcelKH();

            DataTable dt = (DataTable)dtgvKH.DataSource;

            excel.Export(dt, "Danh sach", "DANH SÁCH KHÁCH HÀNG");
        }
    }
}
