using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bất_động_sản
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLyBDS ql = new QuanLyBDS();

            ql.Nhap();

            Console.WriteLine("Danh sach: ");
            ql.In();

            ql.InSoLuong();

            ql.InDienTich();

        }
    }
}
