
using System;

namespace Practice
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Hello");


            string name = "Mr Jhon";
            char a = 'a';
            int number = 10;
            double marks = 7.5;

            Console.WriteLine(number);
            Console.Write(marks);

            const int count = 10;
            Console.WriteLine(count);


            Car Ford = new Car("Mustang", "Red", 1969);
            Car Ford2 = new Car("Mustang", "Black", 2005);
            Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
            Console.WriteLine(Ford2.color + " " + Ford2.year + " " + Ford2.model);


        }
        public static void User()
        {
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();

            Console.WriteLine(username);
        }

        public static void ArrayMethod()
        {
            int[] are = { 1, 2, 3, };

            for(int i = 0; i < are.Length; i++)
            {
                Console.WriteLine(are[i]);
            }

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach(string i in cars)
            {
                Console.WriteLine(i);
            }

            int[,] numbers = { { 1, 2, 3, }, { 4, 5, 6, } };
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }

            for(int i=0; i < numbers.GetLength(0); i++)
            {
                for(int j=0; j<numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }

        }

        // Method Overloading
        static int sum(int x, int y)
        {
            return x + y;
        }
        static double sum(double x, double y)
        {
            return x + y;
        }

    }

}

