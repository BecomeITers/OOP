using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đọc_ghi_file_quản_lý_nhân_viên
{
    public abstract class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public double LuongCoBan {  get; set; }

        public NhanVien()
        {
            MaNV = string.Empty;
            TenNV = string.Empty;
            LuongCoBan = 0.0;
        }

        public NhanVien(string maNV, string tenNV, double luongCoBan)
        {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.LuongCoBan = luongCoBan;
        }

        public abstract double TinhLuong();

        public virtual string toString()
        {
            return $"Ma nhan vien: {MaNV}, Ten nhan vien: {TenNV}, Luong co ban: {LuongCoBan}, Tinh luong: {TinhLuong()}";
        }
    }

    public class NhanVienHanhChinh : NhanVien
    {
        public int SoNgayCong { get; set; }

        public NhanVienHanhChinh() : base()
        {
            SoNgayCong = 0;
        }

        public NhanVienHanhChinh(string maNV, string tenNV, double luongCoBan, int soNgayCong) : base(maNV, tenNV, luongCoBan)
        {
            this.SoNgayCong = soNgayCong;
        }

        public override double TinhLuong()
        {
            return SoNgayCong * LuongCoBan;
        }

        public override string toString()
        {
            return $"Ma nhan vien: {MaNV}, Ten nhan vien: {TenNV}, Luong co ban: {LuongCoBan}, So ngay cong: {SoNgayCong}, Tinh luong: {TinhLuong()}";
        }
    }

    public class NhanVienSanXuat : NhanVien
    {
        public int SoSanPham { get; set; }

        public NhanVienSanXuat() : base()
        {
            SoSanPham = 0;
        }

        public NhanVienSanXuat(string maNV, string tenNV, double luongCoBan, int soSanPham) : base(maNV, tenNV, luongCoBan)
        {
            this.SoSanPham = soSanPham;
        }

        public override double TinhLuong()
        {
            return SoSanPham * LuongCoBan;
        }

        public override string toString()
        {
            return $"Ma nhan vien: {MaNV}, Ten nhan vien: {TenNV}, Luong co ban: {LuongCoBan}, So san pham: {SoSanPham}, Tinh luong: {TinhLuong()}";
        }
    }
}
