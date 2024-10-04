using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kế_thừa
{
    internal class Xe
    {
        private string maXe;
        private string soXe;

        public string MaXe
        {
            get { return maXe; }
            set { maXe = value; }
        }

        public string SoXe
        {
            get { return soXe; }
            set { soXe = value; }
        }

        public Xe()
        {
            MaXe = " ";
            SoXe = " ";
        }

        public Xe(string maXe, string soXe)
        {
            this.MaXe = maXe;
            this.SoXe = soXe;
        }

        public void Nhap()
        {
            Console.Write("Nhap ma xe: ");
            MaXe = Console.ReadLine();
            Console.Write("Nhap so xe: ");
            SoXe = Console.ReadLine();
        }

        public void In()
        {
            Console.WriteLine($"Ma xe la: {MaXe} va So xe la: {soXe}");
        }
    }

    internal class XeKhach : Xe
    {
        public string TaiXe { get; set; }
        public int SoChoNgoi { get; set; }

        public XeKhach() : base()
        {
            SoChoNgoi = 0;
            TaiXe = " ";
        }

        public XeKhach(string maXe, string soXe, string taiXe, int soChoNgoi) : base(maXe, soXe)
        {
            this.TaiXe = taiXe;
            this.SoChoNgoi = soChoNgoi;
        }

        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap ten tai xe: ");
            TaiXe = Console.ReadLine();
            Console.Write("Nhap so luong cho ngoi: ");
            SoChoNgoi = int.Parse(Console.ReadLine());
        }

        public new void In()
        {
            base.In();
            Console.WriteLine($"Tai xe la: {TaiXe}");
            Console.Write($"So cho ngoi la: {SoChoNgoi}");
        }
    }
}
