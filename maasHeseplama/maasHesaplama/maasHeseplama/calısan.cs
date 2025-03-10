using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maasHeseplama
{
   
    

class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Meslek { get; set; }
        public double Maas { get; set; }
        public string Departman { get; set; }

        public Calisan(string ad, string soyad, string meslek, double maas, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Meslek = meslek;
            Maas = maas;
            Departman = departman;
        }

        public void BilgiYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Meslek: {Meslek}, Maaş: {Maas} TL, Departman: {Departman}");
        }
    }

    class Program
    {
        static void Main()
        {
            List<Calisan> calisanlar = new List<Calisan>
        {
            new Calisan("abdullah ", "esen", "Genel Müdür", 50000, "Yönetim"),
            new Calisan("Mehmet", "Demir", "Müdür", 30000, "Finans"),
            new Calisan("Zeynep", "Kara", "Programcı", 20000, "IT"),
            new Calisan("Ali", "Çelik", "Stajyer", 10000, "İnsan Kaynakları")
        };

            double toplamMaas = 0;
            Console.WriteLine("Çalışan Listesi:\n");

            foreach (var calisan in calisanlar)
            {
                calisan.BilgiYazdir();
                toplamMaas += calisan.Maas;
            }

            Console.WriteLine($"\nToplam Maaş: {toplamMaas} TL");
        }
    }
}

