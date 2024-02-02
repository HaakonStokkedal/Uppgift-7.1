using System.Collections.Generic;
namespace Uppgift_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> namn = new List<string>();

            Console.WriteLine("Skriv in hur många namn du vill men avsluta med en tom rad när du är klar.");
            string nyttNamn = " ";

            while (nyttNamn != "")
            {
                Console.WriteLine("Skriv in ett nytt namn:");
                nyttNamn = Console.ReadLine();
                if (nyttNamn != "")
                {
                    namn.Add(nyttNamn);
                }
            }

            namn.Sort();
            Console.WriteLine("Här kommer namnen i bakvänd bokstavordning:");

            for (int i = namn.Count - 1; i > 0; i--)
            {
                Console.WriteLine(namn[i]);
            }

            Console.ReadKey();
        }
    }
}