using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contatos
{
    internal class ListaPessoa
    {

        public Contato Head { get; set; }
        public Contato Tail { get; set; }

        public ListaPessoa()
        {
            Head = Tail = null;
        }


        public void pop()
        {
            if (empty())
            {
                Console.WriteLine("Não existem contatos para serem removidos.\nPressione ENTER para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Digite um nome para buscar:");
                Console.Write("Nome:");
                string busca = Console.ReadLine();
                Console.Clear();
                // Até aqui eu trabalhei com a lista vazia e digitei o nome que eu quero encontrar.
                if (Head == Tail)
                {
                    Head = null;
                    Tail = null;
                    Console.WriteLine($"\nContato {busca} removido com sucesso. Sua lista agora está vazia.\nPressione ENTER para voltar ao MENU.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    if (busca == Head.Nome)
                    {
                        Head = Head.Next;
                        Console.WriteLine($"\nContato {busca} removido com sucesso.\nPressione ENTER para voltar ao MENU.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Contato aux1 = Head;
                        Contato aux2 = Head;
                        do
                        {
                            if (busca.ToLower() == aux1.Nome.ToLower())
                            {
                                aux2 = aux1.Next;
                                Console.WriteLine("\n\nPressione ENTER para voltar ao MENU.");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                aux2 = aux1;
                                aux1 = aux1.Next;
                            }
                        } while (aux1 != null);
                    }
                }
            }
        } //falta descobrir como fazer.

        public void find()
        {
            if (empty())
            {
                Console.WriteLine("Não existem contatos cadastrados.\nPressione ENTER para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Digite um nome para buscar:");
                Console.Write("Nome:");
                string busca = Console.ReadLine();
                Contato aux = Head;
                Console.Clear();
                do
                {
                    if (busca.ToLower() == aux.Nome.ToLower())
                    {
                        Console.WriteLine(aux.ToString());
                        Console.WriteLine("\nPressione ENTER para voltar ao MENU.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        aux = aux.Next;
                    }
                } while (aux != null);
            }
        }

        public void print()
        {
            if (empty())
            {
                Console.WriteLine($"Não existem contatos cadastrados!\nPressione ENTER para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Contato aux = Head;
                Console.WriteLine("");
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Next;
                    Console.WriteLine("Pressione ENTER para ver o próximo contato");
                    Console.ReadKey();
                    Console.Clear();
                } while (aux != null);
                Console.WriteLine("Fim dos contatos.\n\nPressione ENTER para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public bool empty()
        {
            if (Head == null)
                return true;
            else
                return false;
        }
        public void push(Contato aux)
        {
            if (Head == null && Tail == null) //insere na lista vazia
            {
                Head = aux;
                Tail = aux;
                Console.WriteLine("\nCadastro inserido com sucesso!\nPressione ENTER para continuar...");
                Console.ReadKey();
            }
            else
            {
                //é aqui que começa a comparacao de string.
                int compT = String.Compare(aux.Nome, Tail.Nome, StringComparison.OrdinalIgnoreCase);
                int compH = String.Compare(aux.Nome, Head.Nome, StringComparison.OrdinalIgnoreCase);

                if (compT > 0)//se o auxiliar for maior do Que a tail, insere no fim dessa forma:
                {
                    aux.Prev = Tail;
                    Tail.Next = aux;
                    Tail = aux;

                    Console.WriteLine("\nCadastro inserido com sucesso!\nPressione ENTER para continuar...");
                    Console.ReadKey();
                }
                else
                {
                    if (compH < 0)//se o auxiliar for menor que a head, insere no começo dessa forma):
                    {
                        aux.Next = Head;
                        Head.Prev = aux; //copiei do Fabio
                        Head = aux;
                        Console.WriteLine("\nCadastro inserido com sucesso!\nPressione ENTER para continuar...");
                        Console.ReadKey();
                    }
                    else
                    {
                        var aux1 = Tail;
                        do
                        {
                        int compA = String.Compare(aux.Nome, aux1.Nome, StringComparison.OrdinalIgnoreCase);
                            if (compA > 0)
                            {
                                //preciso colocar o meu aux entre o aux 1 e o proximo do aux 1.

                                aux.Next = aux1.Next; // consegui fazer o auxiliar encadear pra frente.
                                aux.Prev = aux1;
                                Tail = aux;//depois preciso que minha tail receba o aux com todos os nomes(isso eu sei fazer!)
                                break;
                            }
                            else
                            {
                            aux1 = aux1.Prev;
                            }
                        }while (true);













                        //var aux1 = Tail;
                        //do //crio o laço pra percorrer a lista
                        //{
                        //    int compA = String.Compare(aux.Nome, aux1.Nome, StringComparison.OrdinalIgnoreCase);

                        //    if (compA > 0) //se for maior que 
                        //    {
                        //        aux1 = Tail.Prev;
                        //    }
                        //    else 
                        //    {
                        //        Tail.Prev = aux;
                        //        aux.Next = Head;
                        //        Console.WriteLine("\nCadastro inserido com sucesso!\nPressione ENTER para continuar...");
                        //        Console.ReadKey();
                        //        break;
                        //    }
                        //} while (true);
                    }
                }
            }
        }
    }
}


