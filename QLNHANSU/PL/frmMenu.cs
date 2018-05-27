using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNHANSU.PL
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanlynhanvien frm = new frmQuanlynhanvien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thongtinPhanMemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tên phần mềm: Phần mềm quản lý nhân sự version 1.0\r\nTác giả: tên tác giả\r\nNăm phát hành: 06/2016");
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoimatkhau frm = new frmDoimatkhau();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanlyphongban frm = new PL.frmQuanlyphongban();
            frm.MdiParent = this;
            frm.Show();
        }

        private void chấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChamcong frm = new PL.frmChamcong();
            frm.MdiParent = this;
            frm.Show();
        }

        private void xemDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXemkhenthuong frm = new frmXemkhenthuong();
            frm.Show();
        }

        private void xemDanhSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmXemkyluat frm = new frmXemkyluat();
            frm.Show();
        }

        private void bổSungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBoSungKhenThuong_KyLuat frm = new frmBoSungKhenThuong_KyLuat(1);  // gia tri 1 là khen thưởng
            frm.MdiParent = this;
            frm.Show();
        }

        private void thôngTinCôngTyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongtincongty frm = new frmThongtincongty();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
