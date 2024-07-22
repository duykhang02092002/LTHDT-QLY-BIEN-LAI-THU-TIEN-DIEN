using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_QLY_BIEN_LAI_THU_TIEN_DIEN
{
    internal class Biênlai
    {
        public class BienLai
        {
            // Thông tin về hộ sử dụng điện và chỉ số cũ, chỉ số mới, số tiền phải trả
            public KHACHHANG HoKhachHang { get; set; }
            public int Chisocu { get; set; }
            public int ChiSoMoi { get; set; }
            public int SoTienPhaiTra { get; set; }

            // Phương thức tính tiền điện dựa trên công thức đã cho
            public void TinhTienDien()
            {
                SoTienPhaiTra = (ChiSoMoi - Chisocu) * 750;
            }

            // Phương thức hiển thị thông tin của biên lai
            public void HienThiThongTin()
            {
                Console.WriteLine("Thông tin biên lai:");
                Console.WriteLine("Tên chủ hộ: " + HoKhachHang.Hoten);
                Console.WriteLine("Số nhà: " + HoKhachHang.Sonha);
                Console.WriteLine("Mã số công tơ: " + HoKhachHang.Masocongto);
                Console.WriteLine("Chỉ số cũ: " + Chisocu);
                Console.WriteLine("Chỉ số mới: " + ChiSoMoi);
                Console.WriteLine("Số tiền phải trả: " + SoTienPhaiTra );
                Console.WriteLine();
            }
        }

    }
}
