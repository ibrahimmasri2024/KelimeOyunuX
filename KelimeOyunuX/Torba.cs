using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOyunu
{
    static class Torba
    {


        public static tas[] taslarListesi1 = new tas[100];
        public static List<tas> taslarListesi = new List<tas>();
        public static char[] harfler = { 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'C', 'C', 'Ç', 'Ç', 'D', 'D', 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'I', 'I', 'I', 'İ', 'İ', 'İ', 'İ', 'İ', 'İ', 'İ', 'J', 'K', 'K', 'K', 'K', 'K', 'K', 'K', 'L', 'L', 'L', 'L', 'L', 'L', 'L', 'M', 'M', 'M', 'M', 'N', 'N', 'N', 'N', 'N', 'O', 'O', 'O', 'Ö', 'P', 'R', 'R', 'R', 'R', 'R', 'R', 'S', 'S', 'S', 'Ş', 'Ş', 'T', 'T', 'T', 'T', 'T', 'U', 'U', 'U', 'Ü', 'Ü', 'V', 'Y', 'Y', 'Z', 'Z', '*', '*' };
        public static void TorbaOlustur()
        {
            int[] puanlar = { 1, 3, 4, 4, 3, 1, 7, 5, 8, 5, 2, 1, 10, 1, 1, 2, 1, 2, 7, 5, 1, 2, 4, 1, 2, 4, 1, 2, 3, 7, 3, 4, 0 };
            int k = 1;
            for (int i = 0; i < 100; (i)++)
            {
                taslarListesi.Add(new tas());
            }
            taslarListesi[0].puan = 1;
            taslarListesi[0].harf = 'A';
            for (int j = 1; j < taslarListesi.Count - 1; j++)
            {
                taslarListesi[j].harf = harfler[j];
                if (taslarListesi[j].harf == taslarListesi[j - 1].harf)
                {
                    taslarListesi[j].puan = taslarListesi[j - 1].puan;
                }
                else
                {
                    taslarListesi[j].puan = puanlar[k];
                    k++;
                }

            }

        }
        public static void taslariYaz()
        {
            for (int i = 0; i < taslarListesi.Count; i++)
            {
                Console.WriteLine(taslarListesi[i].harf + " " + taslarListesi[i].puan + " " + i);
            }
        }

        public static void TorbayiKaristir()
        {
            Random rand = new Random();
            tas tasYedek = new tas();
            for (int i = 0; i < taslarListesi.Count; i++)
            {
                int j = rand.Next(0, taslarListesi.Count);
                tasYedek = taslarListesi[i];
                taslarListesi[i] = taslarListesi[j];
                taslarListesi[j] = tasYedek;

            }
        }
    }
}
