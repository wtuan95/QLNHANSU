using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DTO;
using System.IO;
using System.Text;

namespace QLNHANSU.PL
{
    public partial class frmQuanlynhanvien : Form
    {
        NhanVienBLL nhanvienBLL = new NhanVienBLL();
        PhongBanBLL phongbanBLL = new PhongBanBLL();
        bool them = false;
        string nameImage = "";
        public frmQuanlynhanvien()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        void HienListView(List<NhanVien> lst)
        {
            lvNhanvien.Items.Clear();
            foreach (NhanVien nv in lst)
            {
                ListViewItem itemlv = new ListViewItem();
                itemlv.Text = nv.MaNV;
                itemlv.SubItems.Add(nv.HoTen);
                itemlv.SubItems.Add(nv.NgaySinh.ToString("dd/MM/yyyy"));
                itemlv.SubItems.Add(nv.NgayVaoLam.ToString("dd/MM/yyyy"));
                itemlv.SubItems.Add(nv.Email);
                itemlv.SubItems.Add(nv.DienThoai);
                itemlv.SubItems.Add(nv.GioiTinh == true ? "Nam" : "Nữ");
                lvNhanvien.Items.Add(itemlv);
            }
        }

        //void DisabledControls()
        //{
        //    foreach(Control ctrl in groupBox1.Controls)
        //    {
        //        //if(ctrl.GetType() == typeof(TextBox))
        //        //{
        //            ctrl.Enabled = false;
        //        //}
               
        //    }
        //}

        private void frmQuanlynhanvien_Load(object sender, EventArgs e)
        {

            lstLoctheophong.DataSource = phongbanBLL.DocDanhSach().Select(m=>new PhongBan() { MaPB = m.MaPB, TenPB = m.TenPB.ToUpper() }).ToList();
            lstLoctheophong.ValueMember = "MaPB";
            lstLoctheophong.DisplayMember = "TenPB";
            lstLoctheophong.SelectedIndex = -1;

            cbPhongban.DataSource = phongbanBLL.DocDanhSach();
            cbPhongban.ValueMember = "MaPB";
            cbPhongban.DisplayMember = "TenPB";

            TrinhDoHocVanBLL trinhdohocvanBLL = new TrinhDoHocVanBLL();
            cbTrinhdo.DataSource = trinhdohocvanBLL.DocDanhSach();
            cbTrinhdo.ValueMember = "MaTD";
            cbTrinhdo.DisplayMember = "TenTD";

            ChucVuBLL chucvuBLL = new ChucVuBLL();
            cbChucvu.DataSource = chucvuBLL.DocDanhSach();
            cbChucvu.ValueMember = "MaCV";
            cbChucvu.DisplayMember = "TenCV";

            List<NhanVien> lst = nhanvienBLL.DocDanhSach();
            HienListView(lst);
            lvNhanvien_Click(sender, e);
        }

        private void lvNhanvien_Click(object sender, EventArgs e)
        {
            if(lvNhanvien.SelectedItems.Count > 0)
            {
                btnThayhinh.Visible = true;
                int index = lvNhanvien.SelectedItems[0].Index;
                NhanVien nvSelected = nhanvienBLL.DocNhanVienTheoMa(lvNhanvien.Items[index].Text);
                picHinh.Image = Image.FromFile(Environment.CurrentDirectory + "/../../Photos/" + nvSelected.Hinh);
                lblHoten.Text = nvSelected.HoTen + " ("+nvSelected.MaNV+")";
                txtMaNV.Text = nvSelected.MaNV;
                cbPhongban.SelectedValue = nvSelected.MaPB;
                cbChucvu.SelectedValue = nvSelected.MaCV;
                cbTrinhdo.SelectedValue = nvSelected.MaTD;
                txtHoten.Text = nvSelected.HoTen;
                dtimeNgaysinh.Value = nvSelected.NgaySinh;
                dtimeNgayvaolam.Value = nvSelected.NgayVaoLam;
                txtDiachi.Text = nvSelected.DiaChi;
                txtCMND.Text = nvSelected.CMND;
                txtEmail.Text = nvSelected.Email;
                txtDienthoai.Text = nvSelected.DienThoai;
                txtGhichu.Text = nvSelected.GhiChu;
                txtTaoboi.Text = nvSelected.TaiKhoanTao;
                chkGioitinh.Checked = nvSelected.GioiTinh;
            }
        }

        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            lstLoctheophong.SelectedIndex = -1;
            HienListView(nhanvienBLL.DocDanhSach());
        }

        private void lstLoctheophong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstLoctheophong.SelectedIndex != -1)
            {
                string maPB = lstLoctheophong.SelectedValue.ToString();

                HienListView(nhanvienBLL.DocDanhSach(maPB));
            }
        }

        void ResetValues()
        {
            foreach(Control ctrl in groupBox1.Controls)
            {
                if (ctrl.GetType() != typeof(ComboBox) && ctrl.GetType() != typeof(Label) && ctrl.GetType() != typeof(CheckBox) && ctrl.GetType() != typeof(Button))
                {
                    ctrl.ResetText();
                }
                if(ctrl.GetType() == typeof(ComboBox))
                {
                    (ctrl as ComboBox).SelectedIndex = 0;
                }
            }
            picHinh.Image = null;
            lblHoten.Text = "";
            btnThayhinh.Text = "Chọn hình";
            nameImage = "";
        }

        void HienNutLuuHuy(bool enable)
        {
            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;
            btnThem.Enabled = !enable;
            btnSua.Enabled = !enable;
            btnXoa.Enabled = !enable;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            txtMaNV.ReadOnly = false;
            ResetValues();
            btnThayhinh.Visible = true;
            HienNutLuuHuy(true);
        }

        bool KiemTraDuLieuHopLe()
        {
            StringBuilder strb = new StringBuilder();
            if (txtMaNV.Text == "")
            {
                strb.AppendLine("Bạn chưa nhập mã nhân viên!");
            }
            else if(them == true && nhanvienBLL.DocNhanVienTheoMa(txtMaNV.Text) != null)
            {
                strb.AppendLine("Mã nhân viên bị trùng. Xin nhập mã khác!");
            }
            if (txtHoten.Text == "")
            {
                strb.AppendLine("Bạn chưa nhập họ tên!");
            }
            if(txtDiachi.Text == "")
            {
                strb.AppendLine("Bạn chưa nhập địa chỉ!");
            }
            if(txtEmail.Text == "")
            {
                strb.AppendLine("Bạn chưa nhập Email!");
            }
            if (txtDienthoai.Text == "")
            {
                strb.AppendLine("Bạn chưa nhập số điện thoại!");
            }
            if (strb.ToString() != "")
            {
                MessageBox.Show(strb.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnThayhinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)  // Hiện dialog cho user chọn file
            {
                FileInfo fInfo = new FileInfo(dialog.FileName);
                // Yêu cầu đuôi file được chọn là 1 trong các đuôi .bmp, .jpg, .jpeg, .png, .gif
                if(fInfo.Extension == ".bmp" || fInfo.Extension == ".jpg" || fInfo.Extension == ".png" || fInfo.Extension == ".jpeg" || fInfo.Extension == ".gif")
                {
                    picHinh.Image = Image.FromFile(dialog.FileName);  // hiện hình được chọn vào control PictureBox
                    nameImage = fInfo.Name;
                   
                }
                
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(them)  // Thêm nhân viên
            {
                if(KiemTraDuLieuHopLe() == false) // Nếu chưa nhập đủ thông tin
                {
                    return;
                }
                else
                {
                    try
                    {
                        NhanVien nv = new NhanVien()
                        {
                            MaNV = txtMaNV.Text,
                            HoTen = txtHoten.Text,
                            MaPB = cbPhongban.SelectedValue.ToString(),
                            MaCV = cbChucvu.SelectedValue.ToString(),
                            MaTD = cbTrinhdo.SelectedValue.ToString(),
                            DiaChi = txtDiachi.Text,
                            CMND = txtCMND.Text,
                            Email = txtEmail.Text,
                            DienThoai = txtDienthoai.Text,
                            GioiTinh = chkGioitinh.Checked,
                            GhiChu = txtGhichu.Text,
                            TaiKhoanTao = string.IsNullOrEmpty(frmDangNhap.taikhoan) ? "Admin" : frmDangNhap.taikhoan,
                            NgaySinh = dtimeNgaysinh.Value,
                            NgayVaoLam = dtimeNgayvaolam.Value
                        };
                        if(picHinh.Image != null && nameImage != "")
                        {
                            nameImage = nv.MaNV.ToLower() + nameImage.Substring(nameImage.IndexOf('.'));
                            nv.Hinh = nameImage;
                            picHinh.Image.Save(Environment.CurrentDirectory + "/../../Photos/" + nameImage);
                        }
                        nhanvienBLL.ThemNhanVien(nv);
                        ListViewItem itemlv = new ListViewItem();
                        itemlv.Text = nv.MaNV;
                        itemlv.SubItems.Add(nv.HoTen);
                        itemlv.SubItems.Add(nv.NgaySinh.ToString("dd/MM/yyyy"));
                        itemlv.SubItems.Add(nv.NgayVaoLam.ToString("dd/MM/yyyy"));
                        itemlv.SubItems.Add(nv.Email);
                        itemlv.SubItems.Add(nv.DienThoai);
                        itemlv.SubItems.Add(nv.GioiTinh == true ? "Nam" : "Nữ");
                        
                        lvNhanvien.Items.Add(itemlv);
                        itemlv.Selected = true;
                        HienNutLuuHuy(false);
                        txtMaNV.ReadOnly = true;
                        MessageBox.Show("Thêm thành công.");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else   // Sửa nhân viên
            {
                if (KiemTraDuLieuHopLe() == false) // Nếu chưa nhập đủ thông tin
                {
                    return;
                }
                else
                {
                    try
                    {
                        NhanVien nv = nhanvienBLL.DocNhanVienTheoMa(txtMaNV.Text);
                        nv.HoTen = txtHoten.Text;
                        nv.MaPB = cbPhongban.SelectedValue.ToString();
                        nv.MaCV = cbChucvu.SelectedValue.ToString();
                        nv.MaTD = cbTrinhdo.SelectedValue.ToString();
                        nv.DiaChi = txtDiachi.Text;
                        nv.CMND = txtCMND.Text;
                        nv.Email = txtEmail.Text;
                        nv.DienThoai = txtDienthoai.Text;
                        nv.GioiTinh = chkGioitinh.Checked;
                        nv.GhiChu = txtGhichu.Text;
                        nv.NgaySinh = dtimeNgaysinh.Value;
                        nv.NgayVaoLam = dtimeNgayvaolam.Value;
                        
                        if (picHinh.Image != null && nameImage != "")
                        {
                            nameImage = nv.MaNV.ToLower() + nameImage.Substring(nameImage.IndexOf('.'));
                            nv.Hinh = nameImage;
                            picHinh.Image.Save(Environment.CurrentDirectory + "/../../Photos/" + nameImage);
                        }
                        nhanvienBLL.SuaNhanVien(nv);
                        ListViewItem itemlv = lvNhanvien.SelectedItems[0];
                        itemlv.Text = nv.MaNV;
                        itemlv.SubItems[1].Text = nv.HoTen;
                        itemlv.SubItems[2].Text = nv.NgaySinh.ToString("dd/MM/yyyy");
                        itemlv.SubItems[3].Text = nv.NgayVaoLam.ToString("dd/MM/yyyy");
                        itemlv.SubItems[4].Text = nv.Email;
                        itemlv.SubItems[5].Text = nv.DienThoai;
                        itemlv.SubItems[6].Text = nv.GioiTinh == true ? "Nam" : "Nữ";
                        itemlv.Selected = true;
                        HienNutLuuHuy(false);
                        MessageBox.Show("Sửa thành công.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            them = false;
            txtMaNV.ReadOnly = true;
            HienNutLuuHuy(false);
            lvNhanvien_Click(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            them = false;
            picHinh.Image = null;
            nameImage = "";
            btnThayhinh.Visible = true;
            HienNutLuuHuy(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvNhanvien.SelectedItems.Count > 0)
            {
                int index = lvNhanvien.SelectedItems[0].Index;
                DialogResult result = MessageBox.Show("Bạn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    string MaNV = lvNhanvien.SelectedItems[0].Text;
                    nhanvienBLL.XoaNhanVien(MaNV);
                    lvNhanvien.Items.RemoveAt(index);
                    MessageBox.Show("Xóa thành công");
                }
            }
        }
    }
}
