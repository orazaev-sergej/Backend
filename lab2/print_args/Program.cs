using System;

namespace print_args
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No parameters were specified!");
                Environment.Exit(1);
            }

            Console.WriteLine("Number of arguments: " + args.Length.ToString());

            Console.Write("Arguments:");

            for (int i = 0; i < args.Length; i++)
            {
                Console.Write(" " + args[i]);
            }

        }
    }
}
