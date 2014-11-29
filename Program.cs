using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerClassTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Course course1 = new Course("course1", "b11", "school", 10, new DateTime(2015, 01, 12, 18, 0, 0), new DayOfWeek[] { DayOfWeek.Monday, DayOfWeek.Wednesday }, new TimeSpan(1, 30, 0));


            Console.WriteLine("Course name: {0}", course1.Name);
            Console.WriteLine("Course level: {0}", course1.Level);
            Console.WriteLine("Course location: {0}", course1.Location);
            Console.WriteLine("Number of lessons: {0}", course1.NumberOfLessons);
            Console.WriteLine("Course start date and time: {0}", course1.StartDateTime);
            Console.Write("Course days: ");
            foreach (var day in course1.Days)
            {
                Console.Write(day + " ");
            }
            Console.WriteLine();
            course1.CreateLessonsFullCourse();
            Console.Write("Lesson dates: ");
            foreach (var date in course1.LessonDates)
            {
                Console.WriteLine(date + " ");
            }
            
            Console.WriteLine();
            course1.PostponeLesson((Lesson)course1.Lessons[5]);
            Console.Write("Lesson dates: ");
            foreach (var date in course1.LessonDates)
            {
                Console.WriteLine(date + " ");
            }

            Console.WriteLine();
            course1.Extend(5);
            Console.Write("Lesson dates: ");
            foreach (var date in course1.LessonDates)
            {
                Console.WriteLine(date + " ");
            }
            
        }
    }
}
