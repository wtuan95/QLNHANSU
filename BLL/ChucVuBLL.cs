using System;
using System.Collections.Generic;
using System.Data;
using DAL;
using DTO;
namespace BLL
{
    public class ChucVuBLL
    {
        ConnectDB db = new ConnectDB();
        public List<ChucVu> DocDanhSach()
        {
            DataTable tbl = db.Execute("select * from ChucVu");
            List<ChucVu> result = new List<ChucVu>();
            foreach (DataRow r in tbl.Rows)
            {
                ChucVu item = new ChucVu()
                {
                    MaCV = r[0].ToString(),
                    TenCV = r[1].ToString()
                };
                result.Add(item);
            }
            return result;

        }
    }
}
