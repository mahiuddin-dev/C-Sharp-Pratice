
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

            ArrayMethod();


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
    }
}

