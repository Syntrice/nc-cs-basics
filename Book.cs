using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasics
{
    internal class Book
    {
        public string Title { get; }
        public int TotalPages { get; }

        private int currentPage;
        public int CurrentPage { get => currentPage; }

        public Book(string title, int pages)
        {
            Title = title;
            TotalPages = pages;
            currentPage = 1;
        }

        public void TurnPage()
        {
            if (CurrentPage < TotalPages)
            {
                currentPage++;
                Console.WriteLine("Current Page: " + CurrentPage);
            }
            else
            {
                Console.WriteLine("Page does not exist");
            }
        }
    }
}
