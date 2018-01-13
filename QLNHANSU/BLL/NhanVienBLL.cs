using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNHANSU.DAL;
using System.Data;
namespace QLNHANSU.BLL
{
    class NhanVienBLL
    {
        DATABASE db = new DATABASE();
        public List<NhanVien> DocDanhSach()
        {
            string query = "select * from NhanVien";
            DataTable tbl = db.Execute(query);
            List<NhanVien> dsNhanVien = new List<NhanVien>();
            foreach(DataRow r in tbl.Rows)
            {

                NhanVien nv = new NhanVien()
                {
                    MaNV = r["MaNV"].ToString(),
                    HoTenNV = r["HoTenNV"].ToString(),
                    GioiTinhNV = bool.Parse(r["GioiTinhNV"].ToString()),
                    NamSinhNV = int.Parse(r["NamSinhNV"].ToString()),
                    DanToc = r["DanToc"].ToString(),
                    DiaChiNV = r["DiaChiNV"].ToString(),
                    SDT = r["SDTNV"].ToString(),
                    MaPB = r["MaPB"] != null ? r["MaPB"].ToString() : "",
                    MaLuong = !string.IsNullOrEmpty(r["MaLuong"].ToString())  ? int.Parse(r["MaLuong"].ToString()) as Nullable<int> : null
                };
                dsNhanVien.Add(nv);
            }
            return dsNhanVien;
        }
        public int ThemNhanVien(NhanVien nhanvienMoi)
        {
            string query = string.Format("insert into NhanVien values('{0}',N'{1}',{2},{3},N'{4}',N'{5}','{6}','{7}',{8})", nhanvienMoi.MaNV, nhanvienMoi.HoTenNV, nhanvienMoi.GioiTinhNV == true ? 1 : 0, nhanvienMoi.NamSinhNV, nhanvienMoi.DanToc, nhanvienMoi.DiaChiNV, nhanvienMoi.SDT, nhanvienMoi.MaPB, nhanvienMoi.MaLuong);
            return db.ExecuteNonQuery(query);
        }
        public int SuaNhanVien(NhanVien nhanVienSua)
        {
            string query = string.Format("update NhanVien set HoTenNV = N'{0}', GioiTinhNV  = {1}, NamSinhNV = {2}, DanToc = N'{3}', DiaChiNV = N'{4}', SDTNV = '{5}', MaPB = '{6}', MaLuong = {7} where MaNV = '{8}'", nhanVienSua.HoTenNV, nhanVienSua.GioiTinhNV == true ? 1 :  0, nhanVienSua.NamSinhNV, nhanVienSua.DanToc, nhanVienSua.DiaChiNV, nhanVienSua.SDT, nhanVienSua.MaPB, nhanVienSua.MaLuong, nhanVienSua.MaNV);
            return db.ExecuteNonQuery(query);
        }
        public int XoaNhanVien(string MaNV)
        {
            string query = string.Format("delete from NhanVien where MaNV = '{0}'", MaNV);
            return db.ExecuteNonQuery(query);
        }
        public List<NhanVien> TimNhanVienTheoTen(string tukhoa)
        {
            List<NhanVien> dsNhanVien = DocDanhSach();
            return dsNhanVien.Where(m => m.HoTenNV.ToUpper().Contains(tukhoa.ToUpper())).ToList();
        }
        public NhanVien DocNhanVienTheoMa(string MaNV)
        {
            return DocDanhSach().FirstOrDefault(m => m.MaNV == MaNV); 
        }
    }
}
