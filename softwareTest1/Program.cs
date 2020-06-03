using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softwareTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Triangle(1, 3, 3));
            Console.WriteLine(Date(2020, 11, 21));
            Console.Read();
        }

        public static string Triangle(int a, int b, int c)
        {
            string result = "";
            if (a == b && a == c)
            {
                result = "等边三角形";
            }
            else if (a == b || a == c  || b == c)
            {
                result = "等腰三角形";
            }
            return result;
        }

        public static string Date(int year, int month, int day)
        {
            string result = "";

            DateTime dateTime = new DateTime(year, month, day);
            dateTime = dateTime.AddDays(1);
            result = dateTime.ToString("yyyy年MM月dd日");

            return result;
        }
    }
}
