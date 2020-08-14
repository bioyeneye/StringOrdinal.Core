using System;
using System.Collections.Generic;
using System.Linq;
using StringOrdinal.Core;

namespace StringOrdinal.SampleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1.AddOrdinalToNumber());
            Console.WriteLine("34".ConvertToSuperScript());
        }
    }
}