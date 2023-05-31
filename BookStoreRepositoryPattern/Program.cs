using BookStoreRepositoryPattern.BusinessLayer;
using BookStoreRepositoryPattern.DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreRepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BookStore bookStore = new BookStore(new BookRepository());
            bool isRunning = true;
            try {
                while (isRunning)
                {
                    Console.WriteLine("Type L for List, A for Add, U for Update, D for Delete, S for Search, C for Clear, E for Exit");
                    string command = Console.ReadLine();
                    if (command == "L")
                    {
                        List<Book> _listBook = bookStore.Get();
                        Console.WriteLine("List of Book:");
                        Console.WriteLine("ÏD\tBook Name\tAuthor\tPrice\tPublised Date");
                        foreach (var b in _listBook)
                            Console.WriteLine($"{b.BookID}\t{b.BookName}\t{b.Author}\t{b.Price}\t{b.PublishedDate}");
                    }
                    else if (command == "S")
                    {
                        Console.Write("Input a id to find Book Information: ");
                        int id = int.Parse(Console.ReadLine());
                        Book aBook = bookStore.Get(id);
                        Console.WriteLine($"BookID: {aBook.BookID}\t BookName: {aBook.BookName}\tAuthor: {aBook.Author}\tPrice: {aBook.Price}\tPublished Date: {aBook.PublishedDate}");
                    }
                    else if (command == "A")
                    {
                        Console.Write("Enter Book ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Book Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Author Name: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter Book Price: ");
                        double price = double.Parse(Console.ReadLine());
                        Console.Write("Enter Published Date(dd/mm/yyyy): ");
                        string date = Console.ReadLine();
                        Book book = new Book();
                        book.BookID = id;
                        book.BookName = name;
                        book.Author = author;
                        book.Price = price;
                        book.PublishedDate = date;
                        bool isExecuted = bookStore.Add(book);
                        if (isExecuted)
                        {
                            Console.WriteLine("Added succesfully");
                        }
                        else
                        {
                            Console.WriteLine("Failde to add.");
                        }
                    }
                    else if (command == "U")
                    {
                        Console.Write("Enter Book ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Book Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Author Name: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter Book Price: ");
                        double price = double.Parse(Console.ReadLine());
                        Console.Write("Enter Published Date(dd/mm/yyyy): ");
                        string date = Console.ReadLine();
                        Book book = new Book();
                        book.BookID = id;
                        book.BookName = name;
                        book.Author = author;
                        book.Price = price;
                        book.PublishedDate = date;

                        bool isExecuted = bookStore.Update(book);
                        if (isExecuted)
                        {
                            Console.WriteLine("Added succesfully");
                        }
                        else
                        {
                            Console.WriteLine("Failde to add.");
                        }
                    }
                    else if (command == "D")
                    {
                        Console.WriteLine("Enter a BookID to deleate");
                        int id = int.Parse(Console.ReadLine());
                        bool isExecuted = bookStore.Delete(id);
                        if (isExecuted)
                        {
                            Console.WriteLine("Deleted Succesfully.");

                        }
                        else
                        {
                            Console.WriteLine("Failed to delete.");
                        }



                    }
                    else if (command == "C")
                    {
                        Console.Clear();
                    }
                    else if (command == "E")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: "+ex.Message);
            }
        }
    }
}
