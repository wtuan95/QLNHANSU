using System;
using System.Data;
using System.Windows.Forms;
using QLNHANSU.BLL;
using QLNHANSU.DAL;
using System.Collections.Generic;
using System.Text;
namespace QLNHANSU.PL
{
    public partial class frmdsNhanvien : Form
    {
        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        PhongBanBLL phongBanBLL = new PhongBanBLL();
        public static string maNhanVienSua;
        public frmdsNhanvien()
        {
            InitializeComponent();
        }
        void HienThiDuLieu(List<NhanVien> dsNhanVien)
        {
            lvDsnhanvien.Items.Clear();
            foreach(NhanVien nv in dsNhanVien)
            {
                ListViewItem item = new ListViewItem(nv.MaNV);
                item.SubItems.Add(nv.HoTenNV);
                item.SubItems.Add(nv.GioiTinhNV == true ? "Nam" : "Nữ");
                item.SubItems.Add(nv.NamSinhNV.ToString());
                item.SubItems.Add(nv.DanToc);
                item.SubItems.Add(nv.DiaChiNV);
                item.SubItems.Add(nv.SDT);
                item.SubItems.Add(nv.MaPB);
                item.SubItems.Add(nv.MaLuong.ToString());
                lvDsnhanvien.Items.Add(item);
            }
        }
        public bool KiemTraDuLieu()
        {
            return lblManhanvien.Text != "" && lblHoten.Text != "";
        }
        private void frmdsNhanvien_Load(object sender, EventArgs e)
        {
            List<NhanVien> dsNhanVien = nhanVienBLL.DocDanhSach();
            HienThiDuLieu(dsNhanVien);
        }


        private void lvDsnhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvDsnhanvien.SelectedItems.Count > 0)
            {
                ListViewItem itemselected = lvDsnhanvien.SelectedItems[0];
                lblManhanvien.Text = itemselected.SubItems[0].Text;
                lblHoten.Text = itemselected.SubItems[1].Text;
                lblGioiTinh.Text = itemselected.SubItems[2].Text;
                lblNamsinh.Text = itemselected.SubItems[3].Text;
                lblDantoc.Text = itemselected.SubItems[4].Text;
                lblDiachi.Text = itemselected.SubItems[5].Text;
                lblSDT.Text = itemselected.SubItems[6].Text;
                lblPhongban.Text = phongBanBLL.GetTenPhong(itemselected.SubItems[7].Text);
                lblLuong.Text = itemselected.SubItems[8].Text;
               
            }
            
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHotentim_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<NhanVien> ketQuaTimKiem = nhanVienBLL.TimNhanVienTheoTen(txtHotentim.Text);
            HienThiDuLieu(ketQuaTimKiem);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lvDsnhanvien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên muốn xóa!", "Thông báo");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên " + lblHoten.Text + " không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == System.Windows.Forms.DialogResult.Yes)
                {
                    int sodong = nhanVienBLL.XoaNhanVien(lblManhanvien.Text);
                    if(sodong == 1)
                    {
                        MessageBox.Show("Xóa thành công.");
                        frmdsNhanvien_Load(sender, e);
                    }
                   
                }
            }
        }

        private void btnTailai_Click(object sender, EventArgs e)
        {
            frmdsNhanvien_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvDsnhanvien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên muốn sửa!", "Thông báo");
                return;
            }
            else
            {
                maNhanVienSua = lblManhanvien.Text;
                frmSuaNhanVien frm = new frmSuaNhanVien();
                frm.ShowDialog();
            }
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            LuongBLL luongBLL = new LuongBLL();
            Luong luong = luongBLL.DocLuongTheoMa(int.Parse(lblLuong.Text));
            StringBuilder strb = new StringBuilder("Chức vụ: " + luong.ChucVu + "\r\n");
            strb.AppendLine("Lương căn bản: " + luong.LuongCanBan.ToString("#,##0 đồng"));
            strb.AppendLine("Hệ số: " + luong.HeSoLuong.ToString());
            strb.AppendLine("Phụ cấp: " + luong.PhuCap.ToString("#,##0 đồng"));
            MessageBox.Show(strb.ToString());
        }

        private void btnThemnhanvien_Click(object sender, EventArgs e)
        {
            frmThemNhanvien frm = new frmThemNhanvien();
            frm.ShowDialog();
        }

    }
}
