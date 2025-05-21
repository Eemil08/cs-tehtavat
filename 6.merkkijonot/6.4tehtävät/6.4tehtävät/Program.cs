using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4tehtävät
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello, World";
            Console.WriteLine(greeting + "!");

            ////

            string firstName = "Juha";
            string lastName = "Possu";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            ////

            string text = "Hello, World!";

            Console.WriteLine(text.Length);
            string part = text.Substring(0, 5);  // "Hello"
            Console.WriteLine(part);

            ////

            string text2 = "MoI";
            Console.WriteLine(text2.ToUpper());  // "HELLO"
            Console.WriteLine(text2.ToLower());  // "hello"

            ////
            
            string text1 = " ,  Hello, World!  , ";
            Console.WriteLine(text1.Trim());  // ",  Hello, World!,  "

            ////
            
            string text3 = "Moi, Maailma!";
            int index = text3.IndexOf("Moi");  // 7
            Console.WriteLine(index);

            ////
            
            string text4 = "tykkään omenoista";
            string newText = text4.Replace("omenoista", "appelsiineista");
            Console.WriteLine(newText);  // "tykkään appelsiineista"

            ////

            Console.Write("Syötä sanat yhdellä rivillä (esim. 'kissa koira hevonen'): ");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');


            string result = string.Join("      ", words); // Yhdistä sanat 
            Console.WriteLine($"Yhdistetty merkkijono: {result}");

            ////

            string name = "Juha";
            int age = 25;
            string FavFruit = "Apple";

            string message = $"My name is {name} and I am {age} years old and my favourite fruit is {FavFruit}.";
            Console.WriteLine(message);

            ////

            string text5 = "\nFirst \nline\nSecond \nline";
            Console.WriteLine(text5);

            ////

            string path = @"C:\Users\Public\Documents";
            Console.WriteLine(path);

            ////

            string path1 = @"C:\Users\Public\Documents";
            Console.WriteLine(path1);

            ////

            StringBuilder sb = new StringBuilder("Hei maailma!");


            // Lisää tekstiä loppuun
            sb.Append(" miten menee?");

            // Lisää tekstiä tiettyyn kohtaan
            sb.Insert(4, "upea");


            // Korvaa tekstiä
            sb.Replace("Hei", "Moi");

            ////

            StringBuilder sb1 = new StringBuilder("Terve maailma!");
            sb.Remove(0, 4); 

            Console.WriteLine(sb.ToString());


            ///////


            double luku6 = 1234.5678;

            Console.WriteLine($"Luku: {luku6:F1}"); // Tulostaa 1234.57

            ////

            double hinta = 100;
            Console.OutputEncoding = Encoding.Default; // jos ongelma €-merkin tulostuksessa

            Console.WriteLine($"Hinta: {hinta:C}"); // Tulostaa esim. €99.99 (kieliasetuksista riippuen)

            ////

            double osuus = 20;

            Console.WriteLine($"Osuus: {osuus:P}"); // Tulostaa 85.00 %

            ////

            DateTime paivamaara = DateTime.Now;

            Console.WriteLine($"Tänään on: {paivamaara:dd.MM.yyyy}"); // Tulostaa esim. 10.01.2025
            Console.WriteLine($"Kellonaika: {paivamaara:HH:mm:ss}");   // Tulostaa esim. 14:30:45


            /////////


            string text7 = "Hei,\"\nTämä on esimerkki \n\"escape-merkeistä\" C#:ssa.\n\t- Tabulaattori\n\t- Rivinvaihto\n";
            Console.WriteLine(text7);

            ////

            string filePath = @"C:\Users\Public\Documents"; //string filePath = "C:\\Users\\Public\\Documents";
            string quote = @"Tämä on ""sanamerkkijono"".";
            Console.WriteLine(filePath);
            Console.WriteLine(quote);


        }
    }
}
