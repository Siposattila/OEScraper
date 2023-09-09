using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace OEScraper
{
    internal static class ConsoleIO
    {
        public static void Output(ContactData contactData)
        {
            Console.WriteLine(JsonConvert.SerializeObject(contactData, Formatting.Indented));
        }

        public static void Outputs(List<ContactData> contactDatas)
        {
            foreach (ContactData contactData in contactDatas)
            {
                ConsoleIO.Output(contactData);
            }
        }
    }
}
