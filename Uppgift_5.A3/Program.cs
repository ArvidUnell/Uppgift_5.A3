using System;
namespace Uppgift_5_A3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frågor = 
            { 
                "Hur många vann Eurovision 1969?",
                "Vad heter världens högsta berg?",
                "Vad heter den sydligaste kontinenten?",
                "Vem är Sveriges statsminister?"
            };

            string[] svar =
            {
                "4",
                "mount everest",
                "antarktis",
                "ulf kristersson"
            };

            byte fråga;

            Console.WriteLine("Vilken fråga vill du ha? Skriv ett tal mellan 1 och 4 för att välja");
            while (true)
            {
                try
                {
                    fråga = byte.Parse(Console.ReadLine());
                }
                catch
                {
                    fråga = 0;
                }

                if (fråga >= 1 && fråga <= 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Det är inte ett giltigt alternativ. Försök igen.");
                }
            }

            Console.WriteLine(frågor[fråga-1]);
            if (Console.ReadLine().ToLower() == svar[fråga-1])
            {
                Console.WriteLine("Rätt!");
            }
            else
            {
                Console.WriteLine($"Fel, rätt svar var {svar[fråga-1]}.");
            }

            Console.WriteLine("\nTryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}