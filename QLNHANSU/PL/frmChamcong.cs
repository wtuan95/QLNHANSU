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
using DTO;
namespace QLNHANSU.PL
{
    public partial class frmChamcong : Form
    {
        ChamCongBLL chamcongBLL = new ChamCongBLL();
        public frmChamcong()
        {
            InitializeComponent();
        }

        private void frmChamcong_Load(object sender, EventArgs e)
        {
            try
            {
                NhanVienBLL nhanvienBLL = new NhanVienBLL();
                AutoCompleteStringCollection autocomplete = new AutoCompleteStringCollection();
                autocomplete.AddRange(nhanvienBLL.DocDanhSach().Select(m => m.HoTen + "  (" + m.MaNV + ")").ToArray());
                txtTennhanvien.AutoCompleteCustomSource = autocomplete;
                cbThang.Text = DateTime.Now.Month.ToString();
                cbNam.Text = DateTime.Now.Year.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        private void lblXemchamcong_Click(object sender, EventArgs e)
        {
            if (txtTennhanvien.Text != "")
            {
                try
                {
                    string MaNV = txtTennhanvien.Text.Substring(txtTennhanvien.Text.IndexOf('(') + 1);
                    MaNV = MaNV.Remove(MaNV.Length - 1);
                    frmXemchamcong frm = new frmXemchamcong(MaNV);
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTennhanvien.Text != "")
            {
                try
                {
                    string MaNV = txtTennhanvien.Text.Substring(txtTennhanvien.Text.IndexOf('(') + 1);
                    MaNV = MaNV.Remove(MaNV.Length - 1);
                    if (chamcongBLL.KiemTraTonTai(MaNV, int.Parse(cbThang.Text), int.Parse(cbNam.Text)) == true)
                    {
                        DialogResult result = MessageBox.Show("Bạn đã chấm công tháng này cho nhân viên này rồi. Bạn có muốn xóa chấm công cũ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            chamcongBLL.XoaChamCong(MaNV, int.Parse(cbThang.Text), int.Parse(cbNam.Text));
                        }
                        else
                            return;
                    }
                   string LuongNhan = txtLuongNhan.Text.Replace(".", "").ToString();
                  
                    ChamCong model = new ChamCong()
                    {
                        MaNV = MaNV,
                        Thang = int.Parse(cbThang.Text),
                        Nam = int.Parse(cbNam.Text),
                        SoNgayLam = (int)numSongaylam.Value,
                        HeSoLuong = (float)numHesoluong.Value,
                        DaTraTruoc = (int)numDatratruoc.Value,
                        PhuCapThang = (int)numPhucapthang.Value,
                        LuongNhan = int.Parse(LuongNhan),
                        TaiKhoanCham = frmDangNhap.taikhoan,
                        NgayCham = DateTime.Now
                    };
                    chamcongBLL.ThemChamCong(model);
                    MessageBox.Show("Lưu thành công");
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTinhluong_Click(object sender, EventArgs e)
        {
            if(txtTennhanvien.Text != "")
            {
                try
                {
                    string MaNV = txtTennhanvien.Text.Substring(txtTennhanvien.Text.IndexOf('(') + 1);
                    MaNV = MaNV.Remove(MaNV.Length - 1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void  TinhLuong()
        {
            if (txtTennhanvien.Text != "" && txtTennhanvien.Text.IndexOf('(') != -1 && txtTennhanvien.Text.IndexOf(')') != -1)
            {
                try
                {
                    KhenThuong_KyLuatBLL khenthuongkyluatBLL = new KhenThuong_KyLuatBLL();
                    string MaNV = txtTennhanvien.Text.Substring(txtTennhanvien.Text.IndexOf('(') + 1);
                    MaNV = MaNV.Remove(MaNV.Length - 1);
                    NhanVien model = new NhanVienBLL().DocNhanVienTheoMa(MaNV);
                    txtManhanvien.Text = MaNV;
                    txtLuongcoban.Text = new ChucVuBLL().LayLuongCoBan(model.MaCV).ToString("#,##0").Replace(',','.') + " VNĐ";
                    int PhuCapThang = (int)numPhucapthang.Value;
                    int DaTraTruoc = (int)numDatratruoc.Value;
                    float HeSoLuong = (float)numHesoluong.Value;
                    int Thang = int.Parse(cbThang.Text);
                    int Nam = int.Parse(cbNam.Text);
                    int TienKhenThuong = khenthuongkyluatBLL.LayTongTienKhenThuong(MaNV, Thang, Nam);
                    txtTienkhenthuong.Text = TienKhenThuong.ToString("#,##0").Replace(',', '.') + " VNĐ";
                    int TienKyLuat = khenthuongkyluatBLL.LayTongTienKyLuat(MaNV, Thang, Nam);
                    txtTienkyluat.Text = TienKyLuat.ToString("#,##0").Replace(',', '.') + " VNĐ";
                    int luongNhan = chamcongBLL.TinhLuong(MaNV, (int)numSongaylam.Value,PhuCapThang, DaTraTruoc, HeSoLuong, TienKhenThuong, TienKyLuat);
                    txtLuongNhan.Text = luongNhan.ToString("#,##0").Replace(',', '.');
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void numSongaylam_KeyUp(object sender, KeyEventArgs e)
        {
            TinhLuong();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void valueNumChanged(object sender, EventArgs e)
        {
            TinhLuong();
        }
    }
}
