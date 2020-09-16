using Quản_Lý_Rượu.DAO;
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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            fMain main = new fMain();
            this.Hide();
            main.ShowDialog();
            this.Close();
            /*  if (login(username, password))
               {

               }
              else
               {
                   MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo");
               }*/
        }
        bool login(string username, string password)
        {
            return AccountDAO.Instance.login(username, password);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void fLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode.Equals(Keys.Enter))
                {
                    btnDangNhap_Click(null, null);
                }
            }

        }
    }
}
