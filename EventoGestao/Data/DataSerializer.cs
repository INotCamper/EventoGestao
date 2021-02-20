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
        /*
        private JObject JsonDeserializeJObject(string filePath)
        {
            JObject o = null;
            JsonSerializer jsonSerializer = new JsonSerializer();
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath);
                JsonReader jsonReader = new JsonTextReader(sr);
                o = jsonSerializer.Deserialize(jsonReader) as JObject;
                jsonReader.Close();
                sr.Close();
            }
            return o;
        }
        */

        public Evento SearchEvento(string n, string filePath)
        {
            List<Evento> le = JsonDeserializeEvento(filePath);
            Evento e = le.Find(x => x.nome == n);
            return e;
        }
        public Cafe SearchCafe(string n, string filePath)
        {
            List<Cafe> le = JsonDeserializeCafe(filePath);
            Cafe c = le.Find(x => x.nome == n);
            return c;
        }
        public Pessoa SearchPessoa(string n, string s, string filePath)
        {
            List<Pessoa> le = JsonDeserializePessoas(filePath);
            Pessoa p = le.Find(x => x.nome == n && x.sobrenome == s);
            return p;
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
