using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bất_động_sản
{
    public abstract class BDS
    {
        public string maSo { get; set; }
        public double chieuDai { get; set; }
        public double chieuRong { get; set; }

        public BDS()
        {
            maSo = string.Empty;
            chieuDai = 0;
            chieuRong = 0;
        }
        public BDS(string maSo, double chieuDai, double chieuRong)
        {
            this.maSo = maSo;
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
        }
        public virtual double DienTich()
        {
            return chieuDai * chieuRong;
        }
        public virtual double GiaTri()
        {
            return chieuDai * chieuRong * 10000;
        }

        public virtual string Print()
        {
            return $"Ma so: {maSo}, Chieu dai: {chieuDai}, Chieu rong: {chieuRong}";
        }
    }

    public class DatTrong : BDS
    {
        public DatTrong() : base()
        {

        }

        public DatTrong(string maSo, double chieuDai, double chieuRong) : base(maSo, chieuDai, chieuRong)
        {

        }

        public override double GiaTri()
        {
            return chieuDai * chieuRong * 30000000;
        }
        public override string Print()
        {
            return $"Ma so: {maSo}, Chieu dai: {chieuDai}, Chieu rong: {chieuRong}, Gia tri: {GiaTri()}";
        }

        public override double DienTich()
        {
            return chieuDai * chieuRong;
        }
    }

    public class NhaO : BDS
    {
        public int soLau { get; set; }
        public NhaO() : base()
        {
            soLau = 0;
        }
        public NhaO(string maSo, double chieuDai, double chieuRong, int soLau) : base(maSo, chieuDai, chieuRong)
        {
            this.soLau = soLau;
        }
        public override double GiaTri()
        {
            return chieuDai * chieuRong * 60000000 + (soLau * 100000000);
        }
        public override string Print()
        {
            return $"Ma so: {maSo}, Chieu dai: {chieuDai}, Chieu rong: {chieuRong}, Gia tri: {GiaTri()}";
        }
        public override double DienTich()
        {
            return chieuDai * chieuRong;
        }
    }

    public class KhachSan : BDS
    {
        public int soSao { get; set; }
        public KhachSan() : base()
        {
            soSao = 0;
        }
        public KhachSan(string maSo, double chieuDai, double chieuRong, int soSao) : base(maSo, chieuDai, chieuRong)
        {
            this.soSao = soSao;
        }
        public override double GiaTri()
        {
            return chieuDai * chieuRong * 70000000 + (soSao * 50000000);
        }
        public override string Print()
        {
            return $"Ma so: {maSo}, Chieu dai: {chieuDai}, Chieu rong: {chieuRong}, Gia tri: {GiaTri()}";
        }
        public override double DienTich()
        {
            return chieuDai * chieuRong;
        }
    }

    public class BietThu : BDS
    {
        public BietThu() : base()
        {

        }
        public BietThu(string maSo, double chieuDai, double chieuRong) : base(maSo, chieuDai, chieuRong)
        {

        }
        public override double GiaTri()
        {
            return chieuDai * chieuRong * 100000000;
        }
        public override string Print()
        {
            return $"Ma so: {maSo}, Chieu dai: {chieuDai}, Chieu rong: {chieuRong}, Gia tri: {GiaTri()}";
        }
        public override double DienTich()
        {
            return chieuDai * chieuRong;
        }
    }
}
