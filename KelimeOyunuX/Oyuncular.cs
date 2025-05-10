using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOyunu
{
    public class Oyuncular
    {
        public string isim;
        public string soyisim;
        public int puan = 0;
        public int kalanTasSayisi = 0;
        public tas[] taslar = new tas[7];


        public bool KelimeKontrol(string kelime)
        {
            int i = 0, j = 0;
            bool mevjut = false, mevjut1 = false;
            kelime = kelime.ToUpper();
            for (i = 0; i < kelime.Length; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    if (kelime[i] == taslar[j].harf)
                    {
                        // saat gibi kalime sıkıntılıdır
                        //puan += taslar[j].puan;
                        mevjut = true;

                    }
                }
                if (mevjut == false)
                {
                    Console.WriteLine("elinizde var olmayan harf girdiniz siraniziz kaypettiniz ");
                    break;
                }
                else
                {
                    mevjut = false;
                    if (j == 7 && i == kelime.Length - 1)
                    {
                        mevjut1 = true;
                    }
                }
            }
            if (mevjut1 == true)
            {
                // Console.WriteLine("kelime mevcut");
                for (int k = 0; k < kelime.Length; k++)
                {
                    for (int l = 0; l < 7; l++)
                    {
                        if (kelime[k] == taslar[l].harf)
                        {
                            puan += taslar[l].puan;
                        }
                    }





                }
                return true;
            }
            else
            {
                return false;
            }


        }

        public void Elgoster()
        {
            Console.WriteLine(isim + " " + soyisim);
            //Console.WriteLine("Oyuncunun soyismi: " + soyisim);
            Console.WriteLine("Oyuncunun puanı: " + puan);
            Console.WriteLine("Oyuncunun kalan taş sayısı: " + kalanTasSayisi);
            Console.WriteLine("Oyuncunun taşları: ");
            for (int i = 0; i < 7 - kalanTasSayisi; i++)
            {
                Console.WriteLine(taslar[i].harf + " " + taslar[i].puan);
            }
        }
        public void sharjEt()
        {

            for (int i = 0; i < 7 - kalanTasSayisi; i++)
            {
                taslar[i] = new tas();
                taslar[i].harf = Torba.taslarListesi.Last().harf;
                taslar[i].puan = Torba.taslarListesi.Last().puan;
                Torba.taslarListesi.RemoveAt(Torba.taslarListesi.Count - 1);
            }
        }
    }
}