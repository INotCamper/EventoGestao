using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventoGestao.Objects;
using System.Diagnostics;

namespace EventoGestao.Data
{
    public class DataSerializer
    {
        public void JsonSerialize(object data, string filePath)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();
            if (File.Exists(filePath)) File.Delete(filePath);
            StreamWriter sw = new StreamWriter(filePath);
            JsonWriter jsonWriter = new JsonTextWriter(sw);

            jsonSerializer.Serialize(jsonWriter, data);

            jsonWriter.Close();
            sw.Close();
        }
        public List<Pessoa> JsonDeserializePessoas(string filePath)
        {
            List<Pessoa> p = null;
            if (File.Exists(filePath))
            {
                var rawJson = File.ReadAllText(filePath);
                p = ToClass<List<Pessoa>>(rawJson);
            }
            return p;
        }
        public List<Evento> JsonDeserializeEvento(string filePath)
        {
            List<Evento> e = null;
            if (File.Exists(filePath))
            {
                var rawJson = File.ReadAllText(filePath);
                e = ToClass<List<Evento>>(rawJson);
            }
            return e;
        }
        public List<Cafe> JsonDeserializeCafe(string filePath)
        {
            List<Cafe> c = null;
            if (File.Exists(filePath))
            {
                var rawJson = File.ReadAllText(filePath);
                c = ToClass<List<Cafe>>(rawJson);
            }
            return c;
        }

        public static T ToClass<T>(string data, JsonSerializerSettings jsonSettings = null)
        {
            var response = default(T);

            if (!string.IsNullOrEmpty(data))
                response = jsonSettings == null
                    ? JsonConvert.DeserializeObject<T>(data)
                    : JsonConvert.DeserializeObject<T>(data, jsonSettings);

            return response;
        }
    }
}
