using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xe
{
    internal class XE
    {
        private string nhanHieu;
        private int gia;
        private int namSX;

        public string NhanHieu { get => nhanHieu; set => nhanHieu = value; }
        public int Gia { get => gia; set => gia = value; }
        public int NamSX { get => namSX; set => namSX = value; }

        public XE() 
        { 
            nhanHieu = string.Empty;
            gia = 0;
            namSX = 0;
        }

        public XE(string nhanHieu, int gia, int namSX)
        {
            this.NhanHieu = nhanHieu;
            this.Gia = gia;
            this.NamSX = namSX;
        }

        public void Nhap()
        {
            Console.Write("Nhap nhan hieu: ");
            NhanHieu = Console.ReadLine();
            Console.Write("Nhap gia xe: ");
            Gia = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam san xuat: ");
            NamSX = int.Parse(Console.ReadLine());
        }

        public void In()
        {
            Console.WriteLine($"Nhan hieu: {NhanHieu}");
            Console.WriteLine($"Gia xe la: {Gia}");
            Console.WriteLine($"Nam san xuat xe la: {NamSX}");
        }
    }
}
