using System;

namespace pilhaDinamicaEncadead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao, isbn, anoDePublicacao;
            string tituloDoLivro;
            Pilha_Livro pilhaDeLivros = new Pilha_Livro();
            
            void InserirLivro()
            {
                Console.WriteLine("Cadastro de Livros");
                Console.WriteLine("Insira o ISBN do Livro: ");
                isbn = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Insira o título do Livro: ");
                tituloDoLivro = Console.ReadLine();
                Console.WriteLine("Insira o Ano de Publicação do Livro");
                anoDePublicacao = Int32.Parse(Console.ReadLine());
                pilhaDeLivros.Push(new Livro(isbn, tituloDoLivro, anoDePublicacao));
            }

            void RemoverLivro()
            {
                Console.WriteLine("Removendo um livro da Pilha");
                pilhaDeLivros.Pop();
                Console.ReadLine();
            }

            void ImprimirLivros()
            {
                Console.WriteLine("Imprimir a relação de Livros Cadastrados");
                pilhaDeLivros.Print();
                Console.ReadLine();
            }

            void QuantidadeDeLivrosNaPilha()
            {
                Console.WriteLine("Quantidade de Livros na Pilha");
                pilhaDeLivros.QuantidadeDeLivrosTotal();
                Console.ReadKey();
            }

            do
            {
                Console.Clear();
                Console.WriteLine("Por favor selecione uma opção do menu: ");
                Console.WriteLine("1 - Cadastrar Livros\n2 - Remover Livros\n3 - Imprimir toda realação de Livros" +
                    "\n4 - Recuperar a quantidade de livros da pilha\n5 - Buscar um livro por ISBN\n6 - Buscar um livro por título" +
                    "\n7 - Sair");
                opcao = Int32.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        InserirLivro();
                        break;
                    case 2:
                        RemoverLivro();
                        break;
                    case 3:
                        ImprimirLivros();
                        break;
                    case 4:
                        QuantidadeDeLivrosNaPilha();
                        break;
                    case 5:
                        pilhaDeLivros.BuscarISBN();
                        break;
                    case 6:
                        pilhaDeLivros.BuscarNome();
                        break;
                    case 7:
                        break;
                }
            } while (opcao != 7);
            Console.ReadKey();
        }
    }
}