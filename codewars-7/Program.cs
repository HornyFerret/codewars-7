using System;

namespace codewars_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "George";
            string w = Greet(name);
            Console.WriteLine(w);
        }
        public static string Greet(string name)
        {
            string soon = $"Hello, {name} how are you doing today?";
            return soon;
        }
    }
}
