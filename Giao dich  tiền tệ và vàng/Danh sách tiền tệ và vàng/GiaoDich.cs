using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danh_sách_tiền_tệ_và_vàng
{
    internal class GiaoDich
    {
        public string MaGiaoDich {  get; set; } 
        public string NgayGiaoDich { get; set; }    
        public double DonGia {  get; set; }
        public int SoLuong { get; set; }

        public GiaoDich()
        {
            MaGiaoDich = string.Empty;
            NgayGiaoDich= string.Empty;
            DonGia = 0;
            SoLuong = 0;
        }

        public GiaoDich(string maGiaoDich, string ngayGiaoDich, double donGia, int soLuong)
        {
            this.MaGiaoDich = maGiaoDich;
            this.NgayGiaoDich = ngayGiaoDich;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
        }

        public string toString()
        {
            return $"Ma giao dich la: {MaGiaoDich}, Ngay giao dich la: {NgayGiaoDich}, Don gia: {DonGia}, So luong: {SoLuong}";
        }

        public double ThanhTien()
        {
            return SoLuong * DonGia;
        }
    }

    internal class GiaoDichVang : GiaoDich
    {
        public string LoaiVang { get; set; }
        public GiaoDichVang()
        {
            LoaiVang = string.Empty;
        }
        public GiaoDichVang(string maGiaoDich, string ngayGiaoDich, double donGia, int soLuong, string loaiVang) : base(maGiaoDich, ngayGiaoDich, donGia, soLuong)
        {
            this.LoaiVang = loaiVang;
        }

        public new string toString()
        {
            return $"Ma giao dich la: {MaGiaoDich}, Ngay giao dich la: {NgayGiaoDich}, Don gia: {DonGia}, So luong: {SoLuong}, Loai vang: {LoaiVang}, Tien: {ThanhTien()}";
        }
    }

    internal class GiaoDichTienTe : GiaoDich
    {
        public string LoaiTienTe { get; set; }
        public double TiGia {  get; set; }
        public GiaoDichTienTe() : base()
        {
            LoaiTienTe = string.Empty;
            TiGia = 0;
        }
        public GiaoDichTienTe(string maGiaoDich, string ngayGiaoDich, double donGia, int soLuong, string loaiTienTe, double tiGia) : base(maGiaoDich, ngayGiaoDich, donGia, soLuong)
        {
            this.LoaiTienTe = loaiTienTe;
            this.TiGia = tiGia;
        }
        public new double ThanhTien()
        {
            if (LoaiTienTe == "USD" || LoaiTienTe == "EURO")
            {
                return SoLuong * DonGia * TiGia;
            }
            else
            {
                return SoLuong * DonGia;
            }
        }
        public new string toString()
        {
            return $"Ma giao dich la: {MaGiaoDich}, Ngay giao dich la: {NgayGiaoDich}, Don gia: {DonGia}, So luong: {SoLuong}, Loai tien te: {LoaiTienTe}, Ti gia la: {TiGia}, Tien: {ThanhTien()}";
        }
    }
}
