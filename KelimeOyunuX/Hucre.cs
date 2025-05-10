using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOyunu
{
    public class Hucre
    {
        public string harf = null;
        public int puan;

        public bool BosMu()
        {
            return harf == null;
        }
        public void HarfEkle(char harf)
        {
            this.harf = harf.ToString();
        }





    }
}
