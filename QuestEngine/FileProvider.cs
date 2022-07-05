using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace QuestEngine
{
   public class FileProvider<T>
    {
        public static T ReadObject(string path)
        {
            using (FileStream f = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(f))
                {
                    var textFromFile = sr.ReadToEnd();
                    var temp = JsonSerializer.Deserialize<T>(textFromFile);
                    return temp;
                }
            }
        }
        public static async Task WriteObject(T obj, string path)
        {

            using (StreamWriter sw = new StreamWriter(path))
            {
                var json = JsonSerializer.Serialize(obj);
                await sw.WriteAsync(json);
            }

        }
    }
}
