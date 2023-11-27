using System;

namespace Uppgift_5._1_C_A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meningar = new string[]
            {
                "Skapa ett program som innehåller en array med strängar där varje sträng är en mening.",
                "Skriv ut varje mening med hjälp av en loop, gör så att varje mening hamnar i ett eget stycke.",
                "Det ska alltså vara en tom rad mellan varje mening."
            };
            for (int i = 0; i < meningar.Length; i++)
            {
                Console.WriteLine(meningar[i]);
                Console.WriteLine();
            }
        }
    }
}