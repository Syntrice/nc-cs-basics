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

            Console.WriteLine(isStringLonger("Hello", 6));

            int result = SubtractNum(5, 4);
            Console.WriteLine(result);


        }

        private static void PrintGreeting(string name)
        {
            Console.WriteLine("Hello, " + name);
        }
        private static int SubtractNum(int x, int y)
        {
            return x - y;
        }

        private static bool isStringLonger(string word, int number)
        {
            return word.Length > number;
        }
    }
}
