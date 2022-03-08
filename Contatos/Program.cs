using System;

namespace Contatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaPessoa listaPessoa = new ListaPessoa();
            Telefone t1;


            do
            {
            Console.WriteLine(">>>>Agenda de Contatos<<<<\nDigite a opção Desejada:");
            Console.WriteLine("\n1 - Inserir contato\n2 - Localizar contato\n3 - Editar contato\n4 - Remover contato\n5 - Imprimir contatos\n0 - Sair\n");

                string menu = Console.ReadLine();
                Console.Clear();
                switch (menu)
                {
                    case "1":
                        //insere o contato
                        string nome, email, tel, ddd, tipo;
                        t1 = new Telefone("teste", "teste", "teste");

                        listaPessoa.push(new Contato("c", "c",t1));
                        listaPessoa.push(new Contato("f", "f", t1));
                        listaPessoa.push(new Contato("a", "a", t1));
                        listaPessoa.push(new Contato("g", "g", t1));
                        listaPessoa.push(new Contato("e", "e", t1));
                        listaPessoa.push(new Contato("d", "d", t1));

                        //Console.WriteLine("Digite o nome do contato: ");
                        //nome = Console.ReadLine();
                        //Console.WriteLine("\nDigite o email do contato: ");
                        //email = Console.ReadLine();
                        //Console.WriteLine("\nDigite o telefone do contato: ");
                        //Console.Write("DDD: ");
                        //ddd = Console.ReadLine();
                        //Console.Write("Telefone: ");
                        //tel = Console.ReadLine();
                        //Console.Write("Tipo: ");
                        //tipo = Console.ReadLine();
                        //t1 = new Telefone(ddd,tel,tipo);
                        //listaPessoa.push(new Pessoa(nome, email, t1));
                        //Console.Clear();
                        break;

                    case "2":
                        listaPessoa.find();
                        break;

                    case "3":
                        //Edita
                        break;

                    case "4":
                        listaPessoa.pop();
                        break;

                    case "5":
                        listaPessoa.print();
                        break;


                    case "0":
                        //sair
                        break;

                    default:
                        Console.WriteLine("Opção invalida. Tente novamente.");
                        Console.Clear();
                        break;
                }
                if (menu == "0")
                    break;
            }
            while (true);
        }
    }
}





















