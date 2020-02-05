using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n==1)

            Console.WriteLine("Osaamisesi asteikolla 1-10?");
            int x =int.Parse(Console.ReadLine());


            if (x > 0 && x < 4)
            {
                Console.WriteLine("Olet aika nuubi");
            }

            else if (x > 4 && x<7 || x==4)
            {
                Console.WriteLine("Olet perse");
            }

            else
            {
                Console.WriteLine("OOt iha himo hyvä!!!");
            }
 
        }
    }
}
