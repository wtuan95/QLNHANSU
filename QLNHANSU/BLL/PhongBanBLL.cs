using QLNHANSU.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QLNHANSU.BLL
{
    class PhongBanBLL
    {
        DATABASE db = new DATABASE();
        public List<PhongBan> DocDanhSach()
        {
            DataTable tbl = db.Execute("select * from PhongBan");
            List<PhongBan> dsPhongBan = new List<PhongBan>();
            foreach(DataRow r in tbl.Rows)
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
            string query = "select TenPB from PhongBan where MaPB = '" + maPhong+"'";
            object tenPhong = db.ExecuteScalar(query);
            if(tenPhong == null)
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
