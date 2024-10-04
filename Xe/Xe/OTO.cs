using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xe
{
    internal class OTO : XE
    {
        public int SoChoNgoi {  get; set; }
        public double TrongTai { get; set; }
        
        public OTO() : base()
        {
            SoChoNgoi = 0;
            TrongTai = 0;
        }

        public OTO(int soChoNgoi, double trongTai, string nhanHieu, int gia, int namSX) : base(nhanHieu, gia, namSX)
        {
            this.SoChoNgoi= soChoNgoi;
            this.TrongTai= trongTai;
        }

        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so luong cho ngoi: ");
            SoChoNgoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap trong tai xe: ");
            TrongTai= int.Parse(Console.ReadLine());
        }

        public new void In()
        {
            base.In();
            Console.WriteLine($"So luong cho ngoi la: {SoChoNgoi}");
            Console.WriteLine($"Trong tai cua xe la: {TrongTai}");
        }
    }
}
