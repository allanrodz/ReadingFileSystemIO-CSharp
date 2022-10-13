using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {

            int max_elements = 5, index = 0, grade_point;
            int[] grade_points = new int[max_elements];
            char[] letter_grades = new char[max_elements];
            char letter_grade;
            string path = @"S:\Allan\projects\c#\ConsoleApp12\ConsoleApp12\fileTest.txt";


            StreamReader reader = new StreamReader(path);

            while (reader.Peek() > -1 && index < max_elements)
            {
                string line = reader.ReadLine();
                string[] data = line.Split(' ');
                letter_grade = char.Parse(data[0]);
                grade_point = int.Parse(data[1]);
                if (letter_grade == 'A' || letter_grade == 'B' || letter_grade == 'C' || letter_grade == 'D' || letter_grade == 'F')
                {
                    letter_grades[index] = letter_grade;
                    grade_points[index] = grade_point;
                }
                else
                    Console.WriteLine($"Invalid letter grade {letter_grade}");
                index++;
            }

            string[] lines = File.ReadAllLines(path);
            if (lines.Length > 5 && index == 5)
            {
                Console.WriteLine("File is too big for the array");
            }
            else
            {
                Console.WriteLine("Student grade values loaded successfully");
            }

            for (int i = 0; i < max_elements; i++)
            {
                Console.WriteLine($"{letter_grades[i]}    {grade_points[i]}");
            }

            Console.ReadLine();
        }
    }
}
