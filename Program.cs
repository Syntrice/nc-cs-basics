namespace CSBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            bool isLearningCS = true;
            string favouriteFilm = "Interstellar";
           
            favouriteFilm = "High School Musical";
            PrintGreeting("Susan");
            Console.WriteLine(SubtractNum(6, 3));

            Console.WriteLine(IsStringLonger("Hello", 6));

            int result = SubtractNum(5, 4);
            Console.WriteLine(result);

            Book csBasicsBook = new Book("CS Basics", 30);
            Console.WriteLine(csBasicsBook.CurrentPage);
            Console.WriteLine(csBasicsBook.Title);
            csBasicsBook.TurnPage();
            csBasicsBook.TurnPage();
            Console.WriteLine(csBasicsBook.CurrentPage);
            Console.WriteLine(csBasicsBook.Title);





        }

        private static void PrintGreeting(string name)
        {
            Console.WriteLine("Hello, " + name);
        }
        private static int SubtractNum(int x, int y)
        {
            return x - y;
        }

        private static bool IsStringLonger(string word, int number)
        {
            return word.Length > number;
        }
    }
}
