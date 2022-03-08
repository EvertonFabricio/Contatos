using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contatos
{
    internal class Contato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Telefone Telefones { get; set; }
        public Contato Next { get; set; }
        public Contato Prev { get; set; }
        public Contato(string nome, string email, Telefone telefones)
        {
            Nome = nome;
            Email = email;
            Telefones = telefones;
            Next = null;
            Prev = null;
        }

        public override string ToString()
        {
            return $"\nContato: {Nome}\ne-mail: {Email}\nTelefone: {Telefones.ToString()}\n";
        }
    }
}
