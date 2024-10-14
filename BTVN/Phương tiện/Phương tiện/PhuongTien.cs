using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Phương_tiện
{
    public abstract class PhuongTien
    {
        public string hangSanXuat {  get; set; }
        public int namSanXuat { get; set;}
        public double giaBan {  get; set; }
        public string mau {  get; set; }

        public PhuongTien()
        {
            hangSanXuat = string.Empty;
            namSanXuat = 0;
            giaBan = 0.0;
            mau = string.Empty;
        }

        public PhuongTien(string hangSanXuat, int namSanXuat, double giaBan, string mau)
        {
            this.hangSanXuat = hangSanXuat;
            this.namSanXuat = namSanXuat;
            this.giaBan = giaBan;
            this.mau = mau;
        }

        public virtual string toString()
        {
            return $"Hang san xuat: {hangSanXuat}, Nam san xuat: {namSanXuat}, Gia ban: {giaBan}, Mau: {mau}";
        }
    }

    public class Oto : PhuongTien
    {
        public int soNgoi { get; set; }
        public string kieuDongCo { get; set; }

        public Oto() : base()
        {
            soNgoi = 0;
            kieuDongCo = string.Empty;
        }

        public Oto(string hangSanXuat, int namSanXuat, double giaBan, string mau, int soNgoi, string kieuDongCo) : base(hangSanXuat, namSanXuat, giaBan, mau)
        {
            this.soNgoi = soNgoi;
            this.kieuDongCo = kieuDongCo;
        }

        public override string toString()
        {
            return $"Hang san xuat: {hangSanXuat}, Nam san xuat: {namSanXuat}, Gia ban: {giaBan}, Mau: {mau}, So cho ngoi: {soNgoi}, Kieu dong co: {kieuDongCo}";
        }
    }

    public class XeMay : PhuongTien
    {
        public string congSuat { get; set; }

        public XeMay() : base()
        {
            congSuat = string.Empty;
        }

        public XeMay(string hangSanXuat, int namSanXuat, double giaBan, string mau, string congSuat) : base(hangSanXuat, namSanXuat, giaBan, mau)
        {
            this.congSuat = congSuat;
        }

        public override string toString()
        {
            return $"Hang san xuat: {hangSanXuat}, Nam san xuat: {namSanXuat}, Gia ban: {giaBan}, Mau: {mau}, Cong suat: {congSuat}";
        }
    }

    public class XeTai : PhuongTien
    {
        public double trongTai { get; set; }

        public XeTai() : base()
        {
            trongTai = 0.0;
        }

        public XeTai(string hangSanXuat, int namSanXuat, double giaBan, string mau, double trongTai) : base(hangSanXuat, namSanXuat, giaBan, mau)
        {
            this.trongTai = trongTai;
        }

        public override string toString()
        {
            return $"Hang san xuat: {hangSanXuat}, Nam san xuat: {namSanXuat}, Gia ban: {giaBan}, Mau: {mau}, Trong tai: {trongTai}";
        }
    }
}
