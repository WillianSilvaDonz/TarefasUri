using System;

namespace AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            valor = Convert.ToDouble(Console.ReadLine().Replace(".",","));
            double result = Math.PI * (Math.Pow(2, valor));
            Console.WriteLine($"A={string.Format("{0:0.0000}", result)}");
        }
    }
}
