using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _11._2tehtävät1_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            
            //ensimmäinen tehtävä
            List<int> LukuLista = Enumerable.Range(1, 10).ToList();
            int listasum = LukuLista.Sum();
            Console.WriteLine("listan lukujen summa on " + listasum);

            //toinen tehtävä
            Console.WriteLine("\ntoinen tehtävä");
            List<int> ParitonLista = Enumerable.Range(1, 20).ToList();
            ParitonLista.RemoveAll(n => n % 2 == 0 );
            Console.WriteLine("lista (1-20) ilman parillisia lukuja: ");
            Console.WriteLine(String.Join(", ", ParitonLista));

            //kolmas tehtävä
            Console.WriteLine("\nkolmas tehtävä");
            Console.WriteLine("syötä listaan ensimmäinen luku: ");
            bool totta = double.TryParse(Console.ReadLine(), out double ekaluku);
            Console.WriteLine("syötä listaan toinen luku: ");
            bool totta1 = double.TryParse(Console.ReadLine(),out double tokaluku);
            Console.WriteLine("syötä listaan kolmas luku: ");
            bool totta2 = double.TryParse(Console.ReadLine(), out double kolmasluku);
            Console.WriteLine("syötä listaan neljäs luku: ");
            bool totta3 = double.TryParse(Console.ReadLine(), out double neljäsluku);
            Console.WriteLine("syötä listaan viides luku: ");
            bool totta4 = double.TryParse(Console.ReadLine(), out double vikaluku);
            List<double> list = new List<double>() { ekaluku, tokaluku, kolmasluku, neljäsluku, vikaluku };
            double maksNumero = list.Max();
            double minNumero = list.Min();
            Console.WriteLine("listan suurin arvo on " + maksNumero);
            Console.WriteLine("listan pienin arvo on " + minNumero);

            //neljäs tehtävä

            Console.WriteLine("\nneljäs tehtävä");
            List<string> lista = new List<string>() { "Anna", "Matti", "Liisa", "Pekka"};
            Console.WriteLine("arvaa nimi listasta: ");
            string totta5 = Console.ReadLine();
            if (lista.Contains(totta5))
            {
                Console.WriteLine($"{totta5} löytyy listasta");
            }
            else
            {
                Console.WriteLine($"{totta5} ei löydy listasta");
            }

            //viides tehtävä

            Console.WriteLine("\nviides tehtävä");
            List<string> nimilista = new List<string>() { "Anna", "Matti", "Liisa", "Pekka", "Marja" };
            nimilista.Sort();
            foreach (string s in nimilista)
            {
                Console.WriteLine(s);
            }
            

            //kuudes tehtävä

            Console.WriteLine("\nkuudes tehtävä");
            List<int>lukulista = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                lukulista.Add(i);
            }
            Console.WriteLine("Lista ennen käännöstä: ");
            foreach (int a  in lukulista)
            {
                Console.Write(a+ " ");
            }
            lukulista.Reverse();
            Console.WriteLine("\nLista käännöksen jälkeen: ");
            foreach (int b in lukulista)
            {
                Console.Write( b + " ");
            }
            
            

            //seitsämäs tehtävä

            Console.WriteLine("\nseitsämäs tehtävä");
            List<int>randomilista = new List<int>();
            Random randomiarvo = new Random();
            for (int g = 0;g < randomiarvo.Next(10, 21); g++)
            {
                randomilista.Add(randomiarvo.Next(1, 6));
            }
            Console.WriteLine("Anna luku (1-5): ");
            if (int.TryParse(Console.ReadLine(), out int randsyöte) && randsyöte >= 1 && randsyöte <= 5)
            {
                int laskenta = randomilista.Count(n  => n == randsyöte);
                Console.WriteLine($"syötteesi esiintyy satunnaisesti luodussa listassa {laskenta} kertaa.");
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }
            
            
            //kahdeksas tehtävä
            Console.WriteLine("\nkahdeksas tehtävä");
            List<String>nimiList = new List<String>() { "Jukka" , "Jarmo" , "Matias" , "Juhani"};
            Console.WriteLine("Vanha nimilista: ");
            nimiList.ForEach(Console.WriteLine);
            Console.WriteLine("\nsyötä uusi nimi listaan: ");
            string nimisyöte = Console.ReadLine();
            nimiList.Add(nimisyöte);
            Console.WriteLine("\nsyötä toinen uusi nimi listaan");
            string nimisyöte1 = Console.ReadLine();
            nimiList.Add(nimisyöte1);
            string EkaNimi = nimisyöte;
            string TokaNimi = nimisyöte1;
            if (TokaNimi == EkaNimi)
            {
                nimiList.Remove(EkaNimi);
            }
            Console.WriteLine("\nPäivitetty lista: ");
            nimiList.ForEach(Console.WriteLine);

            
            //yhdeksäs tehtävä
            Console.WriteLine("\nyhdeksäs tehtävä");
            List<int> yhdLista = new List<int>() { 1, 2, 3, };
            List <int> yhdLista1 = new List<int>() { 4, 5, 6, };
            Console.WriteLine("ensimmäinen lista: " + string.Join(", ", yhdLista));
            Console.WriteLine("toinen lista: " + string.Join (", ", yhdLista1));
            yhdLista.AddRange(yhdLista1);
            Console.WriteLine("yhdistetty lista: " + string.Join(", ", yhdLista));

            //kymmenes tehtävä
            Console.WriteLine("\nkymmenes tehtävä");
            List<int> kymmpilista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> kopioitulista = new List<int>(kymmpilista);
            kymmpilista.Add(11);
            kymmpilista.Add(12);
            Console.WriteLine("alkuperäinen lista: " + string.Join(",", kymmpilista));
            Console.WriteLine("kopioitu lista: " + string.Join(",", kopioitulista));

            


            //yhdestoista tehtävä
            Console.WriteLine("\nyhdestoista tehtävä");
            List<string> Kauppalista = new List<string>();
            string käyttäjänsyöte;
            do
            {
                Console.WriteLine("\nvalitse toiminto");
                Console.WriteLine("1 - lisää tuote");
                Console.WriteLine("2 - poista tuote");
                Console.WriteLine("3 - tulosta kauppalista");
                Console.WriteLine("4 - poistu ohjelmasta");

                Console.WriteLine("valintasi: ");
                käyttäjänsyöte = Console.ReadLine();

                switch (käyttäjänsyöte)
                {
                    case "1":
                        Console.WriteLine("syötä lisättävä tuote: ");
                        string lisättävä = Console.ReadLine();
                        Kauppalista.Add(lisättävä);
                        Console.WriteLine($"tuote {lisättävä} lisätty kauppalistaan");
                        break;
                    case "2":
                        Console.WriteLine("minkä tuotteen haluat poistaa? ");
                        string poistettava = Console.ReadLine();
                        if (Kauppalista.Remove(poistettava))
                        {
                            Console.WriteLine($"tuote {poistettava} poistetty kauppalistasta");
                        }
                        else
                        {
                            Console.WriteLine("tuotetta ei löytynyt listasta ");
                        }
                        break;
                    case "3":
                        if (Kauppalista.Count > 0)
                        {
                            for (int r = 0; r < Kauppalista.Count; r++)
                            {
                                Console.WriteLine($"{1 + r}. {Kauppalista[r]}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("lista on tyhjä");
                        }
                        break;
                    case "4":
                        Console.WriteLine("poistutaan ohjelmasta...");
                        break;
                    default:
                        Console.WriteLine("virheellinen valinta");
                        break;
                }
            } while (käyttäjänsyöte != "4");

        }
    }
}
