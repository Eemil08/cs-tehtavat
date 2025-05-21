using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _10._3tehtävät1_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ensimmäinen tehtävä
            for (int i = 1; i <=25; i++)
            {
                Console.WriteLine($"luku: {i}");
            }

            //toinen tehtävä 

            Console.WriteLine("\ntoinen tehtävä");
            for (int x = 0; x<=20; x+=2)
            {
                Console.WriteLine(x);
            }

            //kolmas tehtävä

            Console.WriteLine("\nkolmas tehtävä");
            int summa = 0;
            for (int y = 0; y <= 100; y++)
            {
                summa += y;
                Console.WriteLine(summa);
            }

            //neljäs tehtävä

            Console.WriteLine("\nneljäs tehtävä");
            string tähti = "";
            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine($"\n{tähti += "*"}");
            }

            //viides tehtävä

            Console.WriteLine("\nviides tehtävä");
            int[,] matriisi = new int[5, 5];
            for (int luku = 1; luku <=5; luku++)
            {
                Console.Write(luku + " ");
            }
            Console.WriteLine();
            for (int luku1 = 2; luku1 <=10; luku1 +=2)
            {
                Console.Write(luku1 + " ");
            }
            Console.WriteLine();
            for (int luku2 = 3; luku2 <=15; luku2 +=3)
            {
                Console.Write(luku2 + " ");
            }
            Console.WriteLine();
            for (int luku3 = 4; luku3 <=20;  luku3 +=4)
            {
                Console.Write(luku3 + " ");
            }
            Console.WriteLine();
            for (int luku4 = 5; luku4 <=25; luku4 += 5)
            {
                Console.Write(luku4 + " ");
            }
            Console.WriteLine();

            //kuudes tehtävä
            Console.WriteLine("\nkuudes tehtävä");
            for (int a = 10; a <=20; a++)
            {
                Console.WriteLine(a + ":n neliö on " + a * a);
            }

            //seitsämäs tehtävä

            Console.WriteLine("\nseitsämäs tehtävä");
            for (int s = 100; s >= 90; s--)
            {
                Console.WriteLine(s);
            }
            
            //kahdeksas tehtävä

            Console.WriteLine("\nkahdeksas tehtävä");
            Console.WriteLine("syötä säästetty summa: ");
            bool totta = double.TryParse(Console.ReadLine(), out double säästöt);
            double korko = (5.0
                / 100) + 1;
            int vuodet = 10;
            if (totta)
            {
                for (int vuosi = 1; vuosi <= vuodet; vuosi++)
                {
                    säästöt *= korko;
                    Console.WriteLine(säästöt);
                }
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

            //yhdeksäs tehtävä

            Console.WriteLine("\nyhdeksäs tehtävä");
            int[] luvut = new int[3];
            luvut[0] = 10;
            luvut[1] = 20;
            luvut[2] = 30;
            Console.WriteLine($"taulukon ensimmäinen arvo: {luvut[0]}");
            Console.WriteLine($"taulukon toinen arvo: {luvut[1]}");
            Console.WriteLine($"taulukon kolmas arvo: {luvut[2]}");

            //kymmenes tehtävä

            Console.WriteLine("\nKymmenes tehtävä");
            Console.WriteLine("anna ensimmäinen kokonaisluku: ");
            bool totta1 = int.TryParse(Console.ReadLine(), out int eka);
            Console.WriteLine("anna toinen kokonaisluku: ");
            bool totta2 = int.TryParse(Console.ReadLine(), out int toka);
            Console.WriteLine("anna kolmas kokonaisluku: ");
            bool totta3 = int.TryParse(Console.ReadLine(), out int kolmas);
            Console.WriteLine("anna neljäs kokonaisluku: ");
            bool totta4 = int.TryParse(Console.ReadLine(), out int neljäs);
            Console.WriteLine("anna viides kokonaisluku: ");
            bool totta5 = int.TryParse(Console.ReadLine(), out int viides);
            if (totta1 && totta2 && totta3 && totta4 && totta5)
            {
                int[] kokonaisluvut = new int[5];
                kokonaisluvut[0] = eka;
                kokonaisluvut[1] = toka;
                kokonaisluvut[2] = kolmas;
                kokonaisluvut[3] = neljäs;
                kokonaisluvut[4] = viides;
                Console.WriteLine("\nensimmäinen syöte: " + kokonaisluvut[0]);
                Console.WriteLine("toinen syöte: " + kokonaisluvut[1]);
                Console.WriteLine("kolmas syöte: " + kokonaisluvut[2]);
                Console.WriteLine("neljäs syöte: " + kokonaisluvut[3]);
                Console.WriteLine("viides syöte: " + kokonaisluvut[4]);
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

            //yhdestoista tehtävä

            Console.WriteLine("\nyhdestoista tehtävä");
            Console.WriteLine("syötä kokonaisluku: ");
            bool totta6 = int.TryParse(Console.ReadLine(), out int kokonais1);
            Console.WriteLine("syötä toinen kokonaisluku: ");
            bool totta7 = int.TryParse(Console.ReadLine(), out int kokonais2);
            Console.WriteLine("syötä kolmas kokonaisluku: ");
            bool totta8 = int.TryParse(Console.ReadLine(), out int kokonais3);
            if (totta6 && totta7 && totta8)
            {
                int[] taulukko = new int[3];
                taulukko[0] = kokonais1;
                taulukko[1] = kokonais2;
                taulukko[2] = kokonais3;
                Array.Sort(taulukko);
                Console.WriteLine($"pienin on {taulukko[0]}");
                Array.Reverse(taulukko);
                Console.WriteLine($"suurin on {taulukko[0]}");
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

            //kahdestoista tehtävä

            Console.WriteLine("\nkahdestoista tehtävä");
            Console.WriteLine("anna kokonaisluku taulukkoon: ");
            bool totta9 = int.TryParse(Console.ReadLine(), out int syöte);
            Console.WriteLine("anna toinen kokonaisluku taulukkoon: ");
            bool totta10 = int.TryParse(Console.ReadLine(), out int syöte1);
            Console.WriteLine("anna kolmas kokonaisluku taulukkoon: ");
            bool totta11 = int.TryParse(Console.ReadLine(), out int syöte2);
            int[]Taulukko = new int[3];
            int keskiarvo = Taulukko.Length;
            Taulukko[0] = syöte;
            Taulukko[1] = syöte1;
            Taulukko[2] = syöte2;
            if (totta9 && totta10 && totta11)
            {
                Console.WriteLine($"lukujen keskiarvo on: {(Taulukko[0] + Taulukko[1] + Taulukko[2]) / keskiarvo}");
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

            //kolmastoista tehtävä

            Console.WriteLine("\nkolmastoista tehtävä");
            Console.WriteLine("anna taulukkoon kokonaisluku: ");
            bool totta12 = int.TryParse(Console.ReadLine(), out int kokonaisluku);
            Console.WriteLine("anna taulukkoon toinen kokonaisluku: ");
            bool totta13 = int.TryParse(Console.ReadLine(), out int kokonaisluku1);
            Console.WriteLine("anna taulukkoon kolmas kokonaisluku: ");
            bool totta14 = int.TryParse(Console.ReadLine(),out int kokonaisluku2);
            int[]taulukkoA = new int[3];
            if (totta12 && totta13 && totta14)
            {
                taulukkoA[0] = kokonaisluku;
                taulukkoA[1] = kokonaisluku1;
                taulukkoA[2] = kokonaisluku2;
                Array.Reverse(taulukkoA);
                Console.WriteLine("kokonaisluvut käännettynä toisessa järjestyksessä");
                Console.WriteLine(taulukkoA[0]);
                Console.WriteLine(taulukkoA[1]);
                Console.WriteLine(taulukkoA[2]);
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

            //neljästoista tehtävä

            Console.WriteLine("\nneljästoista tehtävä");
            Console.WriteLine("arvaa luku taulukosta: ");
            bool totta15 = int.TryParse(Console.ReadLine(), out int taulukkonumero);
            int[] numerot = new int[3];
            bool löytyi = false;
            numerot[0] = 1;
            numerot[1] = 2;
            numerot[2] = 3;
            if (totta15)
            {
                foreach (int numero in numerot)
                {
                    if (numero.Equals(taulukkonumero))
                    {
                        löytyi = true;
                        break;
                    }
                }
                if (löytyi)
                {
                    Console.WriteLine($"{taulukkonumero} löytyy taulukosta");
                }
                else
                {
                    Console.WriteLine($"{taulukkonumero} ei löydy taulukosta");
                }

            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }
            

            //viidestoista tehtävä

            Console.WriteLine("\nviidestoista tehtävä");
            Console.WriteLine("syötä ensimmäiseen taulukkoon ensimmäinen numero: ");
            bool totta16 = double.TryParse(Console.ReadLine(), out double ekanum);
            Console.WriteLine("syötä ensimmäiseen taulukkoon toinen numero");
            bool totta17 = double.TryParse(Console.ReadLine(), out double tokanum);
            Console.WriteLine("syötä toiseen taulukkoon ensimmäinen numero: ");
            bool totta18 = double.TryParse(Console.ReadLine(), out double ekanum1);
            Console.WriteLine("syötä toiseen taulukkoon toinen numero: ");
            bool totta19 = double.TryParse(Console.ReadLine(),out double tokanum1);
            double[]EkaTaulukko = new double[2];
            EkaTaulukko[0] = ekanum;
            EkaTaulukko[1] = tokanum;
            double[] TokaTaulukko = new double[2];
            TokaTaulukko[0] = ekanum1;
            TokaTaulukko[1] = tokanum1;
            if (totta16 && totta17  && totta18 && totta19)
            {
                double[]YhdTaulukko = new double[EkaTaulukko.Length + TokaTaulukko.Length];
                Array.Copy(EkaTaulukko, 0,  YhdTaulukko, 0, EkaTaulukko.Length);
                Array.Copy(TokaTaulukko, 0, YhdTaulukko, EkaTaulukko.Length,  TokaTaulukko.Length);
                for (int s = 0; s < YhdTaulukko.Length; s++)
                {
                    Console.WriteLine("\n" + YhdTaulukko[s]);
                }
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

            //kuudestoista tehtävä
            Console.WriteLine("\nkuudestoista tehtävä");
            int[,] teht16 =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            for (int d = 0; d < teht16.GetLength(0); d++)
            {
                for (int w = 0; w < teht16.GetLength(1); w++)
                {
                    Console.Write(teht16[d, w] + " ");
                }
                Console.WriteLine();
            }

            //seitsämästoista tehtävä

            Console.WriteLine("\nseitsämästoista tehtävä");
            Console.WriteLine("aseta taulukkoon ensimmäinen luku: ");
            bool totta20 = double.TryParse(Console.ReadLine(), out double ensimmäinen1);
            Console.WriteLine("aseta taulukkoon toinen luku: ");
            bool totta21 = double.TryParse(Console.ReadLine(), out double toinen1);
            Console.WriteLine("aseta taulukkoon kolmas luku: ");
            bool totta22 = double.TryParse(Console.ReadLine(), out double kolmas1);
            double[] LukuTaulukko = new double[3];
            LukuTaulukko[0] = ensimmäinen1;
            LukuTaulukko[1] = toinen1;
            LukuTaulukko[2] = kolmas1;
            if (totta20 && totta21 && totta22)
            {
                Array.Sort(LukuTaulukko);
                Console.WriteLine($"luvut suurimmasta pienimpään tulostettuna: {LukuTaulukko[0]} ,{LukuTaulukko[1]} ,{LukuTaulukko[2]}");
            }
        }
    }
}
