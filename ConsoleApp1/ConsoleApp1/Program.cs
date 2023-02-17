using System;

namespace ConsoleApp
{
    using System;

    namespace task1
    {
        public delegate int MyDelegat(int a, int b);

        class Program
        {
            static void Main()
            {
                Console.WriteLine("Виберiть дiю +,-,*,/");
                string a = Console.ReadLine();
                Console.WriteLine("а = ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("b = ");
                int y = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case "+":
                        MyDelegat myDelegat = (c, b) => { return c + b; };
                        int del = myDelegat(x, y);
                        Console.WriteLine("a+b = ", del);
                        break;
                    case "-":
                        MyDelegat myDelegat1 = (c, b) => { return c - b; };
                        int del1 = myDelegat1(x, y);
                        Console.WriteLine("a-b = ", del1);
                        break;
                    case "*":
                        MyDelegat myDelegat2 = (c, b) => { return c * b; };
                        int del2 = myDelegat2(x, y);
                        Console.WriteLine("a*b = ", del2);
                        break;
                    case "/":
                        MyDelegat myDelegat3 = (c, b) => { return c / b; };
                        int del3 = myDelegat3(x, y);
                        Console.WriteLine("a/b = ", del3);
                        break;
                    default:
                        Console.WriteLine("Дана операцiя недоступна...");
                        break;
                }

                Console.ReadKey();

            }
        }
    }
}
}