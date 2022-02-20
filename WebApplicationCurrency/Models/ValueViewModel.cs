using ConsoleApp;
using System.Collections.Generic;

namespace WebApplicationCurrency.Models
{
    public class ValueViewModel
    {
        public string ID { get; set; }
        public string NumCode { get; set; }
        public string CharCode { get; set; }
        public int Nominal { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public decimal Previous { get; set; }

        public ValueViewModel(string iD, string numCode, string charCode, int nominal, string name, decimal value, decimal previous)
        {
            ID = iD;
            NumCode = numCode;
            CharCode = charCode;
            Nominal = nominal;
            Name = name;
            Value = value;
            Previous = previous;
        }
        public static List<ValueViewModel> GetAll()
        {
            List<Valute> valutes = ParserJSON.GetValutes(@"https://www.cbr-xml-daily.ru/daily_json.js");

            return DeepClone(valutes);
        }

        public static List<ValueViewModel> DeepClone(List<Valute> valutes)
        {
            List<ValueViewModel> valutesCloned = new List<ValueViewModel>();
            foreach (var valute in valutes)
            {
                valutesCloned.Add(new ValueViewModel(valute.ID,valute.NumCode, valute.CharCode, valute.Nominal, valute.Name, valute.Value, valute.Previous));
            }
            return valutesCloned;
        }
    }
}
