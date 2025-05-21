using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2_tehtavat_1_8
{
    internal class Program
    {
        const double Pi = 3.14159;
        const double g = 9.81;
        const double alv = 0.255;
        const double c = 299792458;
        const double p = 1.225;

        static void Main(string[] args)
        {
            //eka teht

            Console.WriteLine("anna halkaisijan pituus: ");
            string input = Console.ReadLine();

            bool validInput = double.TryParse(input, out double halkaisija);
            if (validInput)
            {
                Console.WriteLine("ympyrän ympärysmitta on: " + halkaisija * Pi);
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

            //toinen teht
            Console.WriteLine("syötä putoamisaika sekunteina: ");
            bool input1 = double.TryParse(Console.ReadLine(), out double aika);
            double s = 0.50 * g * aika * aika;
            if (input1)
            {
                Console.WriteLine("putoamismatka metreinä on " + Math.Sqrt(2 * s * g));
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

            //kolmas teht

            Console.WriteLine("anna leveys metreinä");
            bool input2 = double.TryParse(Console.ReadLine(), out double leveys);
            Console.WriteLine("anna korkeus metreinä");
            bool input3 = double.TryParse(Console.ReadLine(), out double korkeus);
            if (input2 && input3)
            {
                Console.WriteLine("pinta-ala on " + leveys * korkeus); 
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

            //neljäs teht

            Console.WriteLine("anna tuotteen veroton hinta");
            bool input4 = double.TryParse(Console.ReadLine(), out double veroton);
            if (input4)
            {
                Console.WriteLine("verollinen hinta on " + veroton * (1 + alv));
            }
            else
            {
                Console.WriteLine("virheellinen syöttö");
            }

            //viides teht

            Console.WriteLine("anna aika sekunteina: ");
            bool input5 = double.TryParse(Console.ReadLine(), out double aika1);
            double matka = c * aika1 / 100;
            if (input5)
            {
                Console.WriteLine($"valo kulkee {matka} kilometriä {aika1} sekunnissa");
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

            //kuudes teht

            Console.WriteLine("anna lämpötila celsius asteina: ");
            bool input6 = double.TryParse(Console.ReadLine(), out double celsius);
            if (input6)
            {
                Console.WriteLine("se on farenheit asteikoilla " + (celsius * 1.8 + 32) + " astetta"); 
            }


            //seitsämäs

            Console.WriteLine("anna sekuntien määrä");
            bool input7 = double.TryParse(Console.ReadLine(), out double sek);
            double sekj = sek % 3600;
            double tunnit = sek / 3600;
            double sekunnit = sekj % 60;
            double minuutit = sekj / 60;
            

            if (input7)
            {
                Console.WriteLine($"aika tunteina on {tunnit} ja minuutteina {minuutit} ja sekunteina {sekunnit}");
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }


            //kahdeksas

            Console.WriteLine("anna korkeuden muutos metreinä ");
            bool input8 = double.TryParse(Console.ReadLine(), out double muutos);
            if (input8)
            {
                Console.WriteLine("paineen muutos on " + p * g * muutos);
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

        }
    }
}
