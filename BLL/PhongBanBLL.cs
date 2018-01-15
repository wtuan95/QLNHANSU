using DTO;
using DAL;
using System.Collections.Generic;
using System.Data;
namespace BLL
{
    public class PhongBanBLL
    {
        ConnectDB db = new ConnectDB();
        public List<PhongBan> DocDanhSach()
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
       
        public string GetTenPhong(string maPhong)
        {
            string query = "select TenPB from PhongBan where MaPB = '" + maPhong + "'";
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
    }
}
