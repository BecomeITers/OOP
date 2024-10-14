using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhân_viên___đa_hình__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLyNhanVien ql = new QuanLyNhanVien();

            ql.Nhap();

            Console.WriteLine("Danh sach: ");
            ql.In();

            ql.TongSoLuong();

            ql.TongSo();

            ql.InNVGio();

            Console.ReadKey();
        }
    }
}
