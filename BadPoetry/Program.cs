using System.Diagnostics.CodeAnalysis;
using CLAP;

namespace BadPoetry
{
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    internal class Program
    {
        private static void Main(string[] args)
        {
            Parser.Run(args, new ApplicationActions());
        }
    }
}
