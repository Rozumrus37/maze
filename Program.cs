
using System;

namespace ConsoleApp30
{
    class Program
    {
        static int x = 0, y = 0;
        static Random ran = new Random();
        static void Main(string[] args)
        {
            int n = 5;
            char [,] c = generate(n);
            print(c, n);
            init();
            update(c, n);

        }
        static char[,] generate(int n)
        {
            char[,] a = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = ran.Next(2) == 0 ? '#' : '.';
                }
            }
            a[0, 0] = '@';
            a[n - 1, n - 1] = 'F';
            return a;

        }

        static void init()
        {
            
            Console.WriteLine("up -> u" + " down -> d" + " right -> r" + " left -> l");
            Console.WriteLine("Let's go. Print:");
        }

        static void print(char [,] c, int n)
        {
            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(c[i, j]);
                }
                Console.WriteLine("\n");
            }
        }
        static char [,] update(char [,] a, int n)
        {
           
            while(true)
            {
                char c = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
                switch (c)
                {
                    case 'u':
                        if (y != 0 && a[y-1, x] == '.')
                        {
                            print(a, n);
                            a[y, x] = '.';
                            y -= 1;
                            a[y, x] = '@';
                        }
                        print(a, n);
                        break;
                    case 'd':
                        if (y != n - 1 && a[y+1, x] == '.')
                        {
                            
                            a[y, x] = '.';
                            y += 1;
                            a[y, x] = '@';
                        }
                        print(a, n);
                        break;
                    case 'r':
                        if (x != n - 1 && a[y, x+1] == '.')
                        {
                            a[y, x] = '.';
                            x += 1;
                            a[y, x] = '@';
                        }
                        print(a, n);
                        break;
                    case 'l':
                        if (x != 0 && a[y, x-1] == '.')
                        {
                            a[y, x] = '.';
                            x -= 1;
                            a[y, x] = '@';
                        }
                        print(a, n);
                        break;
                }

                   
                             
            }
        }
    }
}
