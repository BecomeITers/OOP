using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bất_động_sản
{
    internal class QuanLyBDS
    {
        private List<BDS> bds = new List<BDS>();
        public void Nhap()
        {
            Console.Write("Nhap so luong danh sach BDS: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                Console.Write("Nhap loai BDS (DatTrong/NhaO/KhachSan/BietThu): ");
                string loaiBDS = Console.ReadLine();

                Console.Write("Nhap ma so: ");
                string maSo = Console.ReadLine();

                Console.Write("Nhap chieu dai: ");
                double chieuDai = double.Parse(Console.ReadLine());

                Console.Write("Nhap chieu rong: ");
                double chieuRong = double.Parse(Console.ReadLine());

                if(loaiBDS == "DatTrong")
                {
                    DatTrong dt = new DatTrong(maSo, chieuDai, chieuRong);
                    bds.Add(dt);
                }
                else if(loaiBDS == "NhaO")
                {
                    Console.Write("Nhap so lau: ");
                    int soLau = int.Parse(Console.ReadLine());

                    NhaO no = new NhaO(maSo, chieuDai, chieuRong, soLau);
                    bds.Add(no);
                }
                else if(loaiBDS == "KhachSan")
                {
                    Console.Write("Nhap so sao: ");
                    int soSao = int.Parse(Console.ReadLine());

                    KhachSan ks = new KhachSan(maSo, chieuDai, chieuRong, soSao);
                    bds.Add(ks);
                }
                else if (loaiBDS == "BietThu")
                {
                    BietThu bt = new BietThu(maSo, chieuDai, chieuRong);
                    bds.Add(bt);
                }
                else
                {
                    Console.WriteLine("Nhap sai loai bat dong san!");
                    break;
                }
            }
        }

        public void In()
        {
            foreach(var batdongsan in bds)
            {
                Console.WriteLine(batdongsan.Print());
            }
        }

        public void InSoLuong()
        {
            int dt = bds.OfType<int>().Count();
            int no = bds.OfType<int>().Count();
            int ks = bds.OfType<int>().Count();
            int bt = bds.OfType<int>().Count();

            Console.WriteLine($"So luong dat trong la: {dt}");
            Console.WriteLine($"So luong nha ola: {no}");
            Console.WriteLine($"So luong khach san la: {ks}");
            Console.WriteLine($"So luong biet thu la: {bt}");
        }

        public void InDienTich()
        {
            var bds1k = bds.Where(bds => bds.DienTich() > 1000);
            if (bds1k.Any())
            {
                foreach(var bds in bds1k)
                {
                    Console.WriteLine(bds.Print());
                }
            }
            else
            {
                Console.WriteLine("Ko co danh sach!");
            }
        }
    }
}
