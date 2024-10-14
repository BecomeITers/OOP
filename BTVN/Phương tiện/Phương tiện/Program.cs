using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phương_tiện
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLyPhuongTien ql = new QuanLyPhuongTien();

            ql.Nhap();

            Console.WriteLine("Danh sach: ");
            ql.In();

            ql.Tim();

            ql.Xuat();

            Console.ReadKey();
        }
    }
}
