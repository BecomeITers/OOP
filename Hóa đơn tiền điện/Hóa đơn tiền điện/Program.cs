using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hóa_đơn_tiền_điện
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLyHoaDon ql = new QuanLyHoaDon();
            Console.WriteLine("Nhap hoa don: ");
            ql.NhapHoaDon();

            ql.XuatHoaDon();

            ql.XuatSoLuong();

            ql.XuatTrungBinh();

            ql.XuatHoaDon2018();
        }
    }
}
