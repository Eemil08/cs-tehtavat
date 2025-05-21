using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tulostetaan ohje käyttäjälle
            Console.WriteLine("Syötä nimesi:");
            Console.WriteLine("syötä koulusi nimi:");

            // Luetaan käyttäjän syöte (koko rivi)
            string name = Console.ReadLine();
            string koulu = Console.ReadLine();

            // Tulostetaan käyttäjän syöte
            Console.WriteLine("Hei, " + name + ", kuka opiskelee " + koulu + "ssa");

            /////////////////////////////////

            // Tulostetaan ohje käyttäjälle
            Console.WriteLine("Syötä ikäsi:");
            Console.WriteLine("syötä postinumerosi:");


            // Luetaan käyttäjän syöte merkkijonona ja muunnetaan kokonaisluvuksi
            int age = int.Parse(Console.ReadLine());
            int posti = int.Parse(Console.ReadLine());


            // Tulostetaan syötteen perusteella viesti
            Console.WriteLine("Ikäsi on " + age + " vuotta ja postinumerosi on " + posti);

            //////

            // Tulostetaan ohje käyttäjälle
            Console.WriteLine("Syötä pituutesi (metreinä):");
            Console.WriteLine("Syötä pituutesi vuosi sitten:");

            // Luetaan käyttäjän syöte ja muunnetaan se liukuluvuksi
            double height = double.Parse(Console.ReadLine());
            double pituusviimeV = double.Parse(Console.ReadLine());


            // Tulostetaan syötteen perusteella viesti
            Console.WriteLine("olit viime vuonna " + pituusviimeV + " metriä ja nykyään olet " + height);

            ///////////////////////////////////

            // Syötteen lukeminen
            Console.WriteLine("Syötä nimesi:");
            string nimi = Console.ReadLine();

            Console.WriteLine("syötä kätesi pituus:");
            double kasi = double.Parse(Console.ReadLine()); 


            Console.WriteLine("Syötä ikäsi:");
            int ika = int.Parse(Console.ReadLine());


            Console.WriteLine("Syötä pituutesi:");
            double pituus = double.Parse(Console.ReadLine());


            // Tulostetaan kaikki syötetyt tiedot
            Console.WriteLine("Hei " + nimi + "!");
            Console.WriteLine("Ikäsi on " + ika + " vuotta.");
            Console.WriteLine("Pituutesi on " + pituus + " metriä.");
            Console.WriteLine("kätesi pituus on " + kasi + " metriä");

            //////////////////////////////////

            Console.WriteLine("Syötä ikäsi:");


            // Yritetään lukea ikä ja tarkistetaan, että syöte on kelvollinen
            bool validInput = int.TryParse(Console.ReadLine(), out int ikä);


            if (validInput)
            {
                Console.WriteLine("Ikäsi on " + ikä + " vuotta.");
                Console.WriteLine("kuinka vanha isäsi on: ");
                bool totta = int.TryParse(Console.ReadLine(), out int isä);
                if (totta)
                {
                    Console.WriteLine("isäsi ikä on " + isä);
                }
                else
                {
                    Console.WriteLine("virheellinen syöte");
                }
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen ikä.");
            }

            ////////////////////////////////// 

            string nimi1 = "John";
            int ika1 = 30;
            string asuinkaupunki = "salo";

            // Tulostetaan merkkijonot interpoloinnilla
            Console.WriteLine($"Hei, {nimi1}. Ikäsi on {ika1} vuotta. Asuinkaupunkisi on {asuinkaupunki}");

            ///////

            string nimi2 = "John";
            int ika2 = 30;
            string asuinkaupunki1 = "salo";


            // Käytetään string.Format()
            Console.WriteLine(string.Format("Hei, {0}. Ikäsi on {1} vuotta. Asuinkaupunkisi on {3}.", nimi2, ika2, asuinkaupunki1));

        }
    }
}
