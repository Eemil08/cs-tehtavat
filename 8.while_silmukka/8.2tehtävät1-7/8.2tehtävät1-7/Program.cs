using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8._2tehtävät1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ensimmäinen tehtävä
            Console.WriteLine("ensimmäinen tehtävä");

            int i = 0;
            while (i < 10)
            {
                i++;
                Console.WriteLine(i);
            }

            //toinen tehtävä
            Console.WriteLine("\ntoinen tehtävä");

            int a = 0;
            while (a < 100)
            {
                a++;
                if (a % 2 == 0 || a % 3 == 0)
                {
                    Console.WriteLine(a);
                }
            }

            //kolmas tehtävä
            Console.WriteLine("\nkolmas tehtävä");
            Console.WriteLine("syötä luku: ");
            bool totta = double.TryParse(Console.ReadLine(), out double luku);
            if (totta)
            {
                while (luku > 0)
                {
                    Console.WriteLine("\nsyötä luku (lopeta silmukka syöttämällä negatiivinen luku): ");
                    double syöttö = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{luku + syöttö}");
                    luku = luku + syöttö;
                    if (syöttö < 0)
                    {
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("virheellinen syöttö");
            }

            //neljäs tehtävä
            
            Console.WriteLine("\n neljäs tehtävä");
            Random rand = new Random();
            int salainenluku = rand.Next(1, 101);
            Console.WriteLine("arvaa salainen luku (1-100): ");
            bool totta1 = int.TryParse(Console.ReadLine(), out int arvaus);
            if (totta1)
            {
                while (true)
                {
                    if (arvaus == salainenluku)
                    {
                        Console.WriteLine("sait luvun oikein");
                        break;
                    }
                    string väärin = "väärin meni";
                    if (arvaus < salainenluku)
                    {
                        Console.WriteLine(väärin + " ,liian pieni");
                    }
                    if (arvaus > salainenluku)
                    {
                        Console.WriteLine(väärin + " ,liian suurin");

                    }
                    arvaus = int.Parse(Console.ReadLine());
                }
                
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }
            

            //viides tehtävä

            Console.WriteLine("\nviides tehtävä");
            int eka = 0;
            int toka = 1;
            Console.WriteLine(eka);
            Console.WriteLine(toka);
            int seuraava = 0;
            int k = 2;
            while (k < 10)
            {
                seuraava = eka + toka;
                Console.WriteLine(seuraava);
                eka = toka;
                toka = seuraava;
                k++;
            }

            //kuudes tehtävä

            Console.WriteLine("\nkymmenes tehtävä");
            Console.WriteLine("syötä kokonaisluku väliltä 1-10: ");
            bool tosi = int.TryParse(Console.ReadLine(), out int kokonaisluku);
            int kertoma = 1;
            Console.WriteLine($"luvun {kokonaisluku} kertotaulu: ");
            Console.WriteLine(kokonaisluku);
            if (tosi)
            {
                while (kertoma < 10)
                {
                    kertoma++;
                    Console.WriteLine($"\n{kokonaisluku * kertoma}");
                }
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }


            //seitsämäs tehtävä

            Console.WriteLine("\nseitsämäs tehtävä");
            Console.WriteLine("aseta tilille säästetty summa: ");
            bool totta2 = double.TryParse(Console.ReadLine(), out double säästetty);
            Console.WriteLine("aseta korkoprosentti (vain numero): ");
            bool totta3 = double.TryParse(Console.ReadLine(), out double korko);
            Console.WriteLine("aseta tavoitesumma: ");
            bool totta4 = double.TryParse(Console.ReadLine(), out double tavoite);
            int määrä = 0;
            korko = korko / 100;
            if (totta2 && totta3 &&  totta4)
            {
                while (säästetty < tavoite)
                {
                    määrä++;
                    säästetty = säästetty * (1 + korko);
                    Console.WriteLine(määrä + "kerta: " + Math.Round(säästetty),2);
                }
            }
            else if (säästetty > tavoite)
            {
                Console.WriteLine("virheelliset arvot(säästetty summa > tavoitesumma");
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }
        }
    }
}
