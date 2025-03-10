using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arabaYası
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Araba yaşınızı giriniz: ");
            int arabaYası = Convert.ToInt32(Console.ReadLine());
            if (arabaYası >= 0 && arabaYası <= 10)
            {
                Console.WriteLine("arabanız yenidir");
            }
            else if (arabaYası > 10 && arabaYası <=20)
            {
                Console.WriteLine("arabanızı servise götürmeniz gerekiyor");
            }
            else if (arabaYası > 20 && arabaYası < 30)
            {
                Console.WriteLine("arabanız hurdaya çıkmıştır");

            }
            else
            {
                Console.WriteLine("arabanız ya hiç  üretilmedi ya da trafikte men edildi");

            }
            


        }
    }
}
