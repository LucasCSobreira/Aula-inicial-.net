using System;
using System.Collections.Generic;

namespace Aula_inicial_.net
{
    class Program
    {
        static void Main(string[] args)
        {

            var booklist = new List<Book>();

            string useroption = MainMenu();
            
            while(useroption != "0")
            {

                if (useroption.Equals("1"))
                {

                    //Sistema de Cadastro
                    string repeat = "0";
                    while(repeat != "n")
                    {
                        
                        Console.Write("Digite o título do livro: ");
                        string TempBookName = Console.ReadLine();
                        Console.Clear();

                        Console.Write("Digite o nome do autor: ");
                        string TempBookAuthor = Console.ReadLine();
                        Console.Clear();

                        Console.Write("Digite a edição do livro: ");
                        string TempBookEdition = Console.ReadLine();
                        Console.Clear();

                        Console.WriteLine("Você deseja cadastrar o livro abaixo?");
                        Console.WriteLine($"Título: {TempBookName}, do autor(a): {TempBookAuthor}, {TempBookEdition} Edição.");
                        Console.WriteLine();
                        Console.WriteLine("s/n?");
                        string confirm = Console.ReadLine();
                        Console.Clear();


                        if (confirm.Equals("s"))
                        {

                                                       
                            var TempBook = new Book()
                            {
                                
                                BookName = TempBookName,
                                BookAuthor = TempBookAuthor,
                                BookEdition = TempBookEdition

                            };
                            booklist.Add(TempBook);


                            Console.WriteLine("Livro cadastrado com sucesso!");
                            Console.WriteLine("Deseja cadastrar um novo livro?");
                            Console.WriteLine();
                            Console.WriteLine("s/n?");
                            repeat = Console.ReadLine();
                            Console.Clear();


                        }
                        else
                        {

                            Console.WriteLine("Livro não cadastrado no sistema.");
                            Console.WriteLine("Ainda deseja cadastrar um novo livro?");
                            Console.WriteLine();
                            Console.WriteLine("s/n?");
                            repeat = Console.ReadLine();
                            Console.Clear();


                        }


                    }
                                     
                   
                }else if (useroption.Equals("2"))
                {

                    //Sistema de Listagem
                    string repeat = "0";
                    while (repeat != "s"){

                        foreach (var book in booklist)
                        {

                            Console.WriteLine($"Título: {book.BookName} - Autor(a): {book.BookAuthor} - {book.BookEdition} Edição.");

                        };
                        Console.WriteLine();
                        Console.WriteLine("Deseja retornar ao menu anterior?");
                        Console.WriteLine("s/n?");
                        repeat = Console.ReadLine();
                        Console.Clear();

                    }
               
                }
                else
                {
                    Console.WriteLine("Opção Inválida!");
                    Console.WriteLine();
                }

                useroption = MainMenu();

            }
        }


        private static string MainMenu()
        {
           
            Console.WriteLine("Selecione sua Opção!");
            Console.WriteLine("1 - Cadastrar Livros");
            Console.WriteLine("2 - Listar Livros");
            Console.WriteLine("0 - Sair");
            Console.WriteLine();
            Console.Write("Escolha sua opção.. ");
            string option = Console.ReadLine();
            Console.WriteLine();
            Console.Clear();
            return option;
        }
    }
}
