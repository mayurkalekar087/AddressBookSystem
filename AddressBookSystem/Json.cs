using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
namespace AddressBookSystem
{
    class Json
    {
        const string JSONPATH = @"C:\Users\ASUS\source\repos\AddressBookSystem\AddressBookSystem\StoredContactJson.json";
        public static void WriteToJson(Dictionary<string, Contact> DictName)
        {
            if (File.Exists(JSONPATH))
            {
                string Json = JsonConvert.SerializeObject(DictName);
                using (StreamWriter sw = new StreamWriter(JSONPATH))
                {
                    sw.WriteLine(Json);
                }
            }
        }
    }
}
