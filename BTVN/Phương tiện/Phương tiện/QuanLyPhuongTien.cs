using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phương_tiện
{
    internal class QuanLyPhuongTien
    {
        private List<PhuongTien> pt = new List<PhuongTien>();
        public void Nhap()
        {
            Console.Write("Nhap so luong danh sach: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                Console.Write("Nhap loai phuong tien (Oto/XeMay/XeTai): ");
                string loaiPhuongTien = Console.ReadLine();

                Console.Write("Nhap hang san xuat: ");
                string hangSanXuat = Console.ReadLine();

                Console.Write("Nhap nam san xuat: ");
                int namSanXuat = int.Parse(Console.ReadLine());

                Console.Write("Nhap gia ban: ");
                double giaBan = double.Parse(Console.ReadLine());

                Console.Write("Nhap mau: ");
                string mau = Console.ReadLine();

                if(loaiPhuongTien == "Oto")
                {
                    Console.Write("Nhap so cho ngoi: ");
                    int soChoNgoi = int.Parse(Console.ReadLine());

                    Console.Write("Nhap kieu dong co: ");
                    string kieuDongCo = Console.ReadLine();

                    Oto oto = new Oto(hangSanXuat, namSanXuat, giaBan, mau, soChoNgoi, kieuDongCo);
                    pt.Add(oto);
                }

                else if(loaiPhuongTien == "XeMay")
                {
                    Console.Write("Nhap cong suat: ");
                    string congSuat = Console.ReadLine();

                    XeMay xm = new XeMay(hangSanXuat, namSanXuat, giaBan, mau, congSuat);
                    pt.Add(xm);
                }

                else if(loaiPhuongTien == "XeTai")
                {
                    Console.Write("Nhap trong tai: ");
                    double trongTai = double.Parse(Console.ReadLine());

                    XeTai xt = new XeTai(hangSanXuat, namSanXuat, giaBan, mau, trongTai);
                    pt.Add(xt);
                }

                else
                {
                    Console.WriteLine("Ko co danh sach!");
                    break;
                }
            }
        }

        public void In()
        {
            foreach(var phuongtien in pt)
            {
                Console.WriteLine(phuongtien.toString());
            }
        }

        public void Tim()
        {
            Console.Write("Nhap mau ban kiem: ");
            string timMau = Console.ReadLine();

            var xe = pt.FirstOrDefault(pt => pt.mau == timMau);
            if(xe != null)
            {
                Console.WriteLine(xe.toString());
            }
            else
            {
                Console.WriteLine("Ko co de tim!");
            }
        }

        public void Xuat()
        {
            Console.Write("Nhap nam san xuat de in xe: ");
            int namSX = int.Parse(Console.ReadLine());

            var timXe = pt.Where(pt => pt.namSanXuat < namSX);
            if (timXe.Any())
            {
                foreach(var xe in timXe)
                {
                    Console.WriteLine($"Danh sach xe nam san xuat duoi {namSX}: ");
                    Console.WriteLine(xe.toString());
                }
            }
            else
            {
                Console.WriteLine("Danh sach rong!");
            }
        }
    }
}
