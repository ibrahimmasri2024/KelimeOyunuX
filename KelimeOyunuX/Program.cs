using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOyunu
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int sira = 1;
            int x1, y1, x2, y2;
            string kelime;




            Tahta tahta = new Tahta();
            tahta.OlusturTahta();
            tahta.ciz();
            ////////////  
            Torba.TorbaOlustur();
            Torba.TorbayiKaristir();
            Oyuncular O1 = new Oyuncular();
            Oyuncular O2 = new Oyuncular();
            //torba.taslariYaz();  
            // Console.WriteLine(torba.harfler.Length);  



            //Console.WriteLine("1. Oyuncunun ismini giriniz");
            //O1.isim = Console.ReadLine();
            //Console.WriteLine("1. Oyuncunun soyismini giriniz");
            //O1.soyisim = Console.ReadLine();
            //Console.WriteLine("2. Oyuncunun ismini giriniz");
            //O2.isim = Console.ReadLine();
            //Console.WriteLine("2. Oyuncunun soyismini giriniz");
            //O2.soyisim = Console.ReadLine();
            O1.isim = "Ali";
            O2.isim = "Veli";


            ////////////////////////////////
            for (int k = 0; k < 7; k++)
            {
                if (sira == 1)
                {
                    O1.sharjEt();
                    O1.Elgoster();
                    Console.WriteLine($"{O1.isim} Cordinatlarini gir ");
                    Console.Write(" x1: ");
                    x1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" --  y1: ");
                    y1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" --  x2: ");
                    x2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" --  y2: ");
                    y2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("gireceğiniz kelime yaziniz ");
                    kelime = Console.ReadLine();
                    if (O1.KelimeKontrol(kelime))
                    {
                        for (int i = 0; i < kelime.Length; i++)
                        {
                            if (x1 == x2)
                            {
                                tahta.HucreDoldur(x1, y1 + i, kelime[i]);
                            }
                            else if (y1 == y2)
                            {
                                tahta.HucreDoldur(x1 + i, y1, kelime[i]);
                            }
                        }
                    }
                    Console.Clear();


                    tahta.ciz();
                    sira = 2;

                }
                else
                {
                    O2.sharjEt();
                    O2.Elgoster();
                    Console.WriteLine($"{O2.isim} Cordinatlarini gir ");
                    Console.WriteLine("x1: ");
                    x1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" --  y1: ");
                    y1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" --  x2: ");
                    x2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" --  y2: ");
                    y2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("gireceğiniz kelime yaziniz ");
                    kelime = Console.ReadLine();
                    if (O2.KelimeKontrol(kelime))
                    {
                        for (int i = 0; i < kelime.Length; i++)
                        {
                            if (x1 == x2)
                            {
                                tahta.HucreDoldur(x1, y1 + i, kelime[i]);
                            }
                            else if (y1 == y2)
                            {
                                tahta.HucreDoldur(x1 + i, y1, kelime[i]);
                            }
                        }
                    }


                    Console.Clear();


                    tahta.ciz();
                    sira = 1;
                }

                //////////////
                //Console.WriteLine($"{O1.isim} oyuncunun taslari ");
                //Console.WriteLine(O1.taslar[0] + " " + O1.taslar[1] + " " + O1.taslar[2] + " " + O1.taslar[3] + " " + O1.taslar[4] + " " + O1.taslar[5] + " " + O1.taslar[6]);

                //Console.WriteLine($"{O1.isim}oyuncunun taslari ");
                //Console.WriteLine(O2.taslar[0] + " " + O2.taslar[1] + " " + O2.taslar[2] + " " + O2.taslar[3] + " " + O2.taslar[4] + " " + O2.taslar[5] + " " + O2.taslar[6]);


                //Console.WriteLine($"{O1.isim} Cordinatlarini gir ");
                //Console.WriteLine("x1: ");
                // x1 = Convert.ToInt32(Console.ReadLine());
                //Console.Write(" --  y1: ");
                // y1 = Convert.ToInt32(Console.ReadLine());
                //Console.Write(" --  x2: ");
                // x2 = Convert.ToInt32(Console.ReadLine());
                //Console.Write(" --  y2: ");
                // y2 = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("gireceğiniz kelime yaziniz ");
                // kelime = Console.ReadLine();
                //for (int i = 0; i < kelime.Length; i++)
                //{
                //    if (x1 == x2)
                //    {
                //        tahta.HucreDoldur(x1, y1 + i, O1.taslar[i].harf);
                //    }
                //    else if (y1 == y2)
                //    {
                //        tahta.HucreDoldur(x1 + i, y1, O1.taslar[i].harf);
                //    }
                //}
                //Console.Clear();


                //tahta.ciz();
            }

        }
    }
}