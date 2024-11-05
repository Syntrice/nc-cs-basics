using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasics
{
    internal class Book
    {
        public string Title { get; set; }
        public int TotalPages { get; set; }

        public int CurrentPage { get; set; }

        public Book(string title, int pages)
        {
            Title = title;
            TotalPages = pages;
            CurrentPage = 1;
        }

        public void TurnPage()
        {
            if (CurrentPage < TotalPages)
            {
                CurrentPage++;
                Console.WriteLine("Current Page: " + CurrentPage);
            }
            else
            {
                Console.WriteLine("Page does not exist");
            }
        }
    }
}
