using DAL;
using DTO;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class TrinhDoHocVanBLL
    {
        ConnectDB db = new ConnectDB();
        public List<TrinhDoHocVan> DocDanhSach()
        {
            DataTable tbl = db.Execute("select * from TrinhDoHocVan");
            List<TrinhDoHocVan> result = new List<TrinhDoHocVan>();
            foreach (DataRow r in tbl.Rows)
            {
                TrinhDoHocVan item = new TrinhDoHocVan()
                {
                    MaTD = r[0].ToString(),
                    TenTD = r[1].ToString()
                };
                result.Add(item);
            }
            return result;
        }

    }
}
