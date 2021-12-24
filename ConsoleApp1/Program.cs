using System;

namespace ConsoleApp1
{
    class Program
    {
        static void MyMethod(int bilangan)
        {
            int counter1 = 2;
            int counter2 = 3;

            for (int i = 1; i <= bilangan; i++)
            {
                for (int j = 1; j <= bilangan + 3; j++)
                {
                    Console.Write(j);
                    if (j == i)
                    {
                        Console.Write("**");
                        j+=2;
                    }
                }
                Console.WriteLine(" ");
            }

        }

        static void Main(string[] args)
        {
            MyMethod(6);

        }
    }
}
