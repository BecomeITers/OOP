using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mối_quan_hệ
{
    internal class DiaChi
    {
        private string _Quan;
        private string _TP;
        public string Quan
        {
            get { return _Quan; }
            set { _Quan = value; }
        }
        public string TP
        {
            get { return _TP; }
            set { _TP = value; }
        }
        public DiaChi()
        {
            Quan = TP = "";
        }
        public DiaChi(string quan, string tP)
        {
            this.Quan = quan;
            this.TP = tP;
        }
        public string HienThi()
        {
            return $"{Quan} - {TP}";
        }
    }
}
