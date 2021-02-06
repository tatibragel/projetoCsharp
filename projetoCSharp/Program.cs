using System;
using System.Globalization;

namespace calculaBaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;


            Console.WriteLine("****Calculando baskara:****");
            Console.WriteLine("****Defina o valor de a:***");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("****Defina o valor de b:***");
            b = double.Parse(Console.ReadLine()); 
            Console.WriteLine("****Defina o valor de c:***");
            c = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Os valores definidos foram");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);


            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("delta = " + delta);
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);



        }
    }
}
