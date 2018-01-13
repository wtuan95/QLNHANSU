﻿using System;
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
            frmdsNhanvien frm = new frmdsNhanvien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thongtinPhanMemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tên phần mềm: Phần mềm quản lý nhân sự version 1.0\r\nTác giả: tên tác giả\r\nNăm phát hành: 06/2016");
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoimatkhau frm = new frmDoimatkhau();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
