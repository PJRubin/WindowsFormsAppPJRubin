using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace WindowsFormsAppPJRubin
{
    class ReadXML
    {
        public ReadXML()
        {

        }
        public Book readXML()
        {
            XmlTextReader reader = new XmlTextReader("BooksXML.xml");
            Book b = new Book();
            string title = "not set";
            string authorfname = "not set";
            string authorlname = "not set";
            string publisher = "not set";
            while (reader.Read())
            {
                var type = reader.NodeType;
                
                if (reader.NodeType == XmlNodeType.Text && title.Equals("not set"))
                {
                    
                    title = reader.Value;
                    int w = title.IndexOf("\t");
                    title = title.Substring(0, w);
                }
                else if (reader.NodeType == XmlNodeType.Text && authorfname.Equals("not set"))
                {
                    authorfname = reader.Value;
                    int w = authorfname.IndexOf("\t");
                    authorfname = authorfname.Substring(0, w);
                }
                else if (reader.NodeType == XmlNodeType.Text && authorlname.Equals("not set"))
                {
                    authorlname = reader.Value;
                    int w = authorlname.IndexOf("\t");
                    authorlname = authorlname.Substring(0, w);
                }
                else if (reader.NodeType == XmlNodeType.Text && publisher.Equals("not set"))
                {
                    publisher = reader.Value;
                    int w = publisher.IndexOf("\t");
                    publisher = publisher.Substring(0, w);
                }

                


            }
            Author a = new Author(authorfname, authorlname);
            b = new Book(title, a, publisher);
            return b;

        }
    }
}
