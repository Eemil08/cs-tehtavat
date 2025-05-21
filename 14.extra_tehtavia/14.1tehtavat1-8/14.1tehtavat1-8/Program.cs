using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace _14._1tehtavat1_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //ensimmäinen tehtävä

            Random ekanoppa = new Random();
            int heitto1 = ekanoppa.Next(1, 7);
            int heitto2 = ekanoppa.Next(1, 7);

            if (heitto1 == heitto2)
            {
                Console.WriteLine("nopan silmäluvut ovat samat");
                if (heitto1 == 1 && heitto2 == 1)
                {
                    Console.WriteLine("snake eyes");
                }
            }
            else
            {
                Console.WriteLine("nopan silmäluvut ovat erit");
            }

            //toinen tehtävä
            Console.WriteLine("\ntoinen tehtävä");
            Random rand = new Random();
            Console.WriteLine("Kerro nimesi: ");
            int kierros = 0;
            string nimi = Console.ReadLine();
            string tiedostopolku = @"kertotaulutesti.txt";
            do
            {
                int ekaluku = rand.Next(1, 16);
                int tokaluku = rand.Next(1, 16);
                int kertolasku = ekaluku * tokaluku;
                kierros++;
                Console.WriteLine($"laske kertolasku {ekaluku} * {tokaluku}");
                int vastaus = int.Parse(Console.ReadLine());
                if (vastaus == kertolasku)
                {
                    Console.WriteLine("oikein meni");
                }
                else
                {
                    Console.WriteLine("väärin meni");
                    break;
                }
            } while (kierros < 10);
            string tulos = $"{DateTime.Now}: {nimi} - Pisteet: {kierros} / 10";
            File.AppendAllText(tiedostopolku, tulos + Environment.NewLine);

            //kolmas tehtävä
            Console.WriteLine("\nkolmas tehtävä");
            Console.WriteLine("tämä on kivi sakset paperi peli");
            string[] vaihtoehdot = { "kivi", "sakset", "paperi" };
            Random rand1 = new Random();
            Console.WriteLine("valitse kivi, paperi tai sakset");
            string pelaajanvalinta = Console.ReadLine();
            if (Array.IndexOf(vaihtoehdot, pelaajanvalinta) == -1)
            {
                Console.WriteLine("virheellinen valinta, yritä uudelleen");
                return;
            }
            string tietokonevalinta = vaihtoehdot[rand1.Next(vaihtoehdot.Length)];
            Console.WriteLine($"tietokone valitsi: {tietokonevalinta}");
            if (pelaajanvalinta == tietokonevalinta)
            {
                Console.WriteLine("tasapeli");
            }
            else if ((pelaajanvalinta == "kivi" && tietokonevalinta == "sakset") ||
                     (pelaajanvalinta == "paperi" && tietokonevalinta == "kivi") ||
                     (pelaajanvalinta == "sakset" && tietokonevalinta == "paperi"))
            {
                Console.WriteLine("voitit!");
            }
            else
            {
                Console.WriteLine("hävisit");
            }
            

            //neljäs tehtävä
            Console.WriteLine("\nneljäs tehtävä");
            Random rand2 = new Random();
            int randomiluku = rand2.Next(1, 10001);
            bool totta = true;
            int syöte = 0;
            int kierros1 = 0;
            while (syöte != randomiluku && totta)
            {
                Console.WriteLine("arvaa luku väliltä 1 - 10000");
                totta = int.TryParse(Console.ReadLine(), out syöte);
                kierros1++;
                if (syöte > randomiluku)
                {
                    Console.WriteLine("pienempi");
                }
                else if (syöte < randomiluku)
                {
                    Console.WriteLine("suurempi");
                }
                else
                {
                    Console.WriteLine($"sait luvun oikein {kierros1} yrityksellä");
                }
            }

            //viides tehtävä
            Console.WriteLine("\nviides tehtävä");
            Random random = new Random();
            int[] lottonumerot = new int[7];
            for (int i = 0; i < 7; i++)
            {
                int uusinumero;
                do
                {
                    uusinumero = random.Next(1, 40);
                }while (lottonumerot.Contains(uusinumero));
                lottonumerot[i] = uusinumero;
            }
            Console.WriteLine("Syötä oma lottorivisi (7 numeroa väliltä 1-39, eroteltuna välilyönneillä):");
            int[]käyttäjännumerot = new int[7];
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (input.Length == 7 && input.All(n => int.TryParse(n, out int num) && num >= 1 && num <= 39))
                {
                    käyttäjännumerot = input.Select(int.Parse).ToArray();
                    break;
                }
                else
                { 
                    Console.WriteLine("virheellinen syöte");
                }
            }
            int oikeat = käyttäjännumerot.Count(n => lottonumerot.Contains(n));
            Console.WriteLine("Arvotut numerot: " + string.Join(", ", lottonumerot));
            Console.WriteLine("Omat numerot: " + string.Join(", ", käyttäjännumerot));
            Console.WriteLine($"Oikein: {oikeat}");

            //kuudes tehtävä
            Console.WriteLine("\nkuudes tehtävä");
        }
    }
}
