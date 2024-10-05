using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hóa_đơn_tiền_điện
{
    internal class QuanLyHoaDon
    {
        private List<HoaDon> hoadon = new List<HoaDon>();

        public void NhapHoaDon()
        {
            Console.Write("Nhap so luong hoa don: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.Write("Nhap dan toc: ");
                string DanToc = Console.ReadLine();

                Console.Write("Nhap ma khach hang: ");
                string maKhachHang = Console.ReadLine();

                Console.Write("Nhap ngay thang nam: ");
                string ngayRaHoaDon = Console.ReadLine();

                Console.Write("Nhap ho ten: ");
                string hoTen = Console.ReadLine();

                Console.Write("Nhap so luong kwh: ");
                int soLuong = int.Parse(Console.ReadLine());

                Console.Write("Nhap don gia: ");
                double donGia = double.Parse(Console.ReadLine());

                if (DanToc == "VN" || DanToc == "Viet Nam")
                {
                    Console.Write("Nhap dinh muc: ");
                    int dinhMuc = int.Parse(Console.ReadLine());
                    HoaDonVN hoadonvn = new HoaDonVN(maKhachHang, hoTen, ngayRaHoaDon, soLuong, donGia, dinhMuc);
                    hoadon.Add(hoadonvn);
                }
                else
                {
                    Console.Write("Nhap quoc tich: ");
                    string quocTich = Console.ReadLine();
                    HoaDonNuocNgoai hoadonnn = new HoaDonNuocNgoai(maKhachHang, hoTen, ngayRaHoaDon, soLuong, donGia, quocTich);
                }
            }
        }

        public void XuatHoaDon()
        {
            foreach (var HoaDon in hoadon)
            {
                Console.WriteLine(HoaDon.ToString());
            }
        }

        public void XuatSoLuong()
        {
            int SoLuongKwhVN = hoadon.OfType<HoaDonVN>().Sum(hd => hd.SoLuong);
            int SoLuongKwhNN = hoadon.OfType<HoaDonNuocNgoai>().Sum(hd => hd.SoLuong);

            Console.WriteLine($"So luong kwh cua VN la: {SoLuongKwhVN}");
            Console.WriteLine($"So luong kwh cua nuoc ngoai la: {SoLuongKwhNN}");
        }

        public void XuatTrungBinh()
        {
            var tien_nuoc_ngoai = hoadon.OfType<HoaDonNuocNgoai>();
            if (tien_nuoc_ngoai.Any())
            {
                double TrungBinhTienNN = tien_nuoc_ngoai.Average(hd => hd.ThanhTien());
                Console.WriteLine($"Trung binh tien nuoc ngoai la: {TrungBinhTienNN}");
            }
            else
            {
                Console.WriteLine("Ko co hoa don tien dien nuoc ngoai!");
            }
        }

        public void XuatHoaDon2018()
        {
            var HoaDon = hoadon.Where(hd => hd.NgayRaHoaDon == "9/2018");
            if (HoaDon.Any())
            {
                Console.WriteLine("Hoa don trong thang 9 nam 2018 la: ");
                foreach (var hoadon in HoaDon)
                {
                    Console.WriteLine(hoadon.toString());
                }
            }
    
            else
            {
                Console.WriteLine("Ko co hoa don nao het!");
            }
        }
    }
}
