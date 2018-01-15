using System;
namespace DTO
{
    public class NhanVien
    {
        public string MaNV { get; set; } // Mã nhân viên

        public string MaPB { get; set; } // Mã phòng ban nhân viên làm việc

        public string MaCV { get; set; } // Mã chức vụ của nhân viên

        public string MaTD { get; set; } // Mã trình độ học vấn của nhân viên

        public string HoTen { get; set; }  // Họ tên nhân viên

        public bool GioiTinh { get; set; } // Giới tính nhân viên (true: Nam, false: Nữ)

        public DateTime NgaySinh { get; set; } // Ngày sinh 

        public DateTime NgayVaoLam { get; set; }  // Ngày vào làm 

        public string DiaChi { get; set; }  // Địa chỉ 

        public string CMND { get; set; }   // Số chứng minh nhân dân 
 
        public string Hinh { get; set; } // Chứa tên hình đại diện của nhân viên

        public string Email { get; set; }  // Địa chỉ email nhân viên sử dụng
        
        public string DienThoai { get; set; }  // Số điện thoại liên lạc

        public string GhiChu { get; set; }  // ghi chú về nhân viên 
        
        public string TaiKhoanTao { get; set; }  // người quản trị tạo thông tin nhân viên này
    }
}
