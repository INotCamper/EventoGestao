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
        //Serializa qualquer tipo de dado recebendo um filepath e o dado
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
        //Deserializa um tipo especifico de dado e retorna ele
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
        //Deserializa um tipo especifico de dado e retorna ele
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
        //Deserializa um tipo especifico de dado e retorna ele
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

        //Deserializa um tipo especifico de dado procura algo dentro da lista de dados e retorna o dado pesquisado
        public Evento SearchEvento(string n, string filePath)
        {
            List<Evento> le = JsonDeserializeEvento(filePath);
            if (le == null)
            {
                Evento nul = null;
                return nul;
            }
            Evento e = le.Find(x => x.nome == n);
            return e;
        }
        //Deserializa um tipo especifico de dado procura algo dentro da lista de dados e retorna o dado pesquisado
        public Cafe SearchCafe(string n, string filePath)
        {
            List<Cafe> le = JsonDeserializeCafe(filePath);
            if (le == null)
            {
                Cafe nul = null;
                return nul;
            }
            Cafe c = le.Find(x => x.nome == n);
            return c;
        }
        //Deserializa um tipo especifico de dado procura algo dentro da lista de dados e retorna o dado pesquisado
        public Pessoa SearchPessoa(string n, string s, string filePath)
        {
            List<Pessoa> le = JsonDeserializePessoas(filePath);
            if (le == null)
            {
                Pessoa nul = null;
                return nul;
            }
            Pessoa p = le.Find(x => x.nome == n && x.sobrenome == s);
            return p;
        }

        //Ajuda cada Deserializador a recriar um objeto com base no JSON puro
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
