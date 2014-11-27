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

            Course course1 = new Course("c001", "a21", "school", 19);

            DateTime date = new DateTime(2015, 01, 15, 18, 05, 0);
            DayOfWeek[] days = new DayOfWeek [] { DayOfWeek.Tuesday, DayOfWeek.Thursday }; 
            TimeSpan dur = new TimeSpan(1, 45, 0);
            course1.StartDateTime = date;
            course1.Days = days;

            Console.WriteLine("Course name: {0}", course1.Name);
            Console.WriteLine("Course level: {0}", course1.Level);
            Console.WriteLine("Course location: {0}", course1.Location);
            Console.WriteLine("Number of lessons: {0}", course1.NumberOfLessons);
            Console.WriteLine("Course start date and time: {0}", course1.StartDateTime);
            Console.Write("Course days: ");
            foreach (var day in days)
            {
                Console.Write(day + " ");
            }
        }
    }
}
