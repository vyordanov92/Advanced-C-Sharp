using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterStudentsByEmail
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

            students.Where(x => x[2].Contains("@gmail"))
                .ToList()
                .ForEach(x => Console.WriteLine("{0} {1}", x[0], x[1]));
        }
    }
}