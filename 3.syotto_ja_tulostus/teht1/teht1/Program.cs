using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("syötä luku: ");
            bool validInput = int.TryParse(Console.ReadLine(), out int luku);
            Console.WriteLine("syötä toinen luku: ");
            bool validInput2 = int.TryParse(Console.ReadLine(), out int luku2);

            if (validInput && validInput2)
            {
                Console.WriteLine("summa on" + luku + luku2);
                Console.WriteLine("tulo on" + luku * luku2);
                Console.WriteLine("jako on" + luku / luku2);
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }
        }
    }
}
