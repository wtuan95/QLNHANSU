using DTO;
using DAL;
using System.Collections.Generic;
using System.Data;
using System;
namespace BLL
{
    public class PhongBanBLL
    {
        ConnectDB db = new ConnectDB();
        public List<PhongBan> DocDanhSach()
        {
            try
            {
                DataTable tbl = db.Execute("select * from PhongBan");
                List<PhongBan> dsPhongBan = new List<PhongBan>();
                foreach (DataRow r in tbl.Rows)
                {
                    PhongBan phongBan = new PhongBan()
                    {
                        MaPB = r[0].ToString(),
                        TenPB = r[1].ToString()
                    };
                    dsPhongBan.Add(phongBan);
                }
                return dsPhongBan;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public PhongBan LayPhongTheoMa(string MaPB)
        {
            try
            {
                string query = "select * from PhongBan where MaPB = '" + MaPB + "'";
                DataTable dt = db.Execute(query);
                if (dt.Rows.Count > 0)
                {
                    PhongBan result = new PhongBan()
                    {
                        MaPB = dt.Rows[0][0].ToString(),
                        TenPB = dt.Rows[0][1].ToString()
                    };
                    return result;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string GetTenPhong(string MaPB)
        {
            try
            {
                string query = "select TenPB from PhongBan where MaPB = '" + MaPB + "'";
                object tenPhong = db.ExecuteScalar(query);
                if (tenPhong == null)
                {
                    return "Chưa có";
                }
                else
                {
                    return tenPhong.ToString();
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }
        public int ThemPhong(PhongBan model)
        {
            try
            {
                string query = "insert into PhongBan values('" + model.MaPB + "',N'" + model.TenPB + "')";
                return db.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int SuaPhong(PhongBan model)
        {
            try
            {
                string query = "update PhongBan set TenPB = N'" + model.TenPB + "' where MaPB = '" + model.MaPB + "'";
                return db.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int XoaPhong(string MaPB)
        {
            try
            {
                string query = "delete from PhongBan where MaPB = '" + MaPB + "'";
                return db.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int DemNhanVienTheoPhong(string MaPB)
        {
            try
            {
                string query = "select count(*) from NhanVien where MaPB = '"+MaPB+"'";
                return (int)db.ExecuteScalar(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
