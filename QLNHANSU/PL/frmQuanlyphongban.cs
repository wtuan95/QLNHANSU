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
    public partial class frmQuanlyphongban : Form
    {
        PhongBanBLL phongbanBLL = new PhongBanBLL();
        bool them = false; // biến để kiểm tra xem user đang thực hiện chức năng Thêm hay Sửa. Nếu them == true là đang thêm ngược lại là sửa
        public frmQuanlyphongban()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them = true;
            txtMaphong.ReadOnly = txtTenphong.ReadOnly =  false;
            txtMaphong.Clear();
            txtTenphong.Clear();
            HienNutLuuHuy(true);
        }
        void HienNutLuuHuy(bool enable)  // Ẩn hoặc hiện nút Lưu và Hủy
        {
            btnLuu.Enabled = enable;
            btnHuy.Enabled = enable;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = !enable;
        }

        void HienListView(List<PhongBan> lst)
        {
            lvNhanvien.Items.Clear();  // Xóa hết items ở listview để add lại từ đầu bên dưới
            foreach(PhongBan pb in lst)
            {
                ListViewItem itemlv = new ListViewItem(pb.MaPB);
                itemlv.SubItems.Add(pb.TenPB);
                itemlv.ImageIndex = 0;
                lvNhanvien.Items.Add(itemlv);
            }
        }
        private void frmQuanlyphongban_Load(object sender, EventArgs e)
        {
            List<PhongBan> lst = phongbanBLL.DocDanhSach();  // Lấy toàn bộ ds phòng ban gán qua biến lst
            HienListView(lst);  //Hiện toàn bộ phòng ban ở listview
        }

        private void lvNhanvien_Click(object sender, EventArgs e)
        {
            if(lvNhanvien.SelectedItems.Count > 0)  // Nếu user đang chọn 1 item bất kỳ ở listview
            {
                int index = lvNhanvien.SelectedItems[0].Index;
                txtMaphong.Text = lvNhanvien.SelectedItems[0].Text;
                txtTenphong.Text = lvNhanvien.SelectedItems[0].SubItems[1].Text;
                btnHuy_Click(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaphong.Text != "" && lvNhanvien.SelectedItems.Count > 0)
            {
                them = false;
                txtTenphong.ReadOnly = false;
                HienNutLuuHuy(true);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn phòng cẩn sửa thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(them)
            {
                // Thêm phòng
                try
                {
                    if(txtMaphong.Text == "" || txtTenphong.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập đủ thông tin trước khi thêm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        string MaPB = txtMaphong.Text;
                        PhongBan pb = phongbanBLL.LayPhongTheoMa(MaPB);
                        if(pb != null)
                        {
                            MessageBox.Show("Mã phòng bị trùng với phòng khác. Hãy nhập mã khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            int result = phongbanBLL.ThemPhong(new PhongBan() { MaPB = MaPB, TenPB = txtTenphong.Text });
                            if(result == 1)
                            {
                                ListViewItem itemLv = new ListViewItem(txtMaphong.Text);
                                itemLv.SubItems.Add(txtTenphong.Text);
                                itemLv.ImageIndex = 0;
                                lvNhanvien.Items.Add(itemLv);
                                MessageBox.Show("Thêm thành công");
                            }
                            else
                            {
                                MessageBox.Show("Thêm thất bại. Xảy ra lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Sửa phòng
                try
                {
                    if (txtMaphong.Text == "" || txtTenphong.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập đủ thông tin trước khi sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        PhongBan pb = phongbanBLL.LayPhongTheoMa(txtMaphong.Text);
                        pb.TenPB = txtTenphong.Text;
                        int result = phongbanBLL.SuaPhong(pb);
                        if (result == 1)
                        {
                            ListViewItem itemLv = lvNhanvien.SelectedItems[0];
                            itemLv.SubItems[1].Text = txtTenphong.Text;
                            MessageBox.Show("Sửa thành công");
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại. Xảy ra lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            HienNutLuuHuy(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            them = false;
            HienNutLuuHuy(false);
            txtTenphong.ReadOnly = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaphong.Text != "" && lvNhanvien.SelectedItems.Count > 0)
            {
                int dem = phongbanBLL.DemNhanVienTheoPhong(txtMaphong.Text);
                if(dem > 0)
                {
                    MessageBox.Show("Phòng ban " + txtMaphong.Text + " đang có nhân viên. Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DialogResult resultDialog = MessageBox.Show("Bạn muốn xóa phòng " + txtMaphong.Text + " ?", "Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultDialog == DialogResult.OK)
                {
                    int index = lvNhanvien.SelectedItems[0].Index;
                    int result = phongbanBLL.XoaPhong(txtMaphong.Text);
                    if (result == 1)
                    {
                        lvNhanvien.Items.RemoveAt(index);
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại. Xảy ra lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }
    }
}
