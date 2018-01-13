using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNHANSU.DAL;
namespace QLNHANSU.BLL
{
    class AdminBLL
    {
        DATABASE db = new DATABASE();
        public bool KiemTraDangNhap(string taikhoan, string matkhau)
        {
            string query = "select count(*) from Admin where TaiKhoan = '" + taikhoan + "' and MatKhau = '" + matkhau + "'";
            int dem = (int)db.ExecuteScalar(query);
            return dem > 0;
        }
        public int DoiMatKhau(string taikhoan, string matkhaumoi)
        {
            string query = "update Admin set MatKhau = '" + matkhaumoi + "' where TaiKhoan = '" + taikhoan + "'";
            return db.ExecuteNonQuery(query);
        }
    }
}
