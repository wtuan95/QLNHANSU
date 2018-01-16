using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class ChamCongBLL
    {
        ConnectDB db = new ConnectDB();
        public int TinhLuong(string MaNV, int SoNgayLam)
        {
            try
            {
                int LuongCoBan = (int)db.ExecuteScalar("select LuongCoBan from NhanVien, ChucVu where NhanVien.MaCV = ChucVu.MaCV and MaNV = '" + MaNV + "'");
                int luong = (int)Math.Floor((LuongCoBan / 30.0)) * SoNgayLam;
                return luong;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable LayDanhSachTheoNhanVien(string MaNV)
        {
            try
            {
                string query = "select * from ChamCong where MaNV = '" + MaNV + "' order by Nam desc, Thang";
                DataTable dt = db.Execute(query);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool KiemTraTonTai(string MaNV, int Thang, int Nam)
        {
            try
            {
                string query = "select count(*) from ChamCong where MaNV = '" + MaNV + "' and Thang = " + Thang.ToString() + " and Nam = " + Nam.ToString() + "";
                int dem = (int)db.ExecuteScalar(query);
                return dem == 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int ThemChamCong(ChamCong model)
        {
            try
            {
                return db.ExecuteNonQuery("set dateformat dmy insert into ChamCong values('" + model.MaNV + "'," + model.Thang.ToString() + "," + model.Nam.ToString() + ", " + model.SoNgayLam.ToString() + "," + model.LuongNhan.ToString() + ",'" + DateTime.Now.ToString("dd/MM/yyyy") + "','" + model.TaiKhoanCham + "')");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int XoaChamCong(string MaNV, int Thang, int Nam)
        {
            try
            {
                return db.ExecuteNonQuery("delete from ChamCong where MaNV = '" + MaNV + "' and Thang = " + Thang.ToString() + " and Nam = " + Nam.ToString() + "");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
