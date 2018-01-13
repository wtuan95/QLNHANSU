using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNHANSU.DAL;
using System.Data;
namespace QLNHANSU.BLL
{
    class LuongBLL
    {
        DATABASE db = new DATABASE();
        public List<Luong> DocDanhSach()
        {
            DataTable tbl = db.Execute("select * from HS_LUONG");
            List<Luong> dsLuong = new List<Luong>();
            foreach(DataRow r in tbl.Rows)
            {
                Luong luong = new Luong()
                {
                    MaLuong = int.Parse(r[0].ToString()),
                    ChucVu = r[1].ToString(),
                    LuongCanBan = decimal.Parse(r[2].ToString()),
                    HeSoLuong = float.Parse(r[3].ToString()),
                    PhuCap = decimal.Parse(r[4].ToString())
                };
                dsLuong.Add(luong);
            }
            return dsLuong;
        }
        public Luong DocLuongTheoMa(int MaLuong)
        {
            string query = "select * from HS_LUONG where MaLuong = " + MaLuong.ToString();
            DataTable tbl = db.Execute(query);
            if(tbl.Rows.Count == 0)
            {
                return null;
            }
            Luong luong = new Luong()
            {
                MaLuong = int.Parse(tbl.Rows[0][0].ToString()),
                ChucVu = tbl.Rows[0][1].ToString(),
                LuongCanBan = decimal.Parse(tbl.Rows[0][2].ToString()),
                HeSoLuong = float.Parse(tbl.Rows[0][3].ToString()),
                PhuCap = decimal.Parse(tbl.Rows[0][4].ToString())
            };
            return luong;
        }
    }
}
