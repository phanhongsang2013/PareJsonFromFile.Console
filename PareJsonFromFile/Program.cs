using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PareJsonFromFile
{
    public class DataModel
    {
        public string name { get; set; }
        public string code { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var path = Path.GetFullPath("countries.json");
            LoadJson(path);
        }

        public static void LoadJson(string path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                List<DataModel> items = JsonConvert.DeserializeObject<List<DataModel>>(json);
            }
        }

        void InsertNationToDB(List<DataModel> data)
        {

        }

    }
}
