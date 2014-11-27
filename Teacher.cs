using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerClassTest
{
    class Teacher
    {
        public string Name { get; set; }
        public bool FullTime { get; set; }
        public int MinHours { get; set; }
        public int MaxHours { get; set; }
        public bool[,] Availablility { get; set; }
        public int CurrentHours {get; set;}
        public Course[] Courses { get; set; }

        //constructor
        public Teacher(string name, bool fullTime, int minHours, int maxHours, bool [,] availability, int currentHours)
        {
            FullTime = fullTime;
            MinHours = minHours;
            MaxHours = maxHours;
            Availablility = availability;
            CurrentHours = currentHours;          
        }

        public static void DisplayAllTeacherHours()
        //displays list of teachers and their weekly hours for the current week
        {
            //to do
        }

        public void RenderWeeklySchedule(DateTime weekBeginDate)
        {
            //to do
        }

        public void DisplayCourses()
        {
            //to do
        }

        public void AddCourse()
        {
            //to do
        }

        public void RemoveCourse()
        {
            //to do
        }

        public void Sick(DateTime date)
        {
            //to do
        }

        public void Holiday(DateTime startDate, DateTime endDate)
        {
            //to do
        }

        public void Substitute(Lesson lesson)
        //adds specific lesson to teacher schedule in the case of illness or holiday of another teacher
        {
            //to do
        }
    }
}
