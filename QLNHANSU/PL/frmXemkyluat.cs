using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace QLNHANSU.PL
{
    public partial class frmXemkyluat : Form
    {
        KhenThuong_KyLuatBLL bll = new KhenThuong_KyLuatBLL();
        public frmXemkyluat()
        {
            InitializeComponent();
        }

        private void frmXemkyluat_Load(object sender, EventArgs e)
        {
            for(int i = DateTime.Now.Year; i >= 2015; i--)
            {
                cbNam.Items.Add(i.ToString());
            }
            cbThang.Text = DateTime.Now.Month.ToString();
            cbNam.Text = DateTime.Now.Year.ToString();
            dgKhenthuong.DataSource = bll.LayDanhSachKyLuat();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            int Thang = int.Parse(cbThang.Text);
            int Nam = int.Parse(cbNam.Text);
            dgKhenthuong.DataSource = bll.LayDanhSachKyLuat(Thang, Nam);
        }
    }
}
