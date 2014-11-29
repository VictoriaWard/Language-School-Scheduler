using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerClassTest
{
    class Lesson
    {
        public string CourseName { get; set; }
        public int LessonNumber { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Duration { get; set; }
        public bool Postponed { get; set; }

        //constructor 
        public Lesson(string courseName, int lessonNumber, DateTime date, TimeSpan duration)
        {
            CourseName = courseName;
            LessonNumber = lessonNumber;
            Postponed = false;
            Date = date;
            Duration = duration;
        }

        public void Cancel()
        {
            //to do
        }

        public void AssignCoverTeacher()
        {
            //to do
        }
    }
}
