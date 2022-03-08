using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilhaDinamicaEncadead
{
    internal class Pilha_Livro
    {
        public Livro Topo { get; set; }
        int contadorDeLivros = 0;

        public Pilha_Livro()
        {
            Topo = null;
        }



        public void Push(Livro aux)
        {
            aux.Anterior = Topo;
            Topo = aux;
            contadorDeLivros++;
        }

        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("Não contém livros nessa pilha");
            }
            else
            {
                Topo = Topo.Anterior;
                contadorDeLivros--;
            }
        }

        public void QuantidadeDeLivrosTotal()
        {
            Console.WriteLine("\nO total de livros é: " + contadorDeLivros + "\n");
        }

        public void Print()
        {
            if (Vazia())
            {
                Console.WriteLine("Não contém livros nessa pilha");
            }
            else
            {
                Livro aux = Topo;
                do
                {
                    Console.WriteLine("Os livros que estão na pilha são: ");
                    Console.WriteLine(aux.ToString());
                    Console.ReadKey();
                    Console.Clear();
                    aux = aux.Anterior;
                } while (aux != null);
            }
        }

        public void BuscarISBN()
        {
            if (Vazia())
            {
                Console.WriteLine("Nenhum livro para busca");
            } else
            {
                Livro aux = Topo;
                Console.WriteLine("Infome o ISBN do livro para pesquisar: ");
                int buscarISBN = Int32.Parse(Console.ReadLine());
                if (buscarISBN == aux.ISBN)
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("\n" + aux.ToString());
                    Console.WriteLine("---------------------------------------");
                    Console.ReadLine();
                }
            }
        }
        public void BuscarNome()
        {
            if (Vazia())
            {
                Console.WriteLine("Nenhum livro para busca");
            }
            else
            {
                Livro aux = Topo;
                Console.WriteLine("Informe o nome do livro para pesquisar: ");
                string buscarLivro = Console.ReadLine();
                if (buscarLivro == aux.Titulo)
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("\n" + aux.ToString());
                    Console.WriteLine("---------------------------------------");
                    Console.ReadLine();
                }
            }
        }

        public bool Vazia()
        {
            if (Topo == null)
                return true;
            else
                return false;
        }

    }
}
