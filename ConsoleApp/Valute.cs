﻿
namespace ConsoleApp
{
    class Valute
    {
        public string ID { get; set; }
        public string NumCode { get; set; }
        public string CharCode { get; set; }
        public int Nominal { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public decimal Previous { get; set; }

        public Valute(string iD, string numCode, string charCode, int nominal, string name, decimal value, decimal previous)
        {
            ID = iD;
            NumCode = numCode;
            CharCode = charCode;
            Nominal = nominal;
            Name = name;
            Value = value;
            Previous = previous;
        }
    }
}
