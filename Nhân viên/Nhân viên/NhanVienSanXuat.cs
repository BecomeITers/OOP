using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Nhân_viên
{
    internal class NhanVienSanXuat : NhanVien
    {
        public double luongCB {  get; set; }
        public int soSp { get; set; }

        public NhanVienSanXuat() : base() 
        {
            luongCB = 0;
            soSp = 0;
        }

        public NhanVienSanXuat(double luongCB, int soSP, string hoTen, string ngaySinh, DiaChi diachi) : base(hoTen, ngaySinh, diachi)
        {
            this.luongCB = luongCB;
            this.soSp = soSP;
        }

        public double TinhLuong()
        {
            return (luongCB / 30 * soSp) + luongCB;
        }

        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap luong co ban: ");
            luongCB = double.Parse(Console.ReadLine());
            Console.Write("Nhap so luong san pham: ");
            soSp = int.Parse(Console.ReadLine());
        }

        public new void In()
        {
            base.In();
            Console.WriteLine($"Luong co ban la: {luongCB}");
            Console.WriteLine($"So san pham: {soSp}");
        }
    }
}
