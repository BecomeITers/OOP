using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_danh_sách_máy_tính
{
    internal class Computer
    {
        private string loaiMay;
        private string noiSanXuat;
        private int thoiGianBaoHanh;
        private static int dem = 0;

        public string LoaiMay
        {
            get { return loaiMay; }
            set { loaiMay = value; }
        }

        public string NoiSanXuat
        {
            get { return noiSanXuat; }
            set { noiSanXuat = value; }
        }

        public int ThoiGianBaoHanh
        {
            get { return thoiGianBaoHanh; }
            set { thoiGianBaoHanh = value; }
        }

        public Computer()
        {
            loaiMay = noiSanXuat = null;
            thoiGianBaoHanh = 0;
        }

        public Computer(string loaiMay, string noiSanXuat, int thoiGianBaoHanh)
        {
            this.LoaiMay = loaiMay;
            this.NoiSanXuat = noiSanXuat;
            this.ThoiGianBaoHanh = thoiGianBaoHanh;
        }

        ~Computer()
        {
            dem--;
        }

        public int getDem()
        {
            return dem;
        }

        public void Nhap()
        {
            dem++;
            Console.Write("Nhap loai may: ");
            LoaiMay = Console.ReadLine();
            Console.Write("Nhap noi san xuat: ");
            NoiSanXuat = Console.ReadLine();
            Console.Write("Nhap thoi gian bao hanh: ");
            ThoiGianBaoHanh = int.Parse(Console.ReadLine());    
        }

        public void In()
        {
            Console.WriteLine($"Loai may la: {LoaiMay}");
            Console.WriteLine($"Noi san xuat may la: {NoiSanXuat}");
            Console.WriteLine($"Thoi gian bao hanh may la: {ThoiGianBaoHanh}");
        }

        public bool ThongKe(int so)
        {
            if(ThoiGianBaoHanh == so)
            {
                return true;
            }
            return false;
        }
    }
}
