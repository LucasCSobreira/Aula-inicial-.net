using System;
using System.Collections.Generic;

namespace Aula_inicial_.net
{
    class Program
    {
        public const string REGISTER_BOOK_OPTION = "1";
        public const string LIST_BOOKS_OPTION = "2";
        public const string LEAVE_OPTION = "0";
        static void Main(string[] args)
        {

            var booklist = new List<Book>();

            string useroption = MainMenu();

            while (useroption != LEAVE_OPTION)
            {

                if (useroption.Equals(REGISTER_BOOK_OPTION))
                {
                    AddNewBook(booklist);
                }
                else if (useroption.Equals(LIST_BOOKS_OPTION))
                {
                    GetAllBooks(booklist);
                }
                else
                {
                    Console.WriteLine(Constants.DEFAULT_INVALID_MESSAGE);
                    Console.WriteLine();
                }

                useroption = MainMenu();

            }
        }

        #region Private Methods
        private static void AddNewBook(List<Book> bookList)
        {
            var repeat = string.Empty;
            while (repeat != "n")
            {
                var tempBook = new Book();
                Console.Write(Constants.DEFAULT_BOOK_TITLE_REQUEST);
                tempBook.BookName = Console.ReadLine();
                Console.Clear();

                Console.Write(Constants.DEFAULT_BOOK_AUTHOR_REQUEST);
                tempBook.BookAuthor = Console.ReadLine();
                Console.Clear();

                Console.Write(Constants.DEFAULT_BOOK_EDITION_REQUEST);
                tempBook.BookEdition = Console.ReadLine();
                Console.Clear();

                Console.WriteLine($"Você deseja cadastrar o livro abaixo?\nTítulo: {tempBook.BookName}, do autor(a): {tempBook.BookAuthor}, {tempBook.BookEdition} Edição.\n");
                Console.WriteLine("s/n?");
                string confirm = Console.ReadLine();
                Console.Clear();


                if (confirm.Equals("s"))
                {
                    bookList.Add(tempBook);

                    Console.WriteLine(Constants.SUCCESSFUL_REGISTER_MESSAGE);
                    Console.WriteLine("s/n?");
                    repeat = Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine(Constants.UNSUCCESSFUL_REGISTER_MESSAGE);
                    Console.WriteLine("s/n?");
                    repeat = Console.ReadLine();
                    Console.Clear();
                }


            }
        }

        private static void GetAllBooks(List<Book> booklist)
        {
            var repeat = string.Empty;
            while (repeat != "s")
            {
                if (booklist.Count > 0)
                {
                    foreach (var book in booklist)
                    {

                        Console.WriteLine($"Título: {book.BookName} - Autor(a): {book.BookAuthor} - {book.BookEdition} Edição.\n");

                    };
                }
                else
                {
                    Console.WriteLine("Ainda não consta nenhum livro cadastrado no sistema!\n");
                }
                Console.WriteLine("Deseja retornar ao menu anterior?");
                Console.WriteLine("s/n?");
                repeat = Console.ReadLine();
                Console.Clear();
            }
        }

        private static string MainMenu()
        {

            Console.WriteLine("Selecione sua Opção!\n1 - Cadastrar Livros\n2 - Listar Livros\n0 - Sair\n\nEscolha sua opção...");
            string option = Console.ReadLine();
            Console.WriteLine();
            Console.Clear();
            return option;
        }

        #endregion
    }
}
