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
    public partial class frmDoimatkhau : Form
    {
        public frmDoimatkhau()
        {
            InitializeComponent();
        }

        private void picDoimatkhau_Click(object sender, EventArgs e)
        {
            if(txtmkhientai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu hiện tại.");
                return;
            }

            if(txtmatkhaumoi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới.");
                return;
            }
            else
            {
                if(txtmkhientai.Text != frmDangNhap.matkhau)
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng.");
                    return;
                }
                if(txtnhaplaimkmoi.Text != txtmatkhaumoi.Text)
                {
                    MessageBox.Show("Nhập lại mật khẩu không khớp.");
                    return;
                }
                else
                {
                    AdminBLL adminBLL = new AdminBLL();
                    if(adminBLL.DoiMatKhau(frmDangNhap.taikhoan, txtmatkhaumoi.Text) == 1)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công. Bạn sẽ phải thực hiện đăng nhập lại ngay bây giờ.");
                        Application.Restart();
                    }

                }
            }
        }
    }
}
