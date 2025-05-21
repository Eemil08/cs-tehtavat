using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3teht1_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ensimmäinen tehtävä

            Console.WriteLine("ensimmäinen tehtävä");
            Console.WriteLine("anna luku: ");
            bool totta = double.TryParse(Console.ReadLine(), out double l);
            Console.WriteLine("anna toinen luku: ");
            bool totta1 = double.TryParse(Console.ReadLine(), out double l1);
            if (totta && totta1)
            {
                string parillinen = (l % 2 == 0) ? "parillinen" : "pariton";
                string parillinen1 = (l1 % 2 == 0) ? "parillinen" : "pariton";
                Console.WriteLine("ensimmäinen luku oli " + parillinen);
                Console.WriteLine("toinen luku oli " + parillinen1);
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

            //toinen tehtävä

            Console.WriteLine("\ntoinen tehtävä");
            Console.WriteLine("anna luku: ");
            bool totta2 = double.TryParse(Console.ReadLine(), out double l2);
            if (totta)
            {
                string arvo = (l2 == 0) ? "nolla" : (l2 > 0) ? "positiivinen" : "negatiivinen";
                Console.WriteLine("luku on " + arvo);
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

            //kolmas tehtävä

            Console.WriteLine("\nkolmas tehtävä");
            Console.WriteLine("anna luku: ");
            bool totta3 = double.TryParse(Console.ReadLine(), out double l3);
            Console.WriteLine("anna toinen luku: ");
            bool totta4 = double.TryParse(Console.ReadLine(), out double l4);
            Console.WriteLine("anna kolmas luku: ");
            bool totta5 = double.TryParse(Console.ReadLine(), out double l5);
            if (totta3  && totta4 && totta5)
            {
                if ((l5 > l4) && (l5 > l3))
                {
                    Console.WriteLine($"viimeinen syöttö: {l5}, oli suurin");
                }
                else if ((l4 > l5) && (l4 > l3))
                {
                    Console.WriteLine($"toinen syöttö: {l4}, oli suurin");
                }
                else
                {
                    Console.WriteLine($"ensimmäinen syöttö; {l3}, oli suurin");
                }
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

            //neljäs tehtävä

            Console.WriteLine("\nneljäs tehtävä");
            Console.WriteLine("syötä ikäsi (kokonaisluku): ");
            bool totta6 = int.TryParse(Console.ReadLine(), out int l6);
            if (totta6)
            {
                switch (l6)
                {
                    case int n when (n < 0):
                        Console.WriteLine("virheellinen syöte");
                        break;
                    case int n when (n <= 12):
                        Console.WriteLine("olet lapsi");
                        break;
                    case int n when (n <= 17):
                        Console.WriteLine("olet nuori");
                        break;
                    case int n when (n <= 64):
                        Console.WriteLine("olet aikuinen");
                        break;
                    default:
                        Console.WriteLine("olet seniori");
                        break;
                }
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

            //viides tehtävä

            Console.WriteLine("\nviides tehtävä");
            Console.WriteLine("syötä pisteesi (0-100): ");
            bool totta7 = double.TryParse(Console.ReadLine(),out double l7);
            if (totta7)
            {
                switch (l7)
                {
                    case double a when (a < 0):
                        Console.WriteLine("virheellinen pistemäärä");
                        break;
                    case double a when (a < 50):
                        Console.WriteLine("arvosanasi on 1");
                        break;
                    case double a when (a >= 50 && a < 60):
                        Console.WriteLine("arvosanasi on 2");
                        break;
                    case double a when (a >= 60 && a < 70):
                        Console.WriteLine("arvosanasi on 3");
                        break;
                    case double a when (a >= 70 && a < 80):
                        Console.WriteLine("arvosanasi on 4");
                        break;
                    case double a when (a >= 80 && a <= 100):
                        Console.WriteLine("arvosanasi on 5");
                        break;
                    default:
                        Console.WriteLine("virheellinen pistemäärä");
                        break;
                }
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

            //kuudes tehtävä

            Console.WriteLine("\nkuudes tehtävä");
            Console.WriteLine("anna kolmion sivun pituus: ");
            bool totta8 = double.TryParse(Console.ReadLine(), out double l8);
            Console.WriteLine("anna kolmion toisen sivun pituus: ");
            bool totta9 = double.TryParse(Console.ReadLine(), out double l9);
            Console.WriteLine("anna kolmion kolmas sivu: ");
            bool totta10 = double.TryParse(Console.ReadLine(), out double l10);
            double sivut = l8 + l9;
            if (totta8 && totta9 && totta10)
            {
                switch (sivut)
                {
                    case double b when (b < l10 || b == l10):
                        Console.WriteLine("epäkelvollinen kolmio");
                        break;
                    default:
                        Console.WriteLine("kelvollinen kolmio");
                        break;
                }
            }
            else
            {
                Console.WriteLine("virheellinen syöte: ");
            }

            //seitsämäs tehtävä

            Console.WriteLine("\nseitsämäs tehtävä");
            Console.WriteLine("kirjoita merkkijono: ");
            string jono = Console.ReadLine();
            Console.WriteLine("kirjoita toinen merkkijono");
            string jono1 = Console.ReadLine();
            if (jono1 == jono)
            {
                Console.WriteLine($"merkkijonot ovat samat. ensimmäinen syöte: {jono}, toinen syöte: {jono1}");
            }
            else
            {
                Console.WriteLine($"merkkijonot eivät ole samat. ensimmäinen syöte: {jono}, toinen syöte: {jono1}");
            }

            //kahdeksas tehtävä

            Console.WriteLine("\nkahdeksas tehtävä");
            Console.WriteLine("valitse toiminto: ");
            Console.WriteLine("1. ruokalista");
            Console.WriteLine("2. viikonpäivät");
            Console.WriteLine("3. sulje");
            Console.WriteLine("syötä valinta: ");
            int valinta = int.Parse(Console.ReadLine());
            switch (valinta)
            {
                case 1:
                    Console.WriteLine("maanantai: kasviskastike \ntiistai: jauhelihakiusaus \nkeskiviikko: kanakastike \ntorstai: lindstöminpihvit \nperjantai: makkarakeitto");
                    break;
                case 2:
                    Console.WriteLine("maanantai \ntiistai \nkeskiviikko \ntorstai \nperjantai \nlauantai \nsunnuntai");
                    break;
                case 3:
                    Console.WriteLine("ohjelma suljetaan");
                    break;
                default:
                    Console.WriteLine("virheellinen valinta");
                    break;
            }

            //yhdeksäs tehtävä

            Console.WriteLine("\nyhdeksäs tehtävä");
            Console.WriteLine("syötä kokonaisluku (1-7): ");
            bool vkpv = int.TryParse(Console.ReadLine(), out int vkpv1);
            switch (vkpv1)
            {
                case 1:
                    Console.WriteLine("maanantai");
                    break;
                case 2:
                    Console.WriteLine("tiistai");
                    break;
                case 3:
                    Console.WriteLine("keskiviikko");
                    break;
                case 4:
                    Console.WriteLine("torstai");
                    break;
                case 5:
                    Console.WriteLine("perjantai");
                    break;
                case 6:
                    Console.WriteLine("lauantai");
                    break;
                case 7:
                    Console.WriteLine("sunnuntai");
                    break;
                default:
                    Console.WriteLine("virheellinen syöte");
                    break;
            }

            //kymmenes tehtävä

            Console.WriteLine("\nkymmenes tehtävä");
            Console.WriteLine("anna luku: ");
            bool totta11 = double.TryParse(Console.ReadLine(), out double l11);
            Console.WriteLine("anna toinen luku: ");
            bool totta12 = double.TryParse(Console.ReadLine(),out double l12);
            if (totta11 && totta12)
            {
                Console.WriteLine("syötä laskutoimitus (+, -, * tai /): ");
                string lasku = Console.ReadLine();
                switch (lasku)
                {
                    case "+":
                        Console.WriteLine($"{l11 + l12}");
                        break;
                    case "-":
                        Console.WriteLine($"{l11 - l12}");
                        break;
                    case "*":
                        Console.WriteLine($"{l11 * l12}");
                        break;
                    case "/":
                        Console.WriteLine($"{l11 / l12}");
                        break;
                    default:
                        Console.WriteLine("virheellinen laskutoimitus");
                        break;
                }
            }
            else
            {
                Console.WriteLine("virheellinen syöttö");
            }

            //yhdestoista tehtävä

            Console.WriteLine("\nyhdestoista tehtävä");
            Console.WriteLine("syötä kuukautta vastaava numero (1-12): ");
            bool totta13 = int.TryParse(Console.ReadLine(), out int l13);
            switch (l13)
            {
                case int c when (l13 <= 2):
                    Console.WriteLine("talvi");
                    break;
                case int c when (l13 <= 5):
                    Console.WriteLine("kevät");
                    break;
                case int c when (l13 <= 8):
                    Console.WriteLine("kesä");
                    break;
                case int c when (l13 <= 10):
                    Console.WriteLine("syksy");
                    break;
                case int c when (l13 <= 12):
                    Console.WriteLine("talvi");
                    break;
                default:
                    Console.WriteLine("virheellinen syöttö");
                    break;
            }

            //kahdestoista tehtävä

            Console.WriteLine("\nkahdestoista tehtävä");
            Console.WriteLine("aseta käyttäjätunnus: ");
            string käyttäjätunnus = Console.ReadLine();
            Console.WriteLine("aseta salasana: ");
            string salasana = Console.ReadLine();
            Console.WriteLine("kirjaudu käyttäjätietoihin: ");
            Console.WriteLine("käyttäjätunnus ");
            string käyttäjätunnus1 = Console.ReadLine();
            Console.WriteLine("salasana: ");
            string salasana1 = Console.ReadLine();
            if (salasana == salasana1 && käyttäjätunnus == käyttäjätunnus1)
            {
                Console.WriteLine("pääsy käyttäjätietoihin");
            }
            else
            {
                Console.WriteLine("käyttäjätunnus tai salasana virheellinen");
            }

            //kolmastoista tehtävä

            Console.WriteLine("\nkolmastoista tehtävä");
            Console.WriteLine("syötä kolmion ensimmäisen sivun a pituus: ");
            bool totta14 = double.TryParse(Console.ReadLine(), out double l14);
            Console.WriteLine("syötä kolmion toisen sivun b pituus: ");
            bool totta15 = double.TryParse(Console.ReadLine(),out double l15);
            Console.WriteLine("syötä kolmion viimeisen c sivun pituus: ");
            bool totta16 = double.TryParse(Console.ReadLine(), out double l16);
            if (totta14 && totta15 && totta16)
            {
                if ((l16 == l15) && (l16 == l14) && l14 == l15)
                {
                    Console.WriteLine("tasasivuinen kolmio");
                }
                else if (l16 == l15 && l16 == l14 || ((l14 == l15) || (l16 == l15 && l16==l14)))
                {
                    Console.WriteLine("tasakylkinen kolmio");
                }
                else if (Math.Acos((l14 * l14 + l15 * l15 - l16 * l16) / (2 * l14 * l15)) == 90)
                {
                    Console.WriteLine("suorakulmainen kolmio");
                }
                else
                {
                    Console.WriteLine("epäsäännöllinen kolmio");
                }
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }


            //neljästoista tehtävä

            Console.WriteLine("\nneljästoista tehtävä");
            Console.WriteLine("syötä x kordinaatti: ");
            bool totta17 = double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine("syötä y kordinaatti");
            bool totta18 = double.TryParse(Console.ReadLine(), out double y);
            if (totta17 && totta18)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("pisteet sijaitsevat I neljänneksessä");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("pisteet sijaitsevat II neljänneksessä");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("pisteet sijaitsevat III neljänneksessä");
                }
                else if (x  > 0 && y < 0)
                {
                    Console.WriteLine("pisteet sijaitsevat IV neljänneksessä");
                }
                else if (x == 0 && y == 0)
                {
                    Console.WriteLine("origo");
                }
                else
                {
                    Console.WriteLine("akselilla");
                }
            }
            else
            {
                Console.WriteLine("virheellinen syöte");
            }

        }
    }
}

