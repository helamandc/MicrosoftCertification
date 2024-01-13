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
            //int fahrenheit = 94;
            //decimal celsius = ((decimal)fahrenheit - 32m) * (5m / 9m);
            //Console.WriteLine($"The temperature is {celsius} Celsius.");

            //Student Grading Application
            // initialize variables - graded assignments 
            int currentAssignments = 5;

            int sophia1 = 93;
            int sophia2 = 87;
            int sophia3 = 98;
            int sophia4 = 95;
            int sophia5 = 100;

            int nicolas1 = 80;
            int nicolas2 = 83;
            int nicolas3 = 82;
            int nicolas4 = 88;
            int nicolas5 = 85;

            int zahirah1 = 84;
            int zahirah2 = 96;
            int zahirah3 = 73;
            int zahirah4 = 85;
            int zahirah5 = 79;

            int jeong1 = 90;
            int jeong2 = 92;
            int jeong3 = 98;
            int jeong4 = 100;
            int jeong5 = 97;

            decimal sophiaGrade = ((decimal)sophia1 + (decimal)sophia2 + (decimal)sophia3 + (decimal)sophia4 + (decimal)sophia5) / (decimal)currentAssignments;

            decimal nicolasGrade = ((decimal)nicolas1 + (decimal)nicolas2 + (decimal)nicolas3 + (decimal)nicolas4 + (decimal)nicolas5) / (decimal)currentAssignments;

            decimal zahirahGrade = ((decimal)zahirah1 + (decimal)zahirah2 + (decimal)zahirah3 + (decimal)zahirah4 + (decimal)zahirah5) / (decimal)currentAssignments;

            decimal jeongGrade = ((decimal)jeong1 + (decimal)jeong2 + (decimal)jeong3 + (decimal)jeong4 + (decimal)jeong5) / (decimal)currentAssignments;

            Console.WriteLine("Student\t\tGrade");
            Console.WriteLine($"Sophia\t\t{sophiaGrade} A");
            Console.WriteLine($"Nicolas\t\t{nicolasGrade} B");
            Console.WriteLine($"Zahirah\t\t{zahirahGrade} B");
            Console.WriteLine($"Jeong\t\t{jeongGrade} A");

            Console.ReadLine();

        }
    }
}
