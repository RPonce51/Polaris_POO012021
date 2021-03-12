using System;

namespace IntroGit
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 0;
            Console.WriteLine("Ingrese el valor de a:");
            a = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese el valor de b:");
            b = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine($"Sumando {a} + {b} resulta {Addnumbers(a, b)}");
        }

        public static int Addnumbers(int a, int b)
        {
            return a + b;
        }
    }
}
