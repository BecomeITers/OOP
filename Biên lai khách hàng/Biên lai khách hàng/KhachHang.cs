using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biên_lai_khách_hàng
{
    internal class KhachHang
    {
        private string hoTenChuHo;
        private string soNha;
        private int maSoCongTo;

        public string HoTenChuHo
        {
            get { return hoTenChuHo; }
            set { hoTenChuHo = value; }
        }

        public string SoNha
        {
            get { return soNha; }
            set { soNha = value; }
        }

        public int MaSoCongTo
        {
            get { return maSoCongTo; }
            set { maSoCongTo = value; }
        }

        public KhachHang()
        {
            hoTenChuHo = soNha = null;
            maSoCongTo = 0;
        }

        public KhachHang(string hoTenChuHo, string soNha, int maSoCongTo)
        {
            this.HoTenChuHo = hoTenChuHo;
            this.SoNha = soNha;
            this.MaSoCongTo = maSoCongTo;
        }

        public void Nhap()
        {
            Console.Write("Nhap ten khach hang: ");
            HoTenChuHo = Console.ReadLine();
            Console.Write("Nhap so nha: ");
            SoNha = Console.ReadLine();
            Console.Write("Nhap so cong to dien: ");
            MaSoCongTo = int.Parse(Console.ReadLine());
        }

        public void In()
        {
            Console.WriteLine($"Ho ten chu ho la: {HoTenChuHo}");
            Console.WriteLine($"So nha la: {SoNha}");
            Console.WriteLine($"Ma so cong cong to dien la: {MaSoCongTo}");
        }
    }
}
