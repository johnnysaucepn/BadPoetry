using CLAP;
using System;

namespace BadPoetry
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Run(args, new ApplicationActions());
            Console.ReadKey();
        }
    }
}
