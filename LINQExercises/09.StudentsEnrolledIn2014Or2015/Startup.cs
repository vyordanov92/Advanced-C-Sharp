using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.StudentsEnrolledIn2014Or2015
{
    class Startup
    {
        static void Main()
        {
            var students = new List<string[]>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                var studentDetails = input.Split();
                students.Add(studentDetails);
                input = Console.ReadLine();
            }

            students
                .Where(x => x[0].EndsWith("14") || x[0].EndsWith("15"))
                .ToList()
                .ForEach(x => Console.WriteLine(string.Join(" ", x.Skip(1))));
        }
    }
}