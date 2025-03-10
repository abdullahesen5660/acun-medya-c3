using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caseBreak_ArabaYası
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        {
           
            {
                Console.Write("Arabanızın yaşını girin: ");
                int yas = Convert.ToInt32(Console.ReadLine());

                switch (yas)
                {
                    case int y when (y >= 0 && y < 10):
                        Console.WriteLine("Arabanız yeni.");
                        break;
                    case int y when (y >= 10 && y < 20):
                        Console.WriteLine("Arabanızı servise götürmeniz gerekiyor.");
                        break;
                    case int y when (y >= 20 && y <= 30):
                        Console.WriteLine("Arabanız hurdaya çıkabilir.");
                        break;
                    default:
                        Console.WriteLine("Arabanız ya hiç üretilmedi ya da trafikten men edildi.");
                        break;
                }
            }
        }
    }
    }
}
