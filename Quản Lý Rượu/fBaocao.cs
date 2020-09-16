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
    public partial class fBaocao : Form
    {
        DataProvider data = new DataProvider();
        public fBaocao()
        {
            InitializeComponent();
        }
        private void Load()
        {
            string query = "Select YEAR(NgayBan) as N'Năm' ,sum(TongTien) as 'Doanh Thu' from HDBan group by YEAR(NgayBan)";

            dtgvDTyear.DataSource = data.ExecQuery(query);

            dtgvDTyear.AutoResizeColumns();
            dtgvDTyear.AutoResizeRows();

            dtgvDTyear.Columns[0].Width = 140;
            dtgvDTyear.Columns[1].Width = 138;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            btnPrint.Enabled = true;
            Load();
        }

        private void dtgvDTyear_Click(object sender, EventArgs e)
        {
            var nam = dtgvDTyear.SelectedCells[0].Value.ToString();

            loadMonth(nam);
        }
        private void loadMonth(string nam)
        {
            try
            {
                string query = "Select MONTH(NgayBan) as N'Tháng', sum(TongTien) as N'Doanh Thu' from HDBan where YEAR(NgayBan) = '" + nam + "' group by MONTH(NgayBan)";
                dtgvDTmonth.DataSource = data.ExecQuery(query);
                dtgvDTmonth.AutoResizeColumns();
                dtgvDTmonth.AutoResizeRows();

                dtgvDTmonth.Columns[1].Width = 100;
            }
            catch
            {
                MessageBox.Show("Hãy nhấn vào năm nếu bạn muốn xem doanh thu từng tháng", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXemSP_Click(object sender, EventArgs e)
        {
            btnIn.Enabled = true;
            string query = "select Top 3 TenHH as N'Tên Hàng Hóa', sum(ChiTietHDB.SoLuong) as N'Số Lượng' " +
                "from dbo.DMHangHoa join ChiTietHDB on DMHangHoa.MaHH = ChiTietHDB.MaHH join HDBan on ChiTietHDB.HDB = HDBan.HDB join KhachHang on KhachHang.MaKH = HDBan.MaKH " +
                "group by TenHH " +
                "order by sum(ChiTietHDB.SoLuong) desc";

            dtgvSP.DataSource = data.ExecQuery(query);

            dtgvSP.AutoResizeColumns();
            dtgvSP.AutoResizeRows();
            dtgvSP.Columns[0].Width = 400;
            dtgvSP.Columns[1].Width = 135;
        }

        private void btnThoatSP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ExportToExcelDoanhThu excel = new ExportToExcelDoanhThu();

            DataTable dt = (DataTable)dtgvDTyear.DataSource;

            excel.Export(dt, "Danh Sách", "Báo Cáo Doanh Thu Năm");
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ExportToExcelSanPham excel = new ExportToExcelSanPham();

            DataTable dt = (DataTable)dtgvSP.DataSource;

            excel.Export(dt, "Danh Sách", "Báo Cáo Sản Phẩm Bán Chạy");
        }
    }
}
