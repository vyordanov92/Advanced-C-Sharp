using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.StudentsByGroup
{
    public class StudentsByGroup
    {
        static void Main()
        {
            var students = new List<string>();
            var input = Console.ReadLine();

            while (input != "END")
            {
                students.Add(input);
                input = Console.ReadLine();
            }

            var result = students
                .Where(x => x.Contains("2"))
                .Select(x => x.Remove(x.Length - 2))
                .OrderBy(x => x.Split()[0])
                .ToList();

            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}