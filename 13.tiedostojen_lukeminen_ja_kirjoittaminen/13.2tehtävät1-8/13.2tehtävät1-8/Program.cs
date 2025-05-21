using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;

namespace _13._2tehtävät1_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //esimerkki koodit:
            string filePath = "example.txt";
            string content = "Tämä on esimerkki tiedoston kirjoittamisesta.";

            File.WriteAllText(filePath, content);

            Console.WriteLine($"Teksti on kirjoitettu tiedostoon {filePath}");

            ///

            string filePath1 = "example.txt";

            if (File.Exists(filePath))
            {
                string content1 = File.ReadAllText(filePath1);
                Console.WriteLine("Tiedoston sisältö:");
                Console.WriteLine(content1);
            }
            else
            {
                Console.WriteLine($"Tiedostoa {filePath1} ei löytynyt.");
            }

            ///

            string filePath2 = "example.txt";
            string additionalContent = "\nTämä teksti lisättiin tiedostoon.";

            File.AppendAllText(filePath2, additionalContent);

            Console.WriteLine($"Teksti on lisätty tiedostoon {filePath2}");

            ///

            string filePath3 = "example.txt";

            if (File.Exists(filePath3))
            {
                string[] lines = File.ReadAllLines(filePath3);
                Console.WriteLine("Tiedoston rivit:");

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine($"Tiedostoa {filePath3} ei löytynyt.");
            }

            ///

            string filePath4 = "example_stream.txt";

            using (StreamWriter writer = new StreamWriter(filePath4))
            {
                writer.WriteLine("Ensimmäinen rivi.");
                writer.WriteLine("Toinen rivi.");
                writer.WriteLine("Kolmas rivi.");
            }

            Console.WriteLine($"Tiedosto {filePath4} on kirjoitettu.");

            ///

            string filePath5 = "example_stream.txt";


            if (File.Exists(filePath5))
            {
                using (StreamReader reader = new StreamReader(filePath5))
                {
                    string line;
                    Console.WriteLine("Tiedoston sisältö rivit kerrallaan:");


                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine($"Tiedostoa {filePath5} ei löytynyt.");
            }

            ///

            string sourcePath = "example.txt";
            string destinationPath = "example_copy.txt";

            // Kopioi tiedosto
            if (File.Exists(sourcePath))
            {
                File.Copy(sourcePath, destinationPath, true);
                Console.WriteLine($"Tiedosto kopioitu: {destinationPath}");
            }
            else
            {
                Console.WriteLine($"Lähdetiedostoa {sourcePath} ei löytynyt.");
            }

            // Poista kopioitu tiedosto
            if (File.Exists(destinationPath))
            {
                File.Delete(destinationPath);
                Console.WriteLine($"Tiedosto {destinationPath} poistettu.");
            }

            //toinen tehtävä
            Console.WriteLine("\ntoinen tehtävä");
            string TiedostoPolku = @"tokatehtava.txt";
            if (!File.Exists(TiedostoPolku))
            {
                Console.WriteLine("tiedostoa ei löytynyt");
                return;
            }
            string sisältö = File.ReadAllText(TiedostoPolku);
            string Tiedostopolku1 = @"kopio.txt";
            File.WriteAllText(Tiedostopolku1, sisältö);
            Console.WriteLine("tiedoston sisältö kopioitiin tiedostoon kopio.txt onnistuneesti");

            //kolmas tehtävä
            Console.WriteLine("\nkolmas tehtävä");
            string TiedostoPolku1 = @"esimerkki.txt";
            if (!File.Exists (TiedostoPolku1))
            {
                Console.WriteLine("tiedostoa ei löytynyt");
                return;
            }
            string[]rivit = File.ReadAllLines(TiedostoPolku1);
            Console.WriteLine("Tiedoston rivit: ");
            for (int i = 0; i < rivit.Length; i++)
            {
                rivit[i] = $"{i + 1}: {rivit[i]}";
            }
            string UusiPolku = @"numeroitu_esimerkki.txt";
            File.WriteAllLines(UusiPolku, rivit);
            Console.WriteLine("tiedosto käsitelty ja tallennettu nimellä numeroitu_esimerkki");

            //neljäs tehtävä
            Console.WriteLine("\nneljäs tehtävä");
            string TiedostoPolku2 = @"korvaa_sana.txt";
            string sisältö1 = File.ReadAllText(TiedostoPolku2);
            string vanhasisältö = "vanha";
            string uusisisältö = "uusi";
            string muokattusisältö = sisältö1.Replace(vanhasisältö, uusisisältö);
            File.WriteAllText(TiedostoPolku2, muokattusisältö);
            if (!File.Exists(TiedostoPolku2))
            {
                Console.WriteLine("tiedostoa ei löytynyt");
                return;
            }
            Console.WriteLine("tiedostosta korvaa_sana.txt korvattu sanat: vanha, sanalla: uusi");

            //viides tehtävä
            Console.WriteLine("\nviides tehtävä");
            string tiedostopolku1 = @"rivi_maara.txt";
            if (!File.Exists(tiedostopolku1))
            {
                Console.WriteLine("\ntiedostoa ei löytynyt");
                return;
            }
            int RiviLaskija = 0;
            using (StreamReader lukija = new StreamReader(tiedostopolku1))
            {
                while (lukija.ReadLine() != null)
                {
                    RiviLaskija++;
                }
            }
            Console.WriteLine($"tiedostossa rivi_maara.txt on {RiviLaskija} riviä");

            //kuudes tehtävä
            Console.WriteLine("\nkuudes tehtävä");
            string tiedostopolku = @"sana_maara.txt";
            string sisältö2 = File.ReadAllText (tiedostopolku);
            int wordCount = content.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine($"tiedostossa sana_maara.txt on {wordCount} sanaa");
            if (!File.Exists(tiedostopolku))
            {
                Console.WriteLine("tiedostoa ei löytynyt");
                return;
            }

            //seitsämäs tehtävä
            Console.WriteLine("\nseitsämäs tehtävä");
            string tiedostopolku2 = @"paivakirja.txt";
            Console.Write("syötä lisättävä teksti: ");
            string käyttäjäsyöte = Console.ReadLine();
            string lisäys = $"{DateTime.Now:yyyy-MM-dd HH:mm}: {käyttäjäsyöte}";
            using (StreamWriter kirjoittaja = new StreamWriter(tiedostopolku2, true))
            {
                kirjoittaja.WriteLine(lisäys);
            }
            if (!File.Exists (tiedostopolku2))
            {
                Console.WriteLine("tiedostoa ei löytynyt");
                return;
            }
            Console.WriteLine("teksti lisätty tiedoston paivakirja.txt loppuun");

            //kahdeksas tehtävä
            Console.WriteLine("\nkahdeksas tehtävä");
            string tiedostopolku3 = @"sanakerta.txt";
            if (!File.Exists (tiedostopolku3))
            {
                Console.WriteLine("tiedostoa ei löytynyt");
                return;
            }
            Console.Write("anna etsittävä sana: ");
            string etsisana = Console.ReadLine();
            string sisäl = File.ReadAllText(tiedostopolku3);
            int laskenta = 0;
            int index = tiedostopolku3.IndexOf(etsisana, StringComparison.OrdinalIgnoreCase);
            while (index != -1)
            {
                laskenta++;     
                index = tiedostopolku3.IndexOf(etsisana, index + etsisana.Length, StringComparison.OrdinalIgnoreCase);
            }
            Console.WriteLine($"sana {etsisana} esiintyy tiedostossa sanakerta.txt {laskenta} kertaa");
        }
    }
}
