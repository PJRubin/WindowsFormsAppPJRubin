using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsAppPJRubin
{
    public class Book : IReadable
    {
        string title;
        Author author;
        string publisher;
        int publishedYear;

        
        public Book()
        {
            title = "unknown";
            author = new Author("unknown", "unknown");
            publisher = "unknown";
            publishedYear = 0;
        }
        public Book(string inTitle, string inAuthor)
        {
            title = inTitle;
            author = new Author(inAuthor, "");
            publisher = "Unknown";
            publishedYear = 0;
        }

        public Book(string inTitle, Author inAuthor, string inPublisher)
        {
            title = inTitle;
            author = inAuthor;
            publisher = inPublisher;
            publishedYear = 0;
        }

        public Book(string inTitle, string inAuthor, string inPublisher)
        {
            title = inTitle;
            author = new Author(inAuthor, "");
            publisher = inPublisher;
            publishedYear = 0;
        }

        public Book(string inTitle, string inAuthor, string inPublisher, int inPublishedYear)
        {
            title = inTitle;
            author = new Author(inAuthor, "");
            publisher = inPublisher;
            publishedYear = inPublishedYear;
        }

        public string Title { get => title; set => title = value; }
        Author IReadable.author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public int PublishedYear { get => publishedYear; set => publishedYear = value; }

        public override string ToString()
        {
            return title + " by " + author.FirstName + " " + author.LastName;
        }
        
    }
}
