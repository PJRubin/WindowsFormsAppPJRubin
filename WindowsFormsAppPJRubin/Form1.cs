﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPJRubin
{
    public partial class Form1 : Form
    {
        BookList readingList;
        public Form1()
        {
            
            InitializeComponent();
            readingList = new BookList();
            


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
           
            string title = TitleTextBox.Text.ToString();
            string authorfname = FNameTextBox.Text.ToString();
            string authorlname = LNameTextBox.Text.ToString();
            Author author = new Author(authorfname, authorlname);
            
            string publisher = PublisherTextBox.Text.ToString();
            Book book = new Book(title, author, publisher);
            readingList.addBook(book);
            updateListBox();

        }

        private void updateListBox()
        {
            IEnumerable<IReadable> books = readingList.getItems();

            listBox1.Items.Clear();

            foreach (Book book in books)
            {
                listBox1.Items.Add(book);
            }

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int item = listBox1.SelectedIndex;
            Book selectedBook = (Book)listBox1.SelectedItem;
            readingList.Remove(selectedBook);

            updateListBox();
        }
    }
}
