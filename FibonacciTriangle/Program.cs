using System;

namespace FibonacciTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int a = 0, b = 1, i, c, n, j;

            //print show message
            Console.Write("Please Enter the limit: ");

            //get user input
            n = int.Parse(Console.ReadLine());

            //create a for loop to continue program
            for (i = 1; i <= n; i++)
            {
                a = 0;
                b = 1;
                Console.Write(b + "\t");

                for(j = 1; j < i; j++)
                {
                    c = a + b;
                    Console.Write(c + "\t");

                    a = b;
                    b = c;
                }
                Console.Write("\n");
            }
        }
    }
}
