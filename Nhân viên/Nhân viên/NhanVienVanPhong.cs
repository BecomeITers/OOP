using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhân_viên
{
    internal class NhanVienVanPhong : NhanVien
    {
        public int soNgayLamViec;

        public NhanVienVanPhong() : base()
        {
            soNgayLamViec = 0;
        }

        public NhanVienVanPhong(int soNgayLamViec, string hoTen, string ngaySinh, DiaChi diachi) : base(hoTen, ngaySinh, diachi)
        {
            this.soNgayLamViec = soNgayLamViec;
        }

        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so ngay lam viec: ");
            soNgayLamViec = int.Parse(Console.ReadLine());
        }

        public new void In()
        {
            base.In();
            Console.WriteLine($"So ngay lam viec la: {soNgayLamViec}");
        }

        public double TinhLuong()
        {
            return soNgayLamViec * 100000;
        }
    }
}
