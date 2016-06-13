using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.StudentsByAge
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

            students.Where(x => int.Parse(x[2]) >= 18 && int.Parse(x[2]) <= 24)
                .ToList()
                .ForEach(x => Console.WriteLine("{0} {1} {2}", x[0], x[1], x[2]));
        }
    }
}