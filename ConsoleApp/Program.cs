using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"https://www.cbr-xml-daily.ru/daily_json.js";
            List<Valute> valutes = ParserJSON.GetValutes(path);

            Console.WriteLine($"USD = {valutes.FirstOrDefault(x => x.CharCode == "USD").Value}");
            Console.ReadKey();
        }
    }
}
