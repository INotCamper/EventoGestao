using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoGestao.Objects
{
    [Serializable]
    public class Cafe
    {
        public string nome { get; set; }
        public int lotacao { get; set; }
        public string[] pessoas1 { get; set; }
        public string[] pessoas2 { get; set; }
        public Cafe() { }
        public Cafe(string n, int l)
        {
            nome = n;
            lotacao = l;
        }
    }
}
