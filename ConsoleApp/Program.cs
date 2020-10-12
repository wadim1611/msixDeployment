using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var argsString = string.Join(";", args);
            Console.WriteLine($"App was launched with args: {argsString}");
            Console.WriteLine("Press a key to continue: ");
            Console.ReadLine();
        }
    }
}
