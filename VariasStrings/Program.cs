using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string first_name = "Francisco";
            string last_name = "Justo";
            int age = 23;
            string display_age = $"Current age: {age}";
            Console.WriteLine(first_name + " " + last_name);
            Console.WriteLine(display_age);
            Console.WriteLine(string.Format("{0} is {1}", first_name, age));
            Console.WriteLine(@"Hello! My name is {0}", first_name + ".");
        }
    }
}