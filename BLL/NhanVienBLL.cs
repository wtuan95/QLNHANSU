using DAL;
using DTO;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
namespace BLL
{
    public class NhanVienBLL
    {
        ConnectDB db = new ConnectDB();
        public List<NhanVien> DocDanhSach(string MaPB = "")
        {
            string query = "select * from NhanVien";
            if (string.IsNullOrEmpty(MaPB) == false)
            {
                query = "select * from NhanVien where MaPB = '" + MaPB + "'";
            }
            try
            {
                DataTable tbl = db.Execute(query);
                List<NhanVien> dsNhanVien = new List<NhanVien>();
                foreach (DataRow r in tbl.Rows)
                {

                    NhanVien nv = new NhanVien()
                    {
                        MaNV = r["MaNV"].ToString(),
                        MaPB = r["MaPB"] as string,
                        MaCV = r["MaCV"] as string,
                        MaTD = r["MaTD"] as string,
                        HoTen = r["HoTen"].ToString(),
                        GioiTinh = bool.Parse(r["GioiTinh"].ToString()),
                        NgaySinh = DateTime.Parse(r["NgaySinh"].ToString()),
                        NgayVaoLam = DateTime.Parse(r["NgayVaoLam"].ToString()),
                        DiaChi = r["DiaChi"] as string,
                        CMND = r["CMND"] as string,
                        Hinh = r["Hinh"] as string,
                        Email = r["Email"] as string,
                        DienThoai = r["DienThoai"] as string,
                        GhiChu = r["GhiChu"] as string,
                        TaiKhoanTao = r["TaiKhoanTao"] as string
                    };
                    dsNhanVien.Add(nv);
                }
                return dsNhanVien;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int ThemNhanVien(NhanVien nv)
        {
            try
            {
                List<SqlParameter> paramsSP = new List<SqlParameter>();
                paramsSP.Add(new SqlParameter() { ParameterName = "@MaNV", DbType = DbType.String, Value = nv.MaNV });
                paramsSP.Add(new SqlParameter() { ParameterName = "@MaPB", DbType = DbType.String, Value = nv.MaPB });
                paramsSP.Add(new SqlParameter() { ParameterName = "@MaCV", DbType = DbType.String, Value = nv.MaCV });
                paramsSP.Add(new SqlParameter() { ParameterName = "@MaTD", DbType = DbType.String, Value = nv.MaTD });
                paramsSP.Add(new SqlParameter() { ParameterName = "@HoTen", DbType = DbType.String, Value = nv.HoTen });
                paramsSP.Add(new SqlParameter() { ParameterName = "@GioiTinh", DbType = DbType.Boolean, Value = nv.GioiTinh });
                paramsSP.Add(new SqlParameter() { ParameterName = "@NgaySinh", DbType = DbType.Date, Value = nv.NgaySinh });
                paramsSP.Add(new SqlParameter() { ParameterName = "@NgayVaoLam", DbType = DbType.Date, Value = nv.NgayVaoLam });
                paramsSP.Add(new SqlParameter() { ParameterName = "@DiaChi", DbType = DbType.String, Value = nv.DiaChi });
                paramsSP.Add(new SqlParameter() { ParameterName = "@CMND", DbType = DbType.String, Value = nv.CMND });
                paramsSP.Add(new SqlParameter() { ParameterName = "@Hinh", DbType = DbType.String, Value = nv.Hinh });
                paramsSP.Add(new SqlParameter() { ParameterName = "@Email", DbType = DbType.String, Value = nv.Email });
                paramsSP.Add(new SqlParameter() { ParameterName = "@DienThoai", DbType = DbType.String, Value = nv.DienThoai });
                paramsSP.Add(new SqlParameter() { ParameterName = "@GhiChu", DbType = DbType.String, Value = nv.GhiChu });
                paramsSP.Add(new SqlParameter() { ParameterName = "@TaiKhoanTao", DbType = DbType.String, Value = nv.TaiKhoanTao });

                return db.ExecuteStoreProcedure("sp_themnhanvien", paramsSP);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int SuaNhanVien(NhanVien nv)
        {
            try
            {
                List<SqlParameter> paramsSP = new List<SqlParameter>();
                paramsSP.Add(new SqlParameter() { ParameterName = "MaNV", DbType = DbType.String, Value = nv.MaNV });
                paramsSP.Add(new SqlParameter() { ParameterName = "MaPB", DbType = DbType.String, Value = nv.MaPB });
                paramsSP.Add(new SqlParameter() { ParameterName = "MaCV", DbType = DbType.String, Value = nv.MaCV });
                paramsSP.Add(new SqlParameter() { ParameterName = "MaTD", DbType = DbType.String, Value = nv.MaTD });
                paramsSP.Add(new SqlParameter() { ParameterName = "HoTen", DbType = DbType.String, Value = nv.HoTen });
                paramsSP.Add(new SqlParameter() { ParameterName = "GioiTinh", DbType = DbType.Boolean, Value = nv.GioiTinh });
                paramsSP.Add(new SqlParameter() { ParameterName = "NgaySinh", DbType = DbType.Date, Value = nv.NgaySinh });
                paramsSP.Add(new SqlParameter() { ParameterName = "NgayVaoLam", DbType = DbType.Date, Value = nv.NgayVaoLam });
                paramsSP.Add(new SqlParameter() { ParameterName = "DiaChi", DbType = DbType.String, Value = nv.DiaChi });
                paramsSP.Add(new SqlParameter() { ParameterName = "CMND", DbType = DbType.String, Value = nv.CMND });
                paramsSP.Add(new SqlParameter() { ParameterName = "Hinh", DbType = DbType.String, Value = nv.Hinh });
                paramsSP.Add(new SqlParameter() { ParameterName = "Email", DbType = DbType.String, Value = nv.Email });
                paramsSP.Add(new SqlParameter() { ParameterName = "DienThoai", DbType = DbType.String, Value = nv.DienThoai });
                paramsSP.Add(new SqlParameter() { ParameterName = "GhiChu", DbType = DbType.String, Value = nv.GhiChu });

                return db.ExecuteStoreProcedure("sp_suanhanvien", paramsSP);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int XoaNhanVien(string MaNV)
        {
            try
            {
                string query = string.Format("delete from NhanVien where MaNV = '{0}'", MaNV);
                return db.ExecuteNonQuery(query);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<NhanVien> TimNhanVienTheoTen(string tukhoa)
        {
            List<NhanVien> dsNhanVien = DocDanhSach();
            return dsNhanVien.Where(m => m.HoTen.ToUpper().Contains(tukhoa.ToUpper())).ToList();
        }
        public NhanVien DocNhanVienTheoMa(string MaNV)
        {
            return DocDanhSach().FirstOrDefault(m => m.MaNV == MaNV);
        }
    }
}
