using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hóa_đơn_tiền_điện
{
    internal class HoaDon
    {
        public string MaKhachHang { get; set; }
        public string HoTen { get; set; }
        public string NgayRaHoaDon { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }

        public HoaDon()
        {
            MaKhachHang = string.Empty;
            HoTen = string.Empty;
            NgayRaHoaDon = string.Empty;
            SoLuong = 0;
            DonGia = 0;
        }

        public HoaDon(string maKhachHang, string hoTen, string ngayRaHoaDon, int soLuong, double donGia)
        {
            this.MaKhachHang = maKhachHang;
            this.HoTen = hoTen;
            this.NgayRaHoaDon = ngayRaHoaDon;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
        }

        public string toString()
        {
            return $"Ma Khach hang {MaKhachHang}, Ho ten la: {HoTen}, Ngay ra hoa don: {NgayRaHoaDon}, So luong: {SoLuong}, Don gia: {DonGia}";
        }
    }

    internal class HoaDonVN : HoaDon
    {
        public int DinhMuc { get; set; }

        public HoaDonVN() : base()
        {
            DinhMuc = 0;
        }

        public HoaDonVN(string maKhachHang, string hoTen, string ngayRaHoaDon, int soLuong, double donGia, int dinhMuc) : base(maKhachHang, hoTen, ngayRaHoaDon, soLuong, donGia)
        {
            this.DinhMuc = dinhMuc;
        }

        public double ThanhTien()
        {
            if (SoLuong <= DinhMuc)
            {
                return SoLuong * DonGia;
            }
            else
            {
                return SoLuong * DonGia * DinhMuc + (SoLuong - DinhMuc) * DonGia * 2.5;
            }
        }

        public new string toString()
        {
            return $"Ma Khach hang {MaKhachHang}, Ho ten la: {HoTen}, Ngay ra hoa don: {NgayRaHoaDon}, So luong: {SoLuong}, Don gia: {DonGia}, Dinh muc: {DinhMuc}, Thanh tien: {ThanhTien()}";
        }
    }

    internal class HoaDonNuocNgoai : HoaDon
    {
        public string QuocTich { get; set; }

        public HoaDonNuocNgoai() : base()
        {
            QuocTich = string.Empty;
        }

        public HoaDonNuocNgoai(string maKhachHang, string hoTen, string ngayRaHoaDon, int soLuong, double donGia, string quocTich) : base(maKhachHang, hoTen, ngayRaHoaDon, soLuong, donGia)
        {
            this.QuocTich = quocTich;
        }

        public double ThanhTien()
        {
            return SoLuong * DonGia;
        }

        public new string toString()
        {
            return $"Ma Khach hang {MaKhachHang}, Ho ten la: {HoTen}, Ngay ra hoa don: {NgayRaHoaDon}, So luong: {SoLuong}, Don gia: {DonGia}, Quoc tich la: {QuocTich}, Thanh tien: {ThanhTien()}";
        }
    }
}
