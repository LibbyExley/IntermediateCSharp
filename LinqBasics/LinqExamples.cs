using System;
using System.Collections.Generic;
using System.Linq;

namespace IntermediateCSharp.LinqBasics
{
    public class LinqExamples
    {
        private readonly List<int> _listOfInts;
        private readonly List<Student> _listOfStudents;

        public LinqExamples()
        {
            var listBuilder = new ListBuilder();
            _listOfInts = listBuilder.CreateList(1000);
            _listOfStudents = listBuilder.CreateListOfStudents(1000);
        }
        public IEnumerable<int> GetEvenNumbers()
        {
            return _listOfInts.Where(number => number % 2 == 0);
        }

        public IEnumerable<int> GetOddNumbers()
        {
            return _listOfInts.Where(number => number % 2 != 0);
        }

        public IEnumerable<string> GetStudentBornAfterDate(DateTime date)
        {
            return _listOfStudents.Where(s => s.DateOfBirth > date)
            .Select(s => s.Name)
            .OrderBy(s => s);
        }
    }
}