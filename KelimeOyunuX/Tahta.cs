using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOyunu
{
    internal class Tahta
    {
        public Hucre[,] hucre = new Hucre[15, 15];
        public void OlusturTahta()
        {
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    hucre[i, j] = new Hucre();
                }
            }
        }
        public void ciz()
        {
            hucre[0, 2].harf = "K3";
            hucre[0, 12].harf = "K3";
            hucre[0, 5].harf = "H2";
            hucre[0, 9].harf = "H2";
            hucre[1, 1].harf = "H3";
            hucre[1, 13].harf = "H3";
            hucre[1, 8].harf = "H2";
            hucre[1, 6].harf = "H2";
            hucre[2, 0].harf = "K3";
            hucre[2, 7].harf = "K2";
            hucre[2, 14].harf = "K3";
            hucre[3, 3].harf = "K2";
            hucre[3, 11].harf = "K2";
            hucre[4, 4].harf = "H3";
            hucre[4, 10].harf = "H3";
            hucre[5, 0].harf = "K2";
            hucre[5, 5].harf = "H2";
            hucre[5, 9].harf = "H2";
            hucre[5, 14].harf = "K2";
            hucre[6, 1].harf = "H2";
            hucre[6, 6].harf = "H2";
            hucre[6, 8].harf = "H2";
            hucre[6, 13].harf = "H2";
            hucre[7, 2].harf = "K3";
            hucre[7, 7].harf = "K2";
            hucre[7, 12].harf = "K3";
            hucre[8, 1].harf = "H2";
            hucre[8, 6].harf = "H2";
            hucre[8, 8].harf = "H2";
            hucre[8, 13].harf = "H2";
            hucre[9, 0].harf = "K2";
            hucre[9, 5].harf = "H2";
            hucre[9, 9].harf = "H2";
            hucre[9, 14].harf = "K2";
            hucre[10, 4].harf = "H3";
            hucre[10, 10].harf = "H3";
            hucre[11, 3].harf = "K2";
            hucre[11, 11].harf = "K2";
            hucre[12, 0].harf = "K3";
            hucre[12, 7].harf = "K2";
            hucre[12, 8].harf = "K2";
            hucre[12, 14].harf = "K3";
            hucre[13, 1].harf = "H2";
            hucre[13, 6].harf = "H2";
            hucre[13, 13].harf = "H3";
            hucre[14, 2].harf = "K3";
            hucre[14, 5].harf = "K3";
            hucre[14, 12].harf = "K3";
            Console.WriteLine("Tahta Çizildi");
            // Üst çizgi
            Console.Write("      +");
            for (int col = 0; col < 15; col++)
                Console.Write("-----+");
            Console.WriteLine();
            Console.Write("      ");
            for (int col = 0; col < 15; col++)
                Console.Write($"| {col,2}  ");
            Console.Write("|");
            Console.WriteLine();





            for (int i = 0; i < 15; i++)
            {
                for (int k = 0; k < 16; k++)
                {

                    Console.Write("+");
                    Console.Write("-----");


                }
                Console.WriteLine();

                Console.Write($"| {i,2}  |");



                for (int j = 0; j < 15; j++)
                {
                    if (!hucre[i, j].BosMu())
                    {
                        Console.Write($" {hucre[i, j].harf,2}  |");
                    }
                    else
                    {
                        Console.Write("     |");
                    }

                    //Console.Write($"     |");
                }



                Console.WriteLine();
            }
        }
        public void HucreDoldur(int satir, int sutun, char harf)
        {
            if (satir >= 0 && satir < 15 && sutun >= 0 && sutun < 15)
            {
                if (hucre[satir, sutun].BosMu())
                {
                    hucre[satir, sutun].HarfEkle(harf);
                }
                else
                {
                    Console.WriteLine("Hücre dolu.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz hücre koordinatları.");
            }
        }

    }
}
