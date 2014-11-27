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
        public DateTime DateTime { get; set; }
        public TimeSpan Duration { get; set; }
        public bool Postponed { get; set; }

        //constructor 
        public Lesson(string courseName, int lessonNumber)
        {
            CourseName = courseName;
            LessonNumber = lessonNumber;
            Postponed = false;
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
