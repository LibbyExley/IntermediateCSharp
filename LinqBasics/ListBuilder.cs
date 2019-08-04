using System;
using System.Collections.Generic;

namespace IntermediateCSharp.LinqBasics
{
    public class ListBuilder
    {
        public List<int> CreateList(int length)
        {
            var listOfNumbers = new List<int>();

            for(var i = 0; i <= length; i++)
            {
                listOfNumbers.Add(i);
            }

            return listOfNumbers;
        }

        public List<Student> CreateListOfStudents(int length)
        {
            var ListOfStudents = new List<Student>();

            for(var i = 1; i <= length; i++)
            {
                var student = new Student
                {
                    StudentId = i,
                    Name = $"Student {i}",
                    DateOfBirth = GetRandomDateOfBirth()
                };
                ListOfStudents.Add(student);
            }
            return ListOfStudents;
        }

        private DateTime GetRandomDateOfBirth()
        {
            var random = new Random();

            var startDate = new DateTime(1980, 1, 1);
            int range = (DateTime.Today - startDate).Days;
            return startDate.AddDays(random.Next(range));
        }
    }
    
}