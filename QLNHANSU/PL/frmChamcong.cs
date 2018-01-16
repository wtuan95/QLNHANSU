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
                    ChamCong model = new ChamCong()
                    {
                        MaNV = MaNV,
                        Thang = int.Parse(cbThang.Text),
                        Nam = int.Parse(cbNam.Text),
                        SoNgayLam = (int)numSongaylam.Value,
                        LuongNhan = (int)numLuong.Value,
                        TaiKhoanCham = string.IsNullOrEmpty(frmDangNhap.taikhoan) ? "admin" : frmDangNhap.taikhoan,
                        NgayCham = DateTime.Now
                    };
                    chamcongBLL.ThemChamCong(model);
                    MessageBox.Show("Lưu thành công");
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

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhLuong();
        }

        private void numSongaylam_ValueChanged(object sender, EventArgs e)
        {
            TinhLuong();
        }

        private void txtTennhanvien_TextChanged(object sender, EventArgs e)
        {
            TinhLuong();
        }
        void  TinhLuong()
        {
            if (txtTennhanvien.Text != "" && txtTennhanvien.Text.IndexOf('(') != -1 && txtTennhanvien.Text.IndexOf(')') != -1)
            {
                try
                {
                    string MaNV = txtTennhanvien.Text.Substring(txtTennhanvien.Text.IndexOf('(') + 1);
                    MaNV = MaNV.Remove(MaNV.Length - 1);
                    decimal luong = chamcongBLL.TinhLuong(MaNV, (int)numSongaylam.Value);
                    numLuong.Value = luong;
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
    }
}
