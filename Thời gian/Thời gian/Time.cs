using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Thời_gian
{
    public class Time
    {
        private int _hour;
        private int _minute;
        private int _second;
        public int Hour
        {

            get { return _hour; }
            set
            {
                if (value < 0 || value > 23) {
                    throw new ArgumentException("Invalid Hour"); };
                _hour = value;
            }
        }
        public int Minute
        {
            get { return _minute; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("Invalid Minute");
                };
                _minute = value;

            }
        } 
        public int Second
        {
            get { return _second; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("Invalid Second");
                }
                _second = value;
            }
        }
        public Time()
        {
            Hour = Minute = Second = 0;
        }
        public Time(int hour, int minute, int second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap gio: ");
            Hour = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap phut: ");
            Minute = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap giay: ");
            Second = int.Parse(Console.ReadLine());
        }
        public string toString()
        {
            return $"{Hour}:{Minute}:{Second}";
        }
        public string NextSecond()
        {
            return $"{Hour}:{Minute}:{Second + 1}";
        }
        public string PreviousSecond()
        {
            return $"{Hour}:{Minute}:{Second - 1}";
        }
    }
}
