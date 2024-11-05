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

          
        }

        private static void PrintGreeting(string name)
        {
            Console.WriteLine("Hello, " + name);
        }
        private static int SubtractNum(int x, int y)
        {
            return x - y;
        }
    }
}
