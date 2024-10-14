using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhân_viên
{
    public abstract class NhanVien
    {
        public string maSo { get; set; }
        public string hoTen { get; set; }
        public string namSinh { get; set; }

        public NhanVien()
        {
            maSo = string.Empty;
            hoTen = string.Empty;
            namSinh = string.Empty;
        }

        public NhanVien(string maSo, string hoTen, string namSinh)
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
        }

        public abstract double Luong();

        public virtual string toString()
        {
            return $"Ma so la: {maSo}, Ho ten la: {hoTen}, Nam sinh la: {namSinh}, Luong : {Luong()}";
        }
    }

    public class NVBC : NhanVien
    {
        public double luongCB { get; set; }
        public double heSoLuong { get; set; }
        public double tienPhuCap { get; set; }

        public NVBC() : base()
        {
            luongCB = 0.0;
            heSoLuong = 0.0;
            tienPhuCap = 0.0;
        }

        public NVBC(string maSo, string hoTen, string namSinh, double luongCB, double heSoLuongCB, double tienPhuCap) : base(maSo, hoTen, namSinh)
        {
            this.luongCB = luongCB;
            this.heSoLuong = heSoLuongCB;
            this.tienPhuCap = tienPhuCap;
        }

        public override double Luong()
        {
            return luongCB * heSoLuong * tienPhuCap;
        }

        public override string toString()
        {
            return $"Ma so la: {maSo}, Ho ten la: {hoTen}, Nam sinh la: {namSinh}, Luong: {Luong()}";
        }
    }

    public class NVHD : NhanVien
    {
        public double tienCong { get; set; }
        public double soGio { get; set; }

        public NVHD() : base()
        {
            tienCong = 0.0;
            soGio = 0.0;
        }

        public NVHD(string maSo, string hoTen, string namSinh, double tienCong, double soGio) : base(maSo, hoTen, namSinh)
        {
            this.tienCong = tienCong;
            this.soGio = soGio;
        }

        public override double Luong()
        {
            return tienCong * soGio;
        }

        public override string toString()
        {
            return $"Ma so la: {maSo}, Ho ten la: {hoTen}, Nam sinh la: {namSinh}, Luong: {Luong()}";
        }
    }
}
