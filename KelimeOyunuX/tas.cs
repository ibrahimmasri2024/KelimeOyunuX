using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOyunu
{
    public class tas
    {
        public char harf;
        public int puan;
        public void bilgiYaz()
        {
            Console.WriteLine("Taşın harfi: " + harf);
            Console.WriteLine("Taşın puanı: " + puan);
        }
    }
}
