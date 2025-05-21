using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2tehtävät1_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ensimmäinen tehtävä
            Console.WriteLine("\nensimmäinen tehtävä");
            SayHello();

            //toinen tehtävä
            Console.WriteLine("\ntoinen tehtävä");
            Console.WriteLine("syötä nimesi: ");
            string käyttäjänimi = Console.ReadLine();
            Greet(käyttäjänimi);

            //kolmas tehtävä
            Console.WriteLine("\nkolmas tehtävä");
            Console.WriteLine("syötä kokonaisluku");
            bool totta = int.TryParse(Console.ReadLine(), out int kokonaisluku);
            if (totta)
            {
                Console.WriteLine("luvun neliö on " + Square(kokonaisluku));
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

            //neljäs tehtävä
            Console.WriteLine("\nneljäs tehtävä");
            Console.WriteLine("syötä ensimmäinen kokonaisluku");
            bool totta1 = int.TryParse(Console.ReadLine(),out int kokonaisluku1);
            Console.WriteLine("syötä toinen kokonaisluku: ");
            bool totta2 = int.TryParse(Console.ReadLine(), out int kokonaisluku2);
            if (totta2)
            {
                Console.WriteLine("kokonaislukujen summa on " + sum(kokonaisluku1, kokonaisluku2));
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

            //viides tehtävä
            Console.WriteLine("\nviides tehtävä");
            Console.WriteLine("syötä kokonaisluku: ");
            bool totta3 = int.TryParse(Console.ReadLine(), out int kokonaisluku3);
            if (totta3)
            {
                if (IsEven(kokonaisluku3))
                {
                    Console.WriteLine("syöttämäsi kokonaisluku on parillinen");
                }
                else
                {
                    Console.WriteLine("syöttämäsi kokonaisluku on pariton");
                }
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

            //kuudes tehtävä
            Console.WriteLine("\nkuudes tehtävä");
            int[] numerot = { 1, 2, 3, 4, 5, 6, };
            int taulukkoSumma = CalculateSum(numerot);
            Console.WriteLine($"taulukon lukujen summa on {taulukkoSumma}");

            //seitsämäs tehtävä
            Console.WriteLine("\nseitsämäs tehtävä");
            Console.WriteLine("Anna n (fibonacci sarjan kohta)");
            bool tosi = int.TryParse(Console.ReadLine(),out int fibn);
            if (tosi)
            {
                int tulos = Fibonacci(fibn);
                Console.WriteLine($"fibonacci-sarjan {fibn}. Luku on {tulos}");
            }
            

            //kahdeksas tehtävä
            Console.WriteLine("\nkahdeksas tehtävä");
            Console.WriteLine("syötä kuinka monta riviä tähtiä haluat kolmioon: ");
            bool tosi1 = int.TryParse(Console.ReadLine(), out int kolmiosyöte);
            PrintTriangle(kolmiosyöte);

            //yhdeksäs tehtävä
            Console.WriteLine("\nyhdeksäs tehtävä");
            int ensimmäinenluk = 5;
            int toinenluk = 10;
            Console.WriteLine($"ennen vaihtoa: a = {ensimmäinenluk}, b = {toinenluk}");
            Swap (ref ensimmäinenluk, ref toinenluk);
            Console.WriteLine($"vaihdon jälkeen: a = {ensimmäinenluk}, b = {toinenluk}");
        }
        //ensimmäinen teht
        static void SayHello()
        {
            Console.WriteLine("Hei maailma!");
        }
        //toinen tehtävä
        static void Greet (string nimi)
        {
            Console.WriteLine("Hei, " + nimi + "!");
        }
        //kolmas tehtävä
        static int Square (int a)
        {
            int neliö = a * a;
            return neliö;
        }
        //neljäs tehtävä
        static int sum (int x, int z)
        {
            int summa = x + z;
            return summa;
        }
        //viides tehtävä
        static bool IsEven (int c)
        {
            if (c %2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //kuudes tehtävä
        static int CalculateSum (int[] taulukko)
        {
            int sum = 0;
            foreach (int h in taulukko)
            {
                sum += h;
            }
            return sum;
        }
        //seitsämäs tehtävä
        static int Fibonacci (int n)
        {
            if (n <= 0) 
            {
                throw new ArgumentException("n täytyy olla suurempi kuin nolla");
            }
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return Fibonacci(n - 1) + (n - 2);
        }
        //kahdeksas tehtävä
        static void PrintTriangle (int j)
        {
            for (int o = 1; o <= j; o++)
            {
                Console.WriteLine(new string('*', o));
            }
        }
        //yhdeksäs tehtävä
        static void Swap (ref int u, ref int w)
        {
            int temp = u;
            u = w;
            w = temp;

        }

    }
}
