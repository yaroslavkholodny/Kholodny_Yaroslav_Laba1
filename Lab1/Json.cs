using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Lab1
{
    static class Json
    {
        public static void Serializer(string file , Drib drib)
        {
            File.WriteAllText(file, JsonConvert.SerializeObject(drib));
        }

        public static Drib Deserializer(string file )
        {
             Drib drib = JsonConvert.DeserializeObject<Drib>(File.ReadAllText(file));

            using (StreamReader file1 = File.OpenText(file))
            {
                JsonSerializer serializer = new JsonSerializer();
                Drib drib2 = (Drib)serializer.Deserialize(file1, typeof(Drib));
                return drib2;
            }
        }
    }
}
