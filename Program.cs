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
            int friends = 8;
            friends = friends + 4; //increment by 4
            friends += 4; //increment by 4
            friends++; //for increment by 1
            Console.WriteLine("You have " + friends + " number of friends by increment of 9");

            friends = friends - 2;  //decrement by 3, from current value of friends-17
            friends -= 2;   //decrement by 3
            friends--;  //decrement by 1
            Console.WriteLine("You have " + friends + " number of friends by decrement 5");


            friends = friends * 2; //from current value of friends-12
            friends *= 2; //multiplying by 2
            Console.WriteLine("You have " + friends + " number of friends by multiplying by 2");

            friends = friends / 2; //from current value of friends we divide by 2
            friends /= 2;  //dividing by 2
            Console.WriteLine("You have " + friends + " number of friends by dividing by 4 ");

            int remainder = friends % 5; //the remainder of the current number of friends - 144
            Console.WriteLine("You have " + remainder + " number of friends remaining after using the modulo of 5 ");


            //math class
            double num = 4;
            double exp = Math.Pow(num, 2); //use of exponent
            Console.WriteLine("{0} raised to the power 2 is {1}", num, exp);

            double squareR = Math.Sqrt(num); //use of square root
            Console.WriteLine("{0} sqaured is {1}", num, squareR);

            double abs = Math.Abs(num); //use of absolute value
            Console.WriteLine("The absolute value of {0} is {1}", num, abs);

            double num1 = 3.142;
            double round = Math.Round(num1); //rounding
            Console.WriteLine("The rounded value of {0} is {1}", num, round);
            double roundUp = Math.Ceiling(num1); //rounding up
            Console.WriteLine("The rounded up value of {0} is {1}", num, roundUp);
            double roundDown = Math.Floor(num1); //rounding down
            Console.WriteLine("The rounded down value of {0} is {1}", num, roundDown);

            double maximum = Math.Max(num1, num); //using max
            Console.WriteLine("The maximum value between {0} and {1} is {2}", num1, num, maximum);
            double minimum = Math.Min(num1, num); //using min
            Console.WriteLine("The minimum value between {0} and {1} is {2}", num1, num, minimum);


            //generating random numbers
            Random random = new Random();
            int randomNum = random.Next(1, 7); //die is thrown with the expectation of getting 2 outcomes.
            Console.WriteLine("The random number when a die is tossed is " + randomNum); //possible outcomes are {1,2,3,4,5,6}
            //for adjustments
            int randomNum1 = random.Next(1, 7) + 50;
            Console.WriteLine("The random number when a die is tossed and added to 50 is " + randomNum1); //possible outcomes are {51,52,53,54,55,56}
            //double random numbers
            double randomDouble = random.NextDouble(); //random numbers are between 0 and 1
            double randomDouble1 = random.NextDouble();
            double randomDouble2 = random.NextDouble();
            double randomDouble3 = random.NextDouble();
            Console.WriteLine("The random double is " + randomDouble);
            Console.WriteLine("The first random double is " + randomDouble1);
            Console.WriteLine("The second random double is " + randomDouble2);
            Console.WriteLine("The third random double is " + randomDouble3);



            //calculator program
            //finding the hypothenus //C=sqrt(A+B)
            Console.Write("Enter side A: ");
            double A = double.Parse(Console.ReadLine());

            Console.Write("Enter side B: ");
            double B = double.Parse(Console.ReadLine());

            double C = Math.Sqrt((A * A) + (B * B));
            Console.WriteLine("The hypothenus of a triangle with sides {0} and {1} is {2}", A, B, C);


            //using string methods
            string fullName = "Ally Tyson 16";
            fullName = fullName.ToLower(); //conversion to lower case
            Console.WriteLine("Your full name in lower case is " + fullName);
            fullName = fullName.ToUpper();//conversion to upper case
            Console.WriteLine("Your full name in upper case is " + fullName);


            //replacing / with - using string methods
            string phoneNumber = "27/502/5158";
            phoneNumber = phoneNumber.Replace("/", "-");
            Console.WriteLine(phoneNumber);

            //inserting 
            string userName = fullName.Insert(0, "MISS ");
            Console.WriteLine(userName);

            //substring
            string firstName = fullName.Substring(0, 4);
            Console.WriteLine("Your first name is " + firstName);
            string lastName = fullName.Substring(5, 8);
            Console.WriteLine("Your last name is " + lastName);


            //if statements
            Console.WriteLine("Enter your age : ");
            int age3 = int.Parse(Console.ReadLine());
            if (age3 >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else if (age < 0)
            {
                Console.WriteLine("You haven't been born yet");
            }
            else
            {
                Console.WriteLine("Sorry, you must be 18 and above to vote.");
            }

            Console.WriteLine("Enter your name : ");
            string name2 = Console.ReadLine();
            if (name == "")
            {
                Console.WriteLine("You did not enter anything!!!");
            }
            else
            {
                Console.WriteLine("Hello {0}, Welcome to my humble code.", name2);
            }



            //switches --- efficient way for many if else statements
            Console.WriteLine("What day is your birthday? : ");
            string day = Console.ReadLine();

            if (day == "Monday")
            {
                Console.WriteLine("It is Monday.");
            }
            else if (day == "Tuesday")
            {
                Console.WriteLine("It is Tuesday.");
            }
            else if (day == "Wednesday")
            {
                Console.WriteLine("It is Wednesday.");
            }
            else if (day == "Thursday")
            {
                Console.WriteLine("It is Thursday.");
            }
            else if (day == "Friday")
            {
                Console.WriteLine("It is Friday.");
            }
            else if (day == "Saturday")
            {
                Console.WriteLine("It is Saturday.");
            }
            else if (day == "Sunday")
            {
                Console.WriteLine("It is Sunday.");
            }
            else
            {
                Console.WriteLine(day + " is not a day.");
            }
            Console.WriteLine("What day is your birthday? : ");
            string day1 = Console.ReadLine();
            //to switch
            switch (day1)
            {
                case "Monday":
                    Console.WriteLine("It is Monday.");
                    break;

                case "Tuesday":
                    Console.WriteLine("It is Tuesday.");
                    break;

                case "Wednesday":
                    Console.WriteLine("It is Wednesday.");
                    break;

                case "Thursday":
                    Console.WriteLine("It is Thursday.");
                    break;

                case "Friday":
                    Console.WriteLine("It is Friday.");
                    break;

                case "Saturday":
                    Console.WriteLine("It is Saturday.");
                    break;

                case "Sunday":
                    Console.WriteLine("It is Sunday.");
                    break;

                default:
                    Console.WriteLine(day1 + " is not a day.");
                    break;
            }


            //logical operators
            //&& and || operators
            Console.WriteLine("Enter temperature of outside: ");
            double temp = double.Parse(Console.ReadLine());

            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("It is warm outside!");
            }
            else if (temp <= -50 || temp >= 50)
            {
                Console.WriteLine("DO NOT GO OUTSIDE!");
            }
            else
            {
                Console.WriteLine("Arhn eii.");
            }


            //while loop

            string name3 = "" ;

            while (name3 == "")
            {
                Console.WriteLine("Enter your name: ");
                name3 = Console.ReadLine();
            }
            Console.WriteLine("Hello, " + name3);


        }
    }
}
