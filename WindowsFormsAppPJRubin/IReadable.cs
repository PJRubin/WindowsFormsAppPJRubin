using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsAppPJRubin
{
    interface IReadable
    {
        string Title { get; set; }

        string Author { get; set; }

        string Publisher { get; set; }

        int PublishedYear { get; set; }
    }
}
