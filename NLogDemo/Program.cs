using System;

namespace NLogDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumber obj = new AddNumber();
            obj.Sum(2,0);
            Console.WriteLine("This is a Logger Demo");
            Console.ReadLine();
        }
    }
}
