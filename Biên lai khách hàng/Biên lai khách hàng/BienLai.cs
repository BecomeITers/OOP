using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biên_lai_khách_hàng
{
    internal class BienLai
    {
        private KhachHang khachHang;
        private int cSoCu;
        private int cSoMoi;

        public KhachHang KhachHang
        {
            get { return khachHang; }
            set { khachHang = value; }
        }

        public int CSoCu
        {
            get { return cSoCu; }
            set { cSoCu = value; }
        }

        public int CSoMoi
        {
            get { return cSoMoi; }
            set { cSoMoi = value; }
        }

        public BienLai()
        {
            CSoCu = CSoMoi = 0;

        }

        public BienLai(KhachHang khachHang, int cSoCu, int cSoMoi)
        {
            this.KhachHang = khachHang;
            this.CSoCu = cSoCu;
            this.CSoMoi = cSoMoi;
        }

        KhachHang customer = new KhachHang();
        public void Nhap()
        {
            customer.Nhap();
            Console.Write("Nhap chi so cu: ");
            CSoCu = int.Parse(Console.ReadLine());
            Console.Write("Nhap chi so moi: ");
            CSoMoi = int.Parse(Console.ReadLine());
        }

        public void In()
        {
            customer.In();
            Console.WriteLine($"Chi so cu la: {CSoCu}");
            Console.WriteLine($"Chi so moi la: {CSoMoi}");
            Console.WriteLine($"So tien ban phai tra la: {(CSoMoi - CSoCu) * 750} VND");
        }
    }
}