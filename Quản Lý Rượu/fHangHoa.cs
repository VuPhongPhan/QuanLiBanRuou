using Quản_Lý_Rượu.Excel;
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
    public partial class fHangHoa : Form
    {
        DataProvider data = new DataProvider();
        public fHangHoa()
        {
            InitializeComponent();
        }

        private void fHangHoa_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            string query = "Select * from [dbo].[DMHangHoa]";
            dtgvHH.DataSource = data.ExecQuery(query);
            dtgvHH.AutoResizeRows();
            dtgvHH.AutoResizeColumns();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            string query = "Select * from [dbo].[DMHangHoa] where MaHH is not null";
            if (txtMaHH.Text != "")
            {
                query += " and MaHH like N'" + txtMaHH.Text + "'";
            }
            if (txtTenHH.Text != "")
            {
                query += " and TenHH like N'" + txtTenHH.Text + "'";
            }
            if (txtNSX.Text != "")
            {
                query += " and MaNSX like N'" + txtNSX.Text + "'";
            }
            if (txtMaCD.Text != "")
            {
                query += " and MaCD like N'" + txtMaCD.Text + "'";
            }
            if (txtMaDL.Text != "")
            {
                query += " and MaDL like N'" + txtMaDL.Text + "'";
            }
            if (txtMaDo.Text != "")
            {
                query += " and MaDo like N'" + txtMaDo.Text + "'";
            }
            if (txtMaHD.Text != "")
            {
                query += " and MaHD like N'" + txtMaHD.Text + "'";
            }
            if (txtMaHH.Text != "")
            {
                query += " and MaHH like N'" + txtMaHH.Text + "'";
            }
            if (txtMaLoai.Text != "")
            {
                query += " and Maloai like N'" + txtMaLoai.Text + "'";
            }
            if (txtMaMS.Text != "")
            {
                query += " and MaMS like N'" + txtMaMS.Text + "'";
            }
            dtgvHH.DataSource = data.ExecQuery(query);
            resert();
            btnResert.Enabled = true;
        }
        private void resert()
        {
            txtGhiChu.Text = "";
            txtGiaban.Text = "";
            txtGiaNhap.Text = "";
            txtMaCD.Text = "";
            txtMaDL.Text = "";
            txtMaDo.Text = "";
            txtMaHD.Text = "";
            txtMaHH.Text = "";
            txtMaLoai.Text = "";
            txtMaMS.Text = "";
            txtNSX.Text = "";
            txtSoluong.Text = "";
            txtTenHH.Text = "";
            txtCL.Text = "";
        }

        private void btnResert_Click(object sender, EventArgs e)
        {
            load();
            resert();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            fChiTietHH CT = new fChiTietHH();
            CT.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkhh() == 1)
            {
                if (txtCL.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
                }
                if (txtMaCD.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
                }
                if (txtMaDL.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
                }
                if (txtMaDo.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
                }
                if (txtMaHD.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
                }
                if (txtMaHH.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
                }
                if (txtMaLoai.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
                }
                if (txtMaMS.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
                }
                if (txtNSX.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
                }
                string query = "Insert into [dbo].[DMHangHoa] values('" + txtMaHH.Text + "',N'" + txtTenHH.Text + "','" + txtMaDL.Text + "','"
                                                                + txtMaCD.Text + "','" + txtCL.Text + "','" + txtMaLoai.Text + "','"
                                                                + txtMaHD.Text + "','" + txtMaDo.Text + "','" + txtMaMS.Text + "','"
                                                                + txtNSX.Text + "','" + txtSoluong.Text + "','" + txtGiaNhap.Text + "','"
                                                                + txtGiaban.Text + "',null,N'" + txtGhiChu.Text + "')";
                data.ExecQuery(query);
                resert();
                load();
            }

            int checkhh()
            {
                int check = 1;
                for (int i = 0; i < dtgvHH.RowCount - 1; i++)
                {
                    if (txtMaHH.Text.Equals(dtgvHH.Rows[i].Cells[0].Value.ToString().Trim()))
                    {
                        check = 0;
                        MessageBox.Show("Mã hàng hóa này đã có", "Thông báo");
                        break;
                    }
                }
                return check;
            }
        }

        private void dtgvHH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           /* btnXoa.Enabled = true;
            txtMaHH.Text = dtgvHH[0, e.RowIndex].Value.ToString();
            txtCL.Text = dtgvHH[4, e.RowIndex].Value.ToString();
            txtGhiChu.Text = dtgvHH[14, e.RowIndex].Value.ToString();
            txtGiaban.Text = dtgvHH[12, e.RowIndex].Value.ToString();
            txtGiaNhap.Text = dtgvHH[11, e.RowIndex].Value.ToString();
            txtMaCD.Text = dtgvHH[3, e.RowIndex].Value.ToString();
            txtMaDL.Text = dtgvHH[2, e.RowIndex].Value.ToString();
            txtMaDo.Text = dtgvHH[7, e.RowIndex].Value.ToString();
            txtMaHD.Text = dtgvHH[6, e.RowIndex].Value.ToString();
            txtMaLoai.Text = dtgvHH[5, e.RowIndex].Value.ToString();
            txtMaMS.Text = dtgvHH[8, e.RowIndex].Value.ToString();
            txtNSX.Text = dtgvHH[9, e.RowIndex].Value.ToString();
            txtSoluong.Text = dtgvHH[10, e.RowIndex].Value.ToString();
            txtTenHH.Text = dtgvHH[1, e.RowIndex].Value.ToString();*/

           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var id = dtgvHH.SelectedCells[0].Value.ToString();
            string qr = "Delete from [dbo].[DMHangHoa] where MaHH = '" + id + "'";
            data.ExecQuery(qr);
            load();
            resert();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
         //   [MaHH][TenHH][MaDL][MaCD][MaCL][Maloai][MaHD][MaDo][MaMS][MaNSX][Soluong][GiaNhap][GiaBan][Anh][GhiChu]
            string qr = "Update [dbo].[DMHangHoa] set TenHH = N'" + txtTenHH.Text + "',MaDL = '" 
                + txtMaDL.Text + "',MaCD = '" + txtMaCD.Text + "',MaCL = '" + txtCL.Text + "',Maloai = '" + txtMaLoai.Text 
                + "',MaHD = '" + txtMaHD.Text + "',MaDo = '" + txtMaDo.Text + "',MaMS = '" + txtMaMS.Text + "',MaNSX = '" + txtNSX.Text
                + "',Soluong = " + txtSoluong.Text + ",GiaNhap = " + txtGiaNhap.Text + ",GiaBan = " + txtGiaban.Text 
                + ",GhiChu = N'" + txtGhiChu.Text + "' where MaHH = '" + txtMaHH.Text + "'";
            data.ExecQuery(qr);
            load();
            resert();
    }

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {
            if (txtGiaNhap.Text == "")
            {
                txtGiaban.Text = "";
            }
            else
            {
                        double gia = Convert.ToInt32(txtGiaNhap.Text) * 1.1;
                        txtGiaban.Text = gia.ToString();
            }
        }

        private void dtgvHH_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            txtMaHH.Text = dtgvHH.CurrentRow.Cells[0].Value.ToString();
            txtCL.Text = dtgvHH.CurrentRow.Cells[4].Value.ToString();
            txtGhiChu.Text = dtgvHH.CurrentRow.Cells[14].Value.ToString();
            txtGiaban.Text = dtgvHH.CurrentRow.Cells[12].Value.ToString();
            txtGiaNhap.Text = dtgvHH.CurrentRow.Cells[11].Value.ToString();
            txtMaCD.Text = dtgvHH.CurrentRow.Cells[3].Value.ToString();
            txtMaDL.Text = dtgvHH.CurrentRow.Cells[2].Value.ToString();
            txtMaDo.Text = dtgvHH.CurrentRow.Cells[7].Value.ToString();
            txtMaHD.Text = dtgvHH.CurrentRow.Cells[6].Value.ToString();
            txtMaLoai.Text = dtgvHH.CurrentRow.Cells[5].Value.ToString();
            txtMaMS.Text = dtgvHH.CurrentRow.Cells[8].Value.ToString();
            txtNSX.Text = dtgvHH.CurrentRow.Cells[9].Value.ToString();
            txtSoluong.Text = dtgvHH.CurrentRow.Cells[10].Value.ToString();
            txtTenHH.Text = dtgvHH.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportToExcelHH excel = new ExportToExcelHH();
            // Lấy về nguồn dữ liệu cần Export là 1 DataTable
            // DataTable này mỗi bạn lấy mỗi khác. 
            // Ở đây tôi dùng BindingSouce có tên bs nên tôi ép kiểu như sau:
            // Bạn nào gán trực tiếp vào DataGridView thì ép kiểu DataSource của
            // DataGridView nhé 
            DataTable dt = (DataTable)dtgvHH.DataSource;
            excel.Export(dt, "Danh sach", "DANH SÁCH HÀNG HÓA");
        }
    }
}
