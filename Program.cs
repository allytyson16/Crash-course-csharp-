using System;

namespace csharp_outube_crash_course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hey!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("I love candies!");
            Console.WriteLine("I am a Christian!!");
            Console.WriteLine("And I am not afraid of the Gospel!");
            Console.Write("I am a gamer");
            Console.Beep();     //for a beep after compiling

            //the use of escape characters.
            Console.WriteLine("Hey!");
            Console.WriteLine("\t You ");
            Console.WriteLine(" \t\tare");
            Console.WriteLine(" \t\t\ta");
            Console.WriteLine(" \t\t\t\twitch");

            //data types
            int age = 21;
            double height = 299.2;
            bool alive = true;
            char symbol = '@';
            string name = "Mina";

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are " + age + "years");
            Console.WriteLine("Your height is " + height);
            Console.WriteLine("You are alive!" + alive);
            Console.WriteLine("Your symbol is " + symbol);
            Console.WriteLine("Your username is " + symbol + name);

            //const
            const double PI = 3.142;
            Console.WriteLine(PI);


        }
    }
}
