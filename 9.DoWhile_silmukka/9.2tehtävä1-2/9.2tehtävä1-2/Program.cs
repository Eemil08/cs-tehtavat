using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2tehtävä1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ensimmäinen tehtävä
            Console.WriteLine("\nensimmäinen tehtävä");

            string salasana = "salasana";
            string salasana1;
            do
            {
                Console.WriteLine("arvaa salasana (salasana on: salasana) ");
                salasana1 = Console.ReadLine();
                if (!(salasana1 == salasana))
                {
                    Console.WriteLine("salasana väärin");
                }
            }
            while (!(salasana == salasana1));
            {
                Console.WriteLine("sait salasanan oikein");
            }

            //toinen tehtävä

            Console.WriteLine("\ntoinen tehtävä");
            int syötemäärä = 0;
            double lukujensumma = 0;
            double numero;

            do
            {
                Console.WriteLine("syötä luku (poistu silmukasta asettamalla negatiivinen luku): ");
                numero = Convert.ToDouble(Console.ReadLine());
                if (numero > 0)
                {                    
                    syötemäärä++;
                    lukujensumma += numero;
                }
            }
            while (numero > 0); 
            {
                double keskiarvo = lukujensumma / syötemäärä;
                Console.WriteLine(keskiarvo);
            }
        }
    }
}
