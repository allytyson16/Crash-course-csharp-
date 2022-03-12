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


            ////the use of escape characters.
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

            //type casting
            //double to int
            double a = 34.34;
            int b = Convert.ToInt32(a);
            Console.WriteLine(b);
            //to get data type
            Console.WriteLine(b.GetType());

            //int to double
            int w = 344;
            double y = Convert.ToDouble(w) + 0.3;
            Console.WriteLine(y);
            //to get data type
            Console.WriteLine(y.GetType());

            //int to string
            int c = 24;
            string word = Convert.ToString(c);
            Console.WriteLine(word);
            //to get data type
            Console.WriteLine(word.GetType());

            //string to char
            string alph = "&";
            char t = Convert.ToChar(alph);
            //for data type
            Console.WriteLine(t.GetType());

            //string to boolean
            string state = "true";
            bool ans = Convert.ToBoolean(state);
            Console.WriteLine(ans);
            //for data type
            Console.WriteLine(ans.GetType());


            //user input
            Console.Write("Please enter your name - ");
            string name1 = Console.ReadLine();

            Console.WriteLine("Hello " + name1 + "!");

            Console.Write("Please enter your age - ");
            int age1 = Convert.ToInt32(Console.ReadLine()); ///OR
            Console.WriteLine("You are " + age + " years old.");
            Console.Write("Please enter your age for the second way - ");
            int age2 = int.Parse(Console.ReadLine());
            Console.WriteLine("You are " + age2 + " years old as well.");


            //arithmetic operators

        }
    }
}
