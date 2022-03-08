using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contatos
{
    internal class Telefone
    {
        public string Tel { get; set; }
        public string DDD { get; set; }
        public string Tipo { get; set; }
        public Telefone Next { get; set; }

        public Telefone(string dDD, string tel, string tipo)
        {
            Tel = tel;
            DDD = dDD;
            Tipo = tipo;
        }

        public override string ToString()
        {
            return $"Telefone {Tipo}: ({DDD}) {Tel}.";
        }
    }
}
