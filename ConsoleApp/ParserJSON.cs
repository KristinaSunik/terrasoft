using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp
{
    static class ParserJSON
    {
        public static List<Valute> GetValutes(string path)
        {
            List<Valute> valutes = new List<Valute>();
            var serializedvalute = Get(path).Split('}');
            foreach (var item in serializedvalute)
            {
                if (item.Length > 20)
                {
                    string substr = item.Substring(17, item.Length - 19);

                    valutes.Add(JsonConvert.DeserializeObject<Valute>(substr.Insert(substr.Length - 1, "}")));
                }
            }

            return valutes;
        }

        private static string Get(string path)
        {
            var Client = new System.Net.WebClient();
            string data;
            try
            {
                Stream potok = Client.OpenRead(path);
                var reader = new StreamReader(potok);
                data = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception exp)
            {
                throw new Exception($"Problems with reading web page {path}. {exp}");
            }

            int index = data.IndexOf("Valute") + 8;
            data = data.Substring(index);

            return data;
        }
    }


}
