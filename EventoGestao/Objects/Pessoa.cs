using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoGestao.Objects
{
    [Serializable]
    public class Pessoa
    {
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string evento1 { get; set; }
        public string evento2 { get; set; }
        public string cafe1 { get; set; }
        public string cafe2 { get; set; }
        public Pessoa() { }
        public Pessoa(string n, string sn)
        {
            nome = n;
            sobrenome = sn;
        }
    }
}
