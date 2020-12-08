using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsAppPJRubin
{
    public class Author : IPerson
    {
        string firstName;
        string lastName;
        public Author(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }
}
