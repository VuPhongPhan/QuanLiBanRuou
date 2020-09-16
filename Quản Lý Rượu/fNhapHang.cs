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
    public partial class fNhapHang : Form
    {
        DataProvider data = new DataProvider();
        public fNhapHang()
        {
            InitializeComponent();
        }

        private void fNhapHang_Load(object sender, EventArgs e)
        {
            load();
        }
        private void load()
        {
            string query = "Select HDNhap.HDN, MaHH, SoLuong, MaNV, NgayNhap, MaNCC, DonGia, ThanhTien from ChiTietHDN join HDNhap on ChiTietHDN.HDN = HDNhap.HDN ";
            dtgvNhap.DataSource = data.ExecQuery(query);
            dtgvNhap.AutoResizeColumns();
            dtgvNhap.AutoResizeRows();
            dtgvNhap.Columns[6].Width = 160;
            dtgvNhap.Columns[7].Width = 170;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNhap_Click(object sender, EventArgs e)
        {

            if (kthh() == 1)
            {
                string query = "Insert into [dbo].[ChiTietHDN] values('" + txtHDN.Text + "','" + txtMaHH.Text + "'," + cbbSL.Text + "," +
                        "                                                  " + txtDonGia.Text + ", null," + txtTongTien.Text + ")";
                string query2 = "Insert into [dbo].[HDNhap] values('" + txtHDN.Text + "','" + txtMaNV.Text + "','" + dateTimePicker1.Text + "','"
                                                                          + cbbNCC.Text + "'," + txtTongTien.Text + ")";
                data.ExecQuery(query);
                dtgvNhap.DataSource = data.ExecQuery(query2);
                MessageBox.Show("Nhập thành công", "Thông báo");
                load();
                resert();
            }
        }
        int kthh()
        {
            int kt = 1;
            if (txtMaHH.TextLength == 0 || txtMaNV.TextLength == 0 || txtHDN.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
                kt = 0;
            }
            for (int i = 0; i < dtgvNhap.RowCount - 1; i++)
            {
                if (txtHDN.Text.Equals(dtgvNhap.Rows[i].Cells[0].Value.ToString().Trim()))
                {
                    kt = 0;
                    MessageBox.Show("Mã hóa đơn này đã có", "Thông báo");
                    break;
                }
            }
            return kt;
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            var id = dtgvNhap.SelectedCells[0].Value.ToString();
            string query = "Delete from [dbo].[ChiTietHDN] where HDN = '" + id + "'";
            string query2 = "Delete from [dbo].[HDNhap] where HDN = '" + id + "'";
            data.ExecQuery(query2);
            data.ExecQuery(query);
            MessageBox.Show("Xóa thành công", "Thông báo");
            load();
            resert();
        }

        private void cbbSL_SelectedIndexChanged(object sender, EventArgs e)
        {

            dtgvGia.DataSource = data.ExecQuery("select GiaNhap from DMHangHoa where MaHH = '" + txtMaHH.Text + "'");
            txtDonGia.Text = dtgvGia.Rows[0].Cells[0].Value.ToString();
            int gia = Convert.ToInt32(txtDonGia.Text);
            int thanhtien = gia * Convert.ToInt32(cbbSL.Text);
            txtTongTien.Text = thanhtien.ToString();
        }

        private void dtgvNhap_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /* DateTime date = Convert.ToDateTime(dtgvNhap[4, e.RowIndex].Value.ToString());  
             txtHDN.Text = dtgvNhap[0, e.RowIndex].Value.ToString();
             txtDonGia.Text = dtgvNhap[6, e.RowIndex].Value.ToString();
             txtMaHH.Text = dtgvNhap[1, e.RowIndex].Value.ToString();
             txtMaNV.Text = dtgvNhap[3, e.RowIndex].Value.ToString();
             cbbNCC.Text = dtgvNhap[5, e.RowIndex].Value.ToString();
             cbbSL.Text = dtgvNhap[2, e.RowIndex].Value.ToString();
             txtTongTien.Text = dtgvNhap[7, e.RowIndex].Value.ToString();
             dateTimePicker1.Text = date.ToString();*/
        }
        private void resert()
        {
            txtDonGia.Text = "";
            txtHDN.Text = "";
            txtMaHH.Text = "";
            txtMaNV.Text = "";
            txtTongTien.Text = "";
            cbbNCC.Text = "";
            cbbSL.Text = "";
            dateTimePicker1.Text = "";
        }
        private void btnMoi_Click(object sender, EventArgs e)
        {
            resert();
        }

        private void dtgvNhap_Click(object sender, EventArgs e)
        {
            try
            {
                btnXoa.Enabled = true;
                DateTime date = Convert.ToDateTime(dtgvNhap.CurrentRow.Cells[4].Value.ToString());
                txtHDN.Text = dtgvNhap.CurrentRow.Cells[0].Value.ToString();
                txtDonGia.Text = dtgvNhap.CurrentRow.Cells[6].Value.ToString();
                txtMaHH.Text = dtgvNhap.CurrentRow.Cells[1].Value.ToString();
                txtMaNV.Text = dtgvNhap.CurrentRow.Cells[3].Value.ToString();
                cbbNCC.Text = dtgvNhap.CurrentRow.Cells[5].Value.ToString();
                cbbSL.Text = dtgvNhap.CurrentRow.Cells[2].Value.ToString();
                txtTongTien.Text = dtgvNhap.CurrentRow.Cells[7].Value.ToString();
                dateTimePicker1.Text = date.ToString();
            }
            catch
            {
                MessageBox.Show("Không có mục bạn cần xem", "Thông báo");
            }
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Excel.ExportToExcelNhapHang excel = new Excel.ExportToExcelNhapHang();    
            
            DataTable dt = (DataTable)dtgvNhap.DataSource;

            excel.Export(dt, "Danh sach", "DANH SÁCH CÁC HÓA ĐƠN NHẬP");
        }

        private void cbbSL_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dtgvGia.DataSource = data.ExecQuery("select GiaNhap from DMHangHoa where MaHH = '" + txtMaHH.Text + "'");
            txtDonGia.Text = dtgvGia.Rows[0].Cells[0].Value.ToString();
            int gia = Convert.ToInt32(txtDonGia.Text);
            int thanhtien = gia * Convert.ToInt32(cbbSL.Text);
            txtTongTien.Text = thanhtien.ToString();
        }

        private void txtMaHH_TextChanged(object sender, EventArgs e)
        {
            cbbSL.Enabled = true;
        }
    }
}
