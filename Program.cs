using System;
using System.Linq;
using IntermediateCSharp.LinqBasics;

namespace IntermediateCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var linq = new LinqExamples();
            var birthday = new DateTime(1993, 5, 5);
            var students = linq.GetStudentBornAfterDate(birthday);

            foreach(var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine($"TOTAL NUMBER: {students.Count()}");
        }
    }
}
