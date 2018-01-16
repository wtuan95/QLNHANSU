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
    public partial class frmXemchamcong : Form
    {
        ChamCongBLL chamcongBLL = new ChamCongBLL();
        public frmXemchamcong()
        {
            InitializeComponent();
        }
        public frmXemchamcong(string MaNV)
        {
            InitializeComponent();
            dgChamcong.DataSource = chamcongBLL.LayDanhSachTheoNhanVien(MaNV);

        }
    }
}
