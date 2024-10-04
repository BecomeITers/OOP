using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhân_viên
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVienSanXuat nhanvien1 = new NhanVienSanXuat();
            NhanVienVanPhong nhanvien2 = new NhanVienVanPhong();
            Console.WriteLine("Nhan vien san xuat: ");
            nhanvien1.Nhap();
            Console.WriteLine("Nhan vien van phong: ");
            nhanvien2.Nhap();

            nhanvien1.In();
            Console.WriteLine($"Tien luong la: {nhanvien1.TinhLuong()}");
            Console.WriteLine("------------------------");
            nhanvien2.In();
            Console.WriteLine($"Tien luong la: {nhanvien2.TinhLuong()}");
            Console.ReadKey();
        }
    }
}
