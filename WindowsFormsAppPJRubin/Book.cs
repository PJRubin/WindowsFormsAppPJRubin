using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsAppPJRubin
{
    class Book : IReadable
    {
        string title;
        string author;
        string publisher;
        int publishedYear;
        public Book(string inTitle, string inAuthor)
        {
            title = inTitle;
            author = inAuthor;
            publisher = "Unknown";
            publishedYear = 0;
        }

        public Book(string inTitle, string inAuthor, string inPublisher)
        {
            title = inTitle;
            author = inAuthor;
            publisher = inPublisher;
            publishedYear = 0;
        }

        public Book(string inTitle, string inAuthor, string inPublisher, int inPublishedYear)
        {
            title = inTitle;
            author = inAuthor;
            publisher = inPublisher;
            publishedYear = inPublishedYear;
        }

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public int PublishedYear { get => publishedYear; set => publishedYear = value; }
    }
}
