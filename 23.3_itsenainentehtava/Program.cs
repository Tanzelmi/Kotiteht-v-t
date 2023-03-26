using System;

namespace _23._3_itsenainentehtava
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pyydä käyttäjältä leveys ja korkeus (metreinä).

            // Ilmoita käyttäjälle hänen syöttämien tietojen perusteella pinta - ala(neliöinä).

            // Laskukaava: leveys* korkeus 

            Console.WriteLine("Anna leveys metreinä. ");
            string userWidth = Console.ReadLine();
            
            int width = int.Parse(userWidth);

            Console.WriteLine("Anna pituus metreinä. ");
            string userLength = Console.ReadLine();

            int lenght = int.Parse(userLength);

            int acreage = width * lenght;

            Console.WriteLine($"Annettujen mittojen pinta-ala on {acreage} neliötä. ");


        }
    }
}
