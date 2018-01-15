namespace DTO
{
    public class KyLuat
    {
        public int MaKL { get; set; } // Mã số kỹ luật 

        public string MaNV { get; set; }  //Mã nhân viên bị kỷ luật

        public string NoiDungKL { get; set; } // Nội dung, lý do bị kỷ luật

        public int TruLuong { get; set; }  // Số tiền bị trừ vào lương tháng

        public int Thang { get; set; } // Tháng bị kỷ luật

        public int Nam { get; set; }  //Năm bị kỷ luật

        public string ThucHienBoi { get; set; }  // Quản trị ghi chép 
    }
}
