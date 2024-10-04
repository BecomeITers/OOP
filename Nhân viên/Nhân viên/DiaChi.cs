using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhân_viên
{
    internal class DiaChi
    {
        private string soNha;
        private string tenDuong;
        private string tenQuan;
        private string thanhPho;

        public string SoNha { get => soNha; set => soNha = value; }
        public string TenDuong { get => tenDuong; set => tenDuong = value; }
        public string TenQuan { get => tenQuan; set => tenQuan = value; }
        public string ThanhPho { get => thanhPho; set => thanhPho = value; }

        public DiaChi()
        {
            soNha = string.Empty;
            tenDuong = string.Empty;
            tenQuan = string.Empty;
            thanhPho = string.Empty;
        }

        public DiaChi(string soNha, string tenDuong, string tenQuan, string thanhPho)
        {
            this.SoNha = soNha;
            this.TenDuong = tenDuong;
            this.TenQuan = tenQuan;
            this.ThanhPho = thanhPho;
        }

        public void Nhap()
        {
            Console.Write("Nhap so nha: ");
            SoNha = Console.ReadLine();
            Console.Write("Nhap ten duong: ");
            TenDuong = Console.ReadLine();
            Console.Write("Nhap ten quan: ");
            TenQuan = Console.ReadLine();
            Console.Write("Nhap ten thanh pho: ");
            ThanhPho = Console.ReadLine();
        }

        public void In()
        {
            Console.WriteLine($"So nha: {SoNha}");
            Console.WriteLine($"Ten duong: {TenDuong}");
            Console.WriteLine($"Ten quan: {TenQuan}");
            Console.WriteLine($"Ten thanh pho : {ThanhPho}");
        }
    }
}
