using QLNHANSU.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNHANSU.DAL;
namespace QLNHANSU.PL
{
    public partial class frmSuaNhanVien : Form
    {
        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        PhongBanBLL phongBanBLL = new PhongBanBLL();
        LuongBLL luongBLL = new LuongBLL();
        NhanVien nhanVienSua = null;
        public frmSuaNhanVien()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSuaNhanVien_Load(object sender, EventArgs e)
        {
            numNamsinh.Maximum = DateTime.Now.Year;
            nhanVienSua = nhanVienBLL.DocNhanVienTheoMa(frmdsNhanvien.maNhanVienSua);
            if (nhanVienSua != null)
            {
                nhanVienSua.MaNV = frmdsNhanvien.maNhanVienSua;
                lblMessage.Text = "Thực hiện sửa nhân viên " + nhanVienSua.HoTenNV + " có mã " + nhanVienSua.MaNV;
                txtHoten.Text = nhanVienSua.HoTenNV;
                txtSDT.Text = nhanVienSua.SDT;
                rdoGioitinh.Checked = nhanVienSua.GioiTinhNV;
                txtDiachi.Text = nhanVienSua.DiaChiNV;
                txtDantoc.Text = nhanVienSua.DanToc;
                numNamsinh.Value = decimal.Parse(nhanVienSua.NamSinhNV.ToString());
                cbPhongban.DataSource = phongBanBLL.DocDanhSach();
                cbPhongban.DisplayMember = "TenPB";
                cbPhongban.ValueMember = "MaPB";
                cbPhongban.SelectedValue = nhanVienSua.MaPB;
                cbLuong.DataSource = luongBLL.DocDanhSach();
                cbLuong.DisplayMember = "MaLuong";
                cbLuong.ValueMember = "MaLuong";
                cbLuong.SelectedValue = nhanVienSua.MaLuong;
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi khi thực hiện tìm nhân viên muốn sửa");
                return;
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
           if(txtHoten.Text.Trim() == "")
           {
               MessageBox.Show("Vui lòng nhập họ tên nhân viên!");
               return;
           }
           else
           {
               try
               {
                   NhanVien nhanVien = new NhanVien()
                   {
                       MaNV = frmdsNhanvien.maNhanVienSua,
                       HoTenNV = txtHoten.Text,
                       SDT = txtSDT.Text,
                       GioiTinhNV = rdoGioitinh.Checked,
                       DiaChiNV = txtDiachi.Text,
                       DanToc = txtDantoc.Text,
                       NamSinhNV = int.Parse(numNamsinh.Value.ToString()),
                       MaLuong = int.Parse(cbLuong.Text),
                       MaPB = cbPhongban.SelectedValue.ToString()
                   };
                   int sodong = nhanVienBLL.SuaNhanVien(nhanVien);
                   if (sodong > 0)
                   {
                       MessageBox.Show("Sửa thành công.");
                       this.Close();
                   }
               }
               catch(Exception ex)
               {
                   MessageBox.Show("Xảy ra lỗi: " + ex.Message);
               }
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
