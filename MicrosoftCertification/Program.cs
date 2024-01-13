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
            //int currentAssignments = 5;

            //int sophia1 = 93;
            //int sophia2 = 87;
            //int sophia3 = 98;
            //int sophia4 = 95;
            //int sophia5 = 100;

            //int nicolas1 = 80;
            //int nicolas2 = 83;
            //int nicolas3 = 82;
            //int nicolas4 = 88;
            //int nicolas5 = 85;

            //int zahirah1 = 84;
            //int zahirah2 = 96;
            //int zahirah3 = 73;
            //int zahirah4 = 85;
            //int zahirah5 = 79;

            //int jeong1 = 90;
            //int jeong2 = 92;
            //int jeong3 = 98;
            //int jeong4 = 100;
            //int jeong5 = 97;

            //decimal sophiaGrade = ((decimal)sophia1 + (decimal)sophia2 + (decimal)sophia3 + (decimal)sophia4 + (decimal)sophia5) / (decimal)currentAssignments;

            //decimal nicolasGrade = ((decimal)nicolas1 + (decimal)nicolas2 + (decimal)nicolas3 + (decimal)nicolas4 + (decimal)nicolas5) / (decimal)currentAssignments;

            //decimal zahirahGrade = ((decimal)zahirah1 + (decimal)zahirah2 + (decimal)zahirah3 + (decimal)zahirah4 + (decimal)zahirah5) / (decimal)currentAssignments;

            //decimal jeongGrade = ((decimal)jeong1 + (decimal)jeong2 + (decimal)jeong3 + (decimal)jeong4 + (decimal)jeong5) / (decimal)currentAssignments;

            //Console.WriteLine("Student\t\tGrade");
            //Console.WriteLine($"Sophia\t\t{sophiaGrade} A");
            //Console.WriteLine($"Nicolas\t\t{nicolasGrade} B");
            //Console.WriteLine($"Zahirah\t\t{zahirahGrade} B");
            //Console.WriteLine($"Jeong\t\t{jeongGrade} A");

            //GPA Calculator application
            string studentName = "Sophia Johnson";

            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";

            int course1Credit = 3;
            int course2Credit = 3;
            int course3Credit = 4;
            int course4Credit = 4;
            int course5Credit = 3;

            int grade1 = 4;
            int grade2 = 3;
            int grade3 = 3;
            int grade4 = 3;
            int grade5 = 4;

            int sumCourseCredit = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
            int productGradeCourse1 = course1Credit * grade1;
            int productGradeCourse2 = course2Credit * grade2;
            int productGradeCourse3 = course3Credit * grade3;
            int productGradeCourse4 = course4Credit * grade4;
            int productGradeCourse5 = course5Credit * grade5;

            decimal generalPointAverage =
                (
                (decimal)productGradeCourse1 +
                (decimal)productGradeCourse2 +
                (decimal)productGradeCourse3 +
                (decimal)productGradeCourse4 +
                (decimal)productGradeCourse5
                ) /(decimal)sumCourseCredit;

            string formattedGpa = generalPointAverage.ToString("F2");

            Console.WriteLine($"Student: {studentName} \n");
            Console.WriteLine("Course\t\tGrade\t\tCredit Hours");
            Console.WriteLine($"{course1Name}\t\t{grade1}\t\t{course1Credit}");
            Console.WriteLine($"{course2Name}\t\t{grade2}\t\t{course2Credit}");
            Console.WriteLine($"{course3Name}\t\t{grade3}\t\t{course3Credit}");
            Console.WriteLine($"{course4Name}\t{grade4}\t\t{course4Credit}");
            Console.WriteLine($"{course5Name}\t\t{grade5}\t\t{course5Credit}");

            Console.WriteLine($"\nFinal GPA:\t\t{formattedGpa}");

            Console.ReadLine();

        }
    }
}
