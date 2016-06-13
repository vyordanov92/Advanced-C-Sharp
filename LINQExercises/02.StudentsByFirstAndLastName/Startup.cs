using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.StudentsByFirstAndLastName
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
            students.Where(x => x[1].CompareTo(x[0]) == 1)
                    .ToList()
                    .ForEach(x => Console.WriteLine("{0} {1}", x[0], x[1]));
        }
    }
}