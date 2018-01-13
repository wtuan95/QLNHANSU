using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNHANSU.BLL;
namespace QLNHANSU.PL
{
    public partial class frmDangNhap : Form
    {
        public static string taikhoan = null;
        public static string matkhau = null;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmKetNoi frm = new frmKetNoi();
            frm.Show();
        }

        private void picDangnhap_Click(object sender, EventArgs e)
        {
            AdminBLL adminBLL = new AdminBLL();
            if(txtdangnhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản.");
                return;
            }
            if(txtmatkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.");
                return;
            }
            if(adminBLL.KiemTraDangNhap(txtdangnhap.Text, txtmatkhau.Text))
            {
                taikhoan = txtdangnhap.Text;
                matkhau = txtmatkhau.Text;
                frmMenu frm = new frmMenu();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Sai thông tin đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtdangnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                picDangnhap_Click(sender, e);
            }
        }

        private void txtmatkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                picDangnhap_Click(sender, e);
            }
        }
    }
}
