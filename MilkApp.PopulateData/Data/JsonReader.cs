using MilkApp.PopulateData.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkApp.PopulateData.Data
{
    internal class JsonReader
    {
        private class MilkResults
        {
            public List<Milk> Results { get; set; }
        }

       
        public static List<Milk> GetMilkData(string path)
        {
            var json = File.ReadAllText(path);
            var jsonFileFormat = JsonConvert.DeserializeObject<MilkResults>(json);
            return jsonFileFormat.Results;
        }
    }
}
