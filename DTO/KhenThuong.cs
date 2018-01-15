namespace DTO
{
    public class KhenThuong
    {
        public int MaKT { get; set; } // Mã số khen thưởng

        public string MaNV { get; set; }  //Mã nhân viên được khen thưởng

        public string NoiDungKT { get; set; } // Nội dung, lý được khen thưởng

        public int CongLuong { get; set; }  // Số tiền được thưởng vào lương tháng

        public int Thang { get; set; } // Tháng được khen thưởng

        public int Nam { get; set; }  //Năm được khen thưởng

        public string ThucHienBoi { get; set; }  // Quản trị ghi chép 
    }
}
