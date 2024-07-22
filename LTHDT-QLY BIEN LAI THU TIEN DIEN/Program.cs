using LTHDT_QLY_BIEN_LAI_THU_TIEN_DIEN;
using System;
using System.Collections.Generic;
using static LTHDT_QLY_BIEN_LAI_THU_TIEN_DIEN.Biênlai;

class Program
{
    static void Main()
    {
        List<BienLai> danhSachBienLai = new List<BienLai>();

        Console.Write("Nhập số lượng hộ sử dụng điện: ");
        int n = int.Parse(Console.ReadLine());

        // Nhập thông tin cho từng hộ sử dụng điện
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập thông tin cho hộ sử dụng điện thứ {i + 1}:");
            KHACHHANG khachHang = NhapThongTinKhachHang();

            BienLai bienLai = new BienLai();
            bienLai.HoKhachHang = khachHang;

            Console.Write("Nhập chỉ số cũ: ");
            bienLai.Chisocu = int.Parse(Console.ReadLine());
            Console.Write("Nhập chỉ số mới: ");
            bienLai.ChiSoMoi = int.Parse(Console.ReadLine());

            bienLai.TinhTienDien(); // Tính tiền điện phải trả

            danhSachBienLai.Add(bienLai); // Thêm biên lai vào danh sách
            Console.WriteLine();
        }

        // Hiển thị thông tin các biên lai đã nhập
        Console.WriteLine("Thông tin các biên lai đã nhập:");
        foreach (var bienLai in danhSachBienLai)
        {
            bienLai.HienThiThongTin();
        }
    }

    // Phương thức nhập thông tin cho một hộ sử dụng điện
    static KHACHHANG NhapThongTinKhachHang()
    {
        KHACHHANG khachHang = new KHACHHANG();
        Console.Write("Nhập họ tên chủ hộ: ");
        khachHang.Hoten = Console.ReadLine();
        Console.Write("Nhập số nhà: ");
        khachHang.Sonha = Console.ReadLine();
        Console.Write("Nhập mã số công tơ: ");
        khachHang.Masocongto = Console.ReadLine();
        return khachHang;
    }
}
