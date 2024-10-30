using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Đọc_ghi_file;

namespace Đọc_ghi_file
{
    public abstract class SanPham
    {
        public string MaSanPham {  get; set; }
        public string TenSanPham { get; set; }
        public double DonGia {  get; set; }
        public int SoLuong { get; set; }

        public SanPham()
        {
            MaSanPham = string.Empty;
            TenSanPham = string.Empty;
            DonGia = 0;
            SoLuong = 0;
        }

        public SanPham(string maSanPham, string tenSanPham, double donGia, int soLuong)
        {
            this.MaSanPham = maSanPham;
            this.TenSanPham = tenSanPham;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
        }

        public virtual string toString()
        {
            return $"Ma san pham: {MaSanPham}, Ten san pham: {TenSanPham}, Don gia: {DonGia}, So luong: {SoLuong}";
        }          
    }

    public class DienTu : SanPham
    {
        public int BaoHanh { get; set; }

        public DienTu() : base()
        {
            BaoHanh = 0;
        }

        public DienTu(string maSanPham, string tenSanPham, double donGia, int soLuong, int baoHanh) : base(maSanPham, tenSanPham, donGia, soLuong)
        {
            this.BaoHanh = baoHanh;
        }

        public override string toString()
        {
            return $"Ma san pham: {MaSanPham}, Ten san pham: {TenSanPham}, Don gia: {DonGia}, So luong: {SoLuong}, Bao hanh: {BaoHanh}";
        }
    }

    public class ThucPham : SanPham
    {
        public string HanSuDung { get; set; }

        public ThucPham() : base()
        {
            HanSuDung = string.Empty;
        }

        public ThucPham(string maSanPham, string tenSanPham, double donGia, int soLuong, string hanSuDung) : base(maSanPham, tenSanPham, donGia, soLuong)
        {
            this.HanSuDung = hanSuDung;
        }

        public override string toString()
        {
            return $"Ma san pham: {MaSanPham}, Ten san pham: {TenSanPham}, Don gia: {DonGia}, So luong: {SoLuong}, Han su dung: {HanSuDung}";
        }
    }
    }

public class DoGom : SanPham
{
    public string NgheNhan { get; set; }

    public DoGom() : base()
    {
        NgheNhan = string.Empty;
    }

    public DoGom(string maSanPham, string tenSanPham, double donGia, int soLuong, string ngheNhan) : base(maSanPham, tenSanPham, donGia, soLuong)
    {
        this.NgheNhan = ngheNhan;
    }

    public override string toString()
    {
        return $"Ma san pham: {MaSanPham}, Ten san pham: {TenSanPham}, Don gia: {DonGia}, So luong: {SoLuong}, Nghe nhan: {NgheNhan}";
    }
}

