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
    public partial class fTOPSP : Form
    {
        DataProvider data = new DataProvider();
        public fTOPSP()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string qr = "Select * from TOP3SP('" + txtMaKH.Text + "')";
            dtgvTOP.DataSource = data.ExecQuery(qr);
            lb1.Text = dtgvTOP.Rows[0].Cells[0].Value.ToString();
            lb2.Text = dtgvTOP.Rows[1].Cells[0].Value.ToString();
            lb3.Text = dtgvTOP.Rows[2].Cells[0].Value.ToString();
            lbSL1.Text = dtgvTOP.Rows[0].Cells[1].Value.ToString();
            lbSL2.Text = dtgvTOP.Rows[1].Cells[1].Value.ToString();
            lbSL3.Text = dtgvTOP.Rows[2].Cells[1].Value.ToString();
        }

        private void btnKhac_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            lbSL1.Text = "";
            lbSL2.Text = "";
            lbSL3.Text = "";
            lb1.Text = "";
            lb2.Text = "";
            lb3.Text = "";
        }
    }
}
