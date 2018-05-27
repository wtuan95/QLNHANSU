using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BLL
{
    public class KhenThuong_KyLuatBLL
    {
        ConnectDB db = new ConnectDB();
        public DataTable LayDanhSachKhenThuong()
        {
            string query = "select * from KhenThuong_KyLuat where KhenThuong = 1";
            DataTable tbl = db.Execute(query);
            return tbl;
        }
        public DataTable LayDanhSachKhenThuong(int Thang, int Nam)
        {
            string query = "select * from KhenThuong_KyLuat where KhenThuong = 1 and Thang = " + Thang.ToString() + " and Nam = " + Nam.ToString() + "";
            DataTable tbl = db.Execute(query);
            return tbl;
        }
        public DataTable LayDanhSachKyLuat()
        {
            string query = "select * from KhenThuong_KyLuat where KhenThuong = 0";
            DataTable tbl = db.Execute(query);
            return tbl;
        }
        public DataTable LayDanhSachKyLuat(int Thang, int Nam)
        {
            string query = "select * from KhenThuong_KyLuat where KhenThuong = 0 and Thang = "+Thang.ToString()+" and Nam = "+Nam.ToString()+"";
            DataTable tbl = db.Execute(query);
            return tbl;
        }
        public int Them(KhenThuong_KyLuat item)
        {
            string query = "insert into KhenThuong_KyLuat values('" + item.MaNV + "',N'" + item.NoiDung + "'," + item.SoTien.ToString() + "," + item.Thang.ToString() + "," + item.Nam.ToString() + "," + item.KhenThuong.ToString() + ",'" + item.ThucHienBoi + "')";
            return db.ExecuteNonQuery(query);
        }
        public int LayTongTienKhenThuong(string MaNV, int Thang, int Nam)
        {
            string query = "select ISNULL(SUM(SoTien),0) from KhenThuong_KyLuat where Thang = " + Thang.ToString() + " and Nam = " + Nam.ToString() + " and KhenThuong = 1 and MaNV = '" + MaNV + "'";
            return (int)db.ExecuteScalar(query);
        }
        public int LayTongTienKyLuat(string MaNV, int Thang, int Nam)
        {
            string query = "select ISNULL(SUM(SoTien),0) from KhenThuong_KyLuat where Thang = " + Thang.ToString() + " and Nam = " + Nam.ToString() + " and KhenThuong = 0 and MaNV = '" + MaNV + "'";
            return (int)db.ExecuteScalar(query);
        }
    }
}
