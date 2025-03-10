using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Mercedes : Araba
    {
        public Mercedes()
        {
            Model = "mercedes";
        }
        public override double YakitTuketimiHesapla()
        {
            return 60.0; 
        }
    }
}
