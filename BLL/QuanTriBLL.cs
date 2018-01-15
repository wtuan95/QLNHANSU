using DAL;
namespace BLL
{
    public class QuanTriBLL
    {
        ConnectDB db = new ConnectDB();
        public bool KiemTraDangNhap(string taikhoan, string matkhau)
        {
            string query = "select count(*) from QuanTri where TaiKhoan = '" + taikhoan + "' and MatKhau = '" + matkhau + "'";
            int dem = (int)db.ExecuteScalar(query);
            return dem == 1;
        }
        public int DoiMatKhau(string taikhoan, string matkhaumoi)
        {
            string query = "update QuanTri set MatKhau = '" + matkhaumoi + "' where TaiKhoan = '" + taikhoan + "'";
            return db.ExecuteNonQuery(query);
        }
    }
}
