using QLNHANSU.BLL;
using QLNHANSU.DAL;
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
    public partial class frmThemNhanvien : Form
    {
        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        LuongBLL luongBLL = new LuongBLL();
        PhongBanBLL phongBanBLL = new PhongBanBLL();
        public frmThemNhanvien()
        {
            InitializeComponent();
        }

        private void frmThemNhanvien_Load(object sender, EventArgs e)
        {
            txtMaNV.Focus();
            numNamsinh.Maximum = DateTime.Now.Year;
            cbPhongban.DataSource = phongBanBLL.DocDanhSach();
            cbPhongban.DisplayMember = "TenPB";
            cbPhongban.ValueMember = "MaPB";
            cbLuong.DataSource = luongBLL.DocDanhSach();
            cbLuong.DisplayMember = "MaLuong";
            cbLuong.ValueMember = "MaLuong";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên.");
                return;
            }
            if(txtHoten.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên.");
                return;
            }
            try
            {
            NhanVien nhanVienMoi = new NhanVien()
            {
                MaNV = txtMaNV.Text,
                HoTenNV = txtHoten.Text,
                GioiTinhNV = rdoGioitinh.Checked,
                NamSinhNV = int.Parse(numNamsinh.Value.ToString()),
                DanToc = txtDantoc.Text,
                DiaChiNV = txtDiachi.Text,
                SDT = txtSDT.Text,
                MaPB = cbPhongban.SelectedValue.ToString(),
                MaLuong = int.Parse(cbLuong.Text)
            };
            
                int dong = nhanVienBLL.ThemNhanVien(nhanVienMoi);
                if (dong == 1)
                {
                    MessageBox.Show("Thêm thành công.");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            Luong luong = luongBLL.DocLuongTheoMa(int.Parse(cbLuong.Text));
            StringBuilder strb = new StringBuilder("Chức vụ: " + luong.ChucVu + "\r\n");
            strb.AppendLine("Lương căn bản: " + luong.LuongCanBan.ToString("#,##0 đồng"));
            strb.AppendLine("Hệ số: " + luong.HeSoLuong.ToString());
            strb.AppendLine("Phụ cấp: " + luong.PhuCap.ToString("#,##0 đồng"));
            MessageBox.Show(strb.ToString());
        }
    }
}
