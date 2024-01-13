using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftCertification
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World!");

            //Temperature Converter
            int fahrenheit = 94;
            decimal celsius = ((decimal)fahrenheit - 32m) * (5m / 9m);
            Console.WriteLine($"The temperature is {celsius} Celsius.");

            Console.ReadLine();

        }
    }
}
