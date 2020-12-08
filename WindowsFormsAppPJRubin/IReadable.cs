using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsAppPJRubin
{
    public interface IReadable
    {
        string Title { get; set; }

        Author author { get; set; }

        string Publisher { get; set; }

        int PublishedYear { get; set; }
    }
}
