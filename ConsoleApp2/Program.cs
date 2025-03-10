using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("yaşınızı girin:  ");

            int yas = Convert.ToInt32(Console.ReadLine());
            if (yas >= 0 && yas < 18)
            {
                Console.WriteLine("küçüksünüz");
            }
            else if (yas >= 18 && yas < 35)
            {
                Console.WriteLine("gencsiniz");
            }
            else if (yas > 35 && yas < 55)
            {
                Console.WriteLine("yetişkinsiniz");
            }
            else if (yas > 55 && yas < 75)
            {
                Console.WriteLine("yaşlısnız");
            }
            else if (yas > 75 && yas < 99)
            {
                Console.WriteLine("çok yaşlısınız");
            }
            else 
                    {
                Console.WriteLine("ya doğmadınz ya da öldünüz");

            }
            





        }
    }
}
