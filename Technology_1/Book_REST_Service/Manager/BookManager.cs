using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_Library;

namespace Book_REST_Service.Manager
{
    public class BookManager
    {
        public static List<Book> books;

        public BookManager()
        {
            books = new List<Book>();
            books.Add(new Book
                {
                    Author = "Andersen",
                    ISBN13 = "CODE2013",
                    PageNo = 300,
                    Title = "Learn the basics of C#"
                }
            );

            books.Add(new Book
                {
                    Author = "Petersen",
                    ISBN13 = "CODE2015",
                    PageNo = 250,
                    Title = "Learn the basics of C++"
                }
            );
        }

        public List<Book> GetList(string title, string author)
        {
            List<Book> result = new List<Book>(books);
            if (!string.IsNullOrEmpty(title))
            {
                result = result.FindAll(book => book.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
            }

            if (!String.IsNullOrEmpty(author))
            {
                result = (result.FindAll(item => item.Author.StartsWith(author, StringComparison.OrdinalIgnoreCase)));
            }

            return result;
        }

        public Book GetBookById(string ISBN13)
        {
            return books.Find(book => book.ISBN13.Equals(ISBN13, StringComparison.OrdinalIgnoreCase));
        }

        public Book AddBook(Book newBook)
        {
            books.Add(newBook);
            return newBook;
        }

        public Book DeleteBook(string ISBN13)
        {
            Book book = books.Find(book => book.ISBN13 == ISBN13);
            books.Remove(book);
            return book;
        }

        public Book UpdateBook(string ISBN13,Book b)
        {
            Book book = books.Find(book => book.ISBN13 ==ISBN13);
            book.Author = b.Author;
            book.PageNo = b.PageNo;
            book.Title = b.Title;
            return book;
        }
    }
}
