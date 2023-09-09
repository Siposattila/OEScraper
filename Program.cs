using System;

namespace OEScraper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? name = "";
            while (name == string.Empty)
            {
                Console.Clear();
                Console.WriteLine("Name to search for in the OE phonebook:");
                name = Console.ReadLine();
            }

            Scraper scraper = new Scraper(name);
            ConsoleIO.Outputs(scraper.Scrape());
        }
    }
}
