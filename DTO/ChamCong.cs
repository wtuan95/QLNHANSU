using System;

namespace DTO
{
    public class ChamCong
    {
        public string MaNV { get; set; }  // Mã nhân viên được chấm công

        public int Thang { get; set; } // Tháng chấm công

        public int Nam { get; set; } // Năm chấm công

        public int SoNgayLam { get; set; }  // Số ngày làm

        public int LuongNhan { get; set; }  // Lương được nhận (được tính dựa theo lương cơ bản và phụ cấp)

        public DateTime NgayCham { get; set; }  // Ngày thực hiện chấm công

        public string TaiKhoanCham { get; set; } // Tài khoản quản trị thực hiện chấm công
    }
}
