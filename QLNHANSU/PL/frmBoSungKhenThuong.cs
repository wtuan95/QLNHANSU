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
    public partial class frmBoSungKhenThuong_KyLuat : Form
    {
        KhenThuong_KyLuatBLL bll = new KhenThuong_KyLuatBLL();
        int KhenThuong;
        public frmBoSungKhenThuong_KyLuat()
        {
            InitializeComponent();
        }
        public frmBoSungKhenThuong_KyLuat(int KhenThuong)
        {
            InitializeComponent();
            if(KhenThuong == 1)
            {
                this.Text = "BỔ SUNG KHEN THƯỞNG";
                lblTieude.Text = this.Text;
                this.KhenThuong = 1;
            }
            else
            {
                this.Text = "BỔ SUNG KỶ LUẬT";
                lblTieude.Text = this.Text;
                this.KhenThuong = 0;
            }
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBoSungKhenThuong_KyLuat_Load(object sender, EventArgs e)
        {
            for (int i = DateTime.Now.Year; i >= 2015; i--)
            {
                cbNam.Items.Add(i.ToString());
            }
            cbThang.Text = DateTime.Now.Month.ToString();
            cbNam.Text = DateTime.Now.Year.ToString();
            NhanVienBLL nhanvienBLL = new NhanVienBLL();
            AutoCompleteStringCollection autocomplete = new AutoCompleteStringCollection();
            autocomplete.AddRange(nhanvienBLL.DocDanhSach().Select(m => m.HoTen + "  (" + m.MaNV + ")").ToArray());
            txtTennhanvien.AutoCompleteCustomSource = autocomplete;
        }

        private void txtTennhanvien_TextChanged(object sender, EventArgs e)
        {
            string MaNV = txtTennhanvien.Text.Substring(txtTennhanvien.Text.IndexOf('(') + 1);
            MaNV = MaNV.Remove(MaNV.Length - 1);
            txtManhanvien.Text = MaNV;
        }

        private void btnBosung_Click(object sender, EventArgs e)
        {
            if(txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên!", "Lỗi");
                return;
            }
            if((int)numSotien.Value == 0)
            {
                MessageBox.Show("Bạn chưa nhập số tiền!", "Lỗi");
                return;
            }
            else
            {
                try
                {
                    int result = bll.Them(new DTO.KhenThuong_KyLuat()
                    {
                        MaNV = txtManhanvien.Text,
                        Nam = int.Parse(cbNam.Text),
                        Thang = int.Parse(cbThang.Text),
                        NoiDung = rtxtNoidung.Text,
                        SoTien = (int)numSotien.Value,
                        KhenThuong = this.KhenThuong,
                        ThucHienBoi = frmDangNhap.taikhoan
                    });
                    if (result == 1)
                    {
                        MessageBox.Show("Thực hiện thành công.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Xảy ra lỗi ở CSDL!", "Lỗi");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
