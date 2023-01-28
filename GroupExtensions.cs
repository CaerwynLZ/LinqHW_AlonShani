using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHW_AlonShani
{
    static class GroupExtensions
    {
        public static void DistinctOrderBy(this IEnumerable<string> list)
        {
            var orderedList = list.OrderBy((item) => item.Length).Distinct();

            foreach (var item in orderedList)
            {
                Console.WriteLine(item);
            }
        }

        public static void AverageWordLength(this string sentence)
        {
            var sentenceWords = sentence.Split(' ');
            var averageLength = sentenceWords.Average(word => word.Length);

            Console.WriteLine($"The average word length in this sentence is {averageLength}!");
        }

        public static void StringsContainingLetters(this IEnumerable<string> list, char firstFilter, char secondFilter)
        {
            var filteredList = list.Where(word => word[0] == firstFilter || word[0] == secondFilter);

            foreach (var item in filteredList)
            {
                Console.WriteLine(item);
            }
        }

        
        //I used the helpful diagram and code snippet from the presentation to figure this one out
        //The spacing within the method was to help me understand a bit better, hope I am not violating too many conventions
        public static void StudentGradeJoin(this IEnumerable<Student> students, IEnumerable<Grade> grades)
        {
            var jointList = students.Join
                (
                    grades,
                    (students) => students.Id,
                    (grades) => grades.Id,
                    (students, grades) => new { Name = students.Name, Grade = grades.FinalGrade }
                );
            foreach (var item in jointList)
            {
                Console.WriteLine($"{item.Name}, {item.Grade}");
            }
        }

        //Method Overload to be used on grade list rather than student list
        public static void StudentGradeJoin(this IEnumerable<Grade> grades, IEnumerable<Student> students)
        {
            var jointList = grades.Join
                (
                    students,
                    (grades) => grades.Id,
                    (students) => students.Id,
                    (grades, students) => new { Grade = grades.FinalGrade, Name = students.Name,  }
                );
            foreach (var item in jointList)
            {
                Console.WriteLine($"{item.Name}, {item.Grade}");
            }
        }

        public static void PrintCollection<T>(this IEnumerable<T> genericList)
        {
            foreach (var item in genericList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
