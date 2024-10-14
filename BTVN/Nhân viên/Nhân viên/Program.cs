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
            QuanLyNhanVien ql = new QuanLyNhanVien();

            ql.Nhap();

            Console.Write("Danh sach: ");
            ql.In();

            ql.Tong();

            ql.Tim();

            ql.Xuat();

            Console.ReadKey();
        }
    }
}

