using System;

namespace ExtremelyBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada, entrada2;
            entrada = Convert.ToInt32(Console.ReadLine());
            entrada2 = Convert.ToInt32(Console.ReadLine());
            int result = entrada + entrada2;
            Console.WriteLine("X = "+ result);
        }
    }
}
