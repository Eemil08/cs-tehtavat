using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._7tehtävät1_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(ensimmäinen tehtävä)");
            Console.WriteLine("anna luku: ");
            bool totta = int.TryParse(Console.ReadLine(), out int eka);
            Console.WriteLine("anna toinen luku");
            bool totta1 = int.TryParse(Console.ReadLine(), out int toka);

            if (totta && totta1)
            {
                Console.WriteLine("lukujen summa on " + eka + toka);
                Console.WriteLine("lukujen erotus on " + (eka - toka));
                Console.WriteLine("lukujen tulo on " + eka * toka);
                Console.WriteLine("lukujen osamäärä on " + eka / toka);
                Console.WriteLine("lukujen jakojäännös on " + eka % toka);

            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

            //toka tehtävä
            Console.WriteLine("(toinen tehtävä)");

            Console.WriteLine("anna luku: ");
            bool totta2 = double.TryParse(Console.ReadLine(), out double ens);
            Console.WriteLine("anna toinen luku: ");
            bool totta3 = double.TryParse(Console.ReadLine(), out double tok);

            if (totta2 && totta3)
            {
                if (ens == tok)
                {
                    Console.WriteLine("luvut ovat samansuuruiset");
                }
                if (ens != tok)
                {
                    Console.WriteLine("luvut ovat erisuuruiset");
                    if (ens < tok)
                    {
                        Console.WriteLine("ensimmäinen luku " + ens + " on pienempi kuin " + tok);
                    }
                    if (ens > tok)
                    {
                        Console.WriteLine("ensimmäinen luku " + ens + "on suurempi kuin " + tok);
                    }
                }
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

            //kolmas teht
            Console.WriteLine("(kolmas tehtävä)");

            Console.WriteLine("syötä totuusarvo (tosi / epätosi): ");
            string tekstisyöte = Console.ReadLine();
            bool syöte1 = oikSyöte(tekstisyöte);
            Console.WriteLine("syötä toinen totuusarvo (tosi / epätosi): ");
            string tekstisyöte1 = Console.ReadLine();
            bool syöte2 = oikSyöte(tekstisyöte1);
            if((tekstisyöte == "tosi" || tekstisyöte == "epätosi") && (tekstisyöte1 == "tosi" || tekstisyöte1 == "epätosi"))
            {
                Console.WriteLine("and: " + (syöte1 && syöte2));
                Console.WriteLine("or: " + (syöte1 || syöte2));
                Console.WriteLine("not: " + (!syöte1 && !syöte2));
            }


            //neljäs teht

            Console.WriteLine("(neljäs tehtävä)");
            Console.WriteLine("anna luku: ");
            bool totta4 = double.TryParse(Console.ReadLine(), out double luku);
            if (totta4)
            {
                luku += 5;
                luku *= 2;
                luku /= 3;
                Console.WriteLine(luku);
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

            //viides teht

            Console.WriteLine("(viides tehtävä)");
            Console.WriteLine("anna luku: ");
            bool totta5 = int.TryParse(Console.ReadLine(), out int luku1);
            if (totta5)
            {
                if (luku1 % 2 == 0)
                {
                    Console.WriteLine("luku on parillinen");
                }
                else
                {
                    Console.WriteLine("luku on pariton");
                }
                if (luku1 % 3 == 0)
                {
                    Console.WriteLine("luku on jaollinen kolmella");
                }
                else
                {
                    Console.WriteLine("luku ei ole kolmella jaollinen");
                }
            }
            else
            {
                Console.WriteLine("virheellinen syöttö");
            }

            //kuudes teht

            Console.WriteLine("(kuudes teht)");
            Console.WriteLine("anna kokonaisluku");
            bool kl1 = int.TryParse(Console.ReadLine(), out int kok1);
            Console.WriteLine("anna toinen kokonaisluku");
            bool kl2 = int.TryParse(Console.ReadLine(), out int kok2);
            if (kl1 && kl2)
            {
                Console.WriteLine("AND " + (kok1 & kok2));
                Console.WriteLine("OR " + (kok1 | kok2));
                Console.WriteLine("XOR " + (kok1 ^ kok2));
                Console.WriteLine("vasen siirto " + (kok1 << kok2));
                Console.WriteLine("oikea siirto " + (kok1 >> kok2));
            }
            else
            {
                Console.WriteLine("virheellinen syöttö");
            }

            //seitsämäs teht

            Console.WriteLine("seitsämäs tehtävä");
            Console.WriteLine("anna luku: ");
            bool kl3 = double.TryParse(Console.ReadLine(), out double kok3);
            if (kl3)
            {
                string tulos = (kok3 > 0) ? "luku on positiivinen" : (kok3 < 0) ? "luku on negatiivinen" : "luku on nolla";
                Console.WriteLine(tulos);
            }

            else
            {
                Console.WriteLine("virheellinen syöte");
            }

            //kahdeksas teht
            Console.WriteLine("kahdeksas tehtävä");

            Console.WriteLine("syötä kokonaisluku");
            bool totta6 = int.TryParse(Console.ReadLine(), out int kokluk1);
            Console.WriteLine("syötä toinen kokonaisluku");
            bool totta7 = int.TryParse(Console.ReadLine(), out int kokluk2);   
            Console.WriteLine("syötä kolmas kokonaisluku");
            bool totta8 = int.TryParse(Console.ReadLine(),out int kokluk3);
            bool kasvava = (kokluk1 < kokluk2) && kokluk2 < kokluk3;
            bool laskeva = (kokluk3 > kokluk2) && kokluk2 > kokluk1;
            bool kaikkisama = (kokluk1 == kokluk2) && (kokluk2 == kokluk3);
            if (totta6 && totta7 && totta8)
            {
                string tulos = (kasvava ? "kyllä" : "ei");
                string tulos1 = (laskeva ? "kyllä" : "ei");
                string tulos2 = (kaikkisama ? "kyllä" : "ei");
                Console.WriteLine("kasvava järjestys: " + tulos);
                Console.WriteLine("laskeva järjestys: " + tulos1);
                Console.WriteLine("kaikki samat: " + tulos2);
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

            //yhdeksäs teht

            int vasenX = 0;
            int oikeaX = 10;
            int AlaY = 0;
            int YläY = 10;

            Console.WriteLine("yhdeksäs tehtävä");
            Console.WriteLine("syötä kordinaatti X: ");
            bool totta9 = double.TryParse(Console.ReadLine(), out double k1);
            Console.WriteLine("syötä kordinaatti Y: "); 
            bool totta10 = double.TryParse(Console.ReadLine(), out double k2);
            bool sisällä = (k1 >= vasenX && k1 <= oikeaX) && (k2 >= AlaY && k2 <= YläY);
            if (totta9 && totta10)
            {
                if (sisällä)
                {
                    Console.WriteLine("sisällä");
                }
                else
                {
                    Console.WriteLine("ulkona");
                }
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }
        }
       static bool oikSyöte(string syöte)
        {
            return syöte == "tosi" || !(syöte == "epätosi");
        }
    }
}