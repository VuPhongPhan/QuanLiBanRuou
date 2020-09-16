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
    public partial class fMain : Form
    {
        fBaocao bc = new fBaocao();
        fAccount acc = new fAccount();
        fLogin lg = new fLogin();
        fNhapHang nhaphang = new fNhapHang();
        fHDNhapMenu hdn = new fHDNhapMenu();
        fHDBanmenu hdb = new fHDBanmenu();
        fTOPSP top = new fTOPSP();
        fDoanhThu DT = new fDoanhThu();
        fNhanVien NV = new fNhanVien();
        fHangHoa HH = new fHangHoa();
        fKhachHang KH = new fKhachHang();
        fHoaDon HD = new fHoaDon();
        DataProvider Data = new DataProvider();
        public fMain()
        {
            InitializeComponent();
        }
        private void btnQuanLyRuou_Click(object sender, EventArgs e)
        {
            this.Hide();
            HH.ShowDialog();
            this.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            NV.ShowDialog();
            this.Show();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            this.Hide();
            KH.ShowDialog();
            this.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            HD.ShowDialog();
            this.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NV.ShowDialog();
            this.Show();
        }

        private void btnNSX_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình không", "Thông báo" , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HH.ShowDialog();
            this.Show();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            KH.ShowDialog();
            this.Show();
        }

        private void hóaĐơnToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HD.ShowDialog();
            this.Show();
        }
        private void doanhThuNămToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DT.ShowDialog(); 
            this.Show();
        }
        private void tOPSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            top.ShowDialog();
            this.Show();
        }
        private void thốngKếHDBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            hdb.ShowDialog();
            this.Show();
        }

        private void thốngKêHDNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            hdn.ShowDialog();
            this.Show();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            loadSP();
            loadHD();
        }
        private void loadSP()
        {
            string querySP = "Select MaHH, TenHH,GiaBan, Soluong from DMHangHoa";
            dtgvSP.DataSource = Data.ExecQuery(querySP);
            dtgvSP.AutoResizeColumns();
            dtgvSP.AutoResizeRows();
            dtgvSP.Columns[3].Width = 90;
        }
        private void loadHD()
        {
            string queryHH = "Select * from HDNhap";
            dtgvHD.DataSource = Data.ExecQuery(queryHH);
            dtgvHD.AutoResizeColumns();
            dtgvHD.AutoResizeRows();
            dtgvHD.Columns[2].Width = 165;
            dtgvHD.Columns[4].Width = 168;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string querySP = "select MaHH, TenHH,GiaBan, Soluong " +
                "from DMHangHoa join DoRuou on DMHangHoa.MaDo = DoRuou.MaDo " +
                "               join Loai on DMHangHoa.Maloai = Loai.Maloai  " +
                "               join NuocSX on DMHangHoa.MaNSX = NuocSX.MaNSX where MaHH is not null ";
            if (txtLoai.Text != "")
            {
                querySP += " and Tenloai = N'" + txtLoai.Text + "'";
            }
            if (txtDo.Text != "")
            {
                querySP += " and TenDo = N'" + txtDo.Text + "'";
            }
            if (txtNSX.Text != "")
            {
                querySP += " and TenNSX = N'" + txtNSX.Text + "'";
            }
            dtgvSP.DataSource = Data.ExecQuery(querySP);
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            resertSP();
            loadSP();
        }
        private void resertSP()
        {
            txtLoai.Text = "";
            txtDo.Text = "";
            txtNSX.Text = "";
        }

        private void btnTrolai_Click(object sender, EventArgs e)
        {
            loadHD();
            resertHD();
        }
        private void resertHD()
        {
            txtNCC.Text = "";
            txtDate.Text = ""; 
            txtMahh.Text = "";
        }

        private void btnTimHD_Click(object sender, EventArgs e)
        {
            string query = "Select HDNhap.HDN, MaNV, NgayNhap, NhaCungCap.MaNCC, TongTien from HDNhap join ChiTietHDN on HDNhap.HDN = ChiTietHDN.HDN " +
                "                                join DMHangHoa on ChiTietHDN.MaHH = DMHangHoa.MaHH " +
                "                                join NhaCungCap on NhaCungCap.MaNCC = HDNhap.MaNCC " +
                "                                where HDNhap.HDN is not null ";
            if (txtMahh.Text != "")
            {
                query += "  and ChiTietHDN.MaHH = N'" + txtMahh.Text + "'";
            }
            else if (txtNCC.Text != "")
            {
                query += " and TenNCC = N'" + txtNCC.Text + "'";
            }
            else if (Convert.ToDateTime(txtDate.Text) == DateTime.Now)
            {
                dtgvHD.DataSource = Data.ExecQuery(query);
            }
            else if(Convert.ToDateTime(txtDate.Text) != DateTime.Now)
            {
                query += " and NgayNhap = N'" + txtDate.Text + "'";
            }
            dtgvHD.DataSource = Data.ExecQuery(query);
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            nhaphang.ShowDialog();
            this.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            lg.ShowDialog();
            this.Close();
        }

        private void quảnLýLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            acc.ShowDialog();
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            bc.ShowDialog();
            this.Show();
        }
    }
}
