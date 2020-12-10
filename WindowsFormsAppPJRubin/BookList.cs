using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsAppPJRubin
{
    public class BookList
    {
        List<Book> bookList;

        public BookList() 
        {
            bookList = new List<Book>();
        }

        public BookList(List<Book> inList)
        {
            bookList = inList;
        }

        public void addBook(Book inBook)
        {
            bookList.Add(inBook);
        }

        public IEnumerable<IReadable> getItems()
        {
            List<Book> newList = new List<Book>();

            foreach (Book book in bookList)
            {

                    newList.Add(book);
                
            }

            return newList;
        }

        public Book searchFor(string inTitle)
        {
            foreach (Book book in bookList)
            {
                if (book.Title.Equals(inTitle))
                {
                    return book;
                    
                }
               

            }
            return new Book();

        }

        public void Remove(Book inBook)
        {
            bookList.Remove(inBook);
        }
    }
}
