using System;
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
            String title = TitleTextBox.Text.ToString();
            String author = AuthorTextBox.Text.ToString();
            String publisher = PublisherTextBox.Text.ToString();
            Book book = new Book(title, author, publisher);
            readingList.addBook(book);

        }

        private void updateListBox()
        {
            IEnumerable<IReadable> books = readingList.GetItems();

            listBox1.Items.Clear();
            //listBox1.Items = listController.GetItemDescriptionList();

            listBox1.DisplayMember = "Description";
            listBox1.ValueMember = "Id";
            foreach (ShoppingItem item in items)
            {
                listBox1.Items.Add(item);
            }

        }
    }
}
