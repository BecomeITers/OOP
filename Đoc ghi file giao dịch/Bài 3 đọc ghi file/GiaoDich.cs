using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_3_đọc_ghi_file
{
    public abstract class GiaoDich
    {
        public string MaGiaoDich {  get; set; }
        public string NgayGiaoDich { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }

        public GiaoDich()
        {
            MaGiaoDich = string.Empty;
            NgayGiaoDich = string.Empty;
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

        public virtual string toString()
        {
            return $"Ma giao dich: {MaGiaoDich}, Ngay giao dich: {NgayGiaoDich}, Don gia: {DonGia}, So luong: {SoLuong}";
        }
    }

    public class GiaoDichVang : GiaoDich
    {
        public string LoaiVang { get; set; }

        public GiaoDichVang() : base()
        {
           LoaiVang = string.Empty;
        }

        public GiaoDichVang(string maGiaoDich, string ngayGiaoDich, double donGia, int soLuong, string loaiVang) : base(maGiaoDich, ngayGiaoDich, donGia, soLuong)
        {
            this.LoaiVang = loaiVang;
        }

        public override string toString()
        {
            return $"Ma giao dich: {MaGiaoDich}, Ngay giao dich: {NgayGiaoDich}, Don gia: {DonGia}, So luong: {SoLuong}, Loai vang: {LoaiVang}";
        }
    }

    public class GiaoDichTienTe : GiaoDich
    {
        public string LoaiTien { get; set; }
        public double TyGia { get; set; }

        public GiaoDichTienTe() : base()
        {
            LoaiTien = string.Empty;
            TyGia = 0.0;
        }

        public GiaoDichTienTe(string maGiaoDich, string ngayGiaoDich, double donGia, int soLuong, string loaiTien, double tyGia) : base(maGiaoDich, ngayGiaoDich, donGia, soLuong)
        {
            this.LoaiTien = loaiTien;
            this.TyGia = tyGia;
        }

        public override string toString()
        {
            return $"Ma giao dich: {MaGiaoDich}, Ngay giao dich: {NgayGiaoDich}, Don gia: {DonGia}, So luong: {SoLuong}, Loai tien: {LoaiTien}, Ty gia: {TyGia}";
        }
    }
}
