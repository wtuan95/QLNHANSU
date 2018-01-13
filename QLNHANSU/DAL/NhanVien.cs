using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNHANSU.DAL
{
    class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTenNV { get; set; }
        public bool GioiTinhNV { get; set; }
        public int NamSinhNV { get; set; }
        public string DanToc { get; set; }
        public string DiaChiNV { get; set; }
        public string SDT { get; set; }
        public string MaPB { get; set; }
        public int? MaLuong { get; set; }
    }
}
