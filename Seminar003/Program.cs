using System;


namespace Новая_папка
{
    class Program
    {
        static int DO(double index)
        {
            return Math.Pow(index, 3);
        }
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Sqrt(number));
            Console.WriteLine(Math.Round(Math.PI,3));
            Console.WriteLine(Math.Pow(number, 4));
            int a = number > 1 ? DO(number) : DO(123);

        }
    };


}