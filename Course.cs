using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerClassTest
{
    class Course
    {
        public string Name { get; set; }
        public string Level { get; set; }
        public string Location { get; set; }
        public int NumberOfLessons { get; set; }
        public Teacher Teacher { get; set; }
        public bool Active { get; set; }
        public DateTime StartDateTime { get; set; }
        public DayOfWeek[] Days { get; set; }
        public Lesson[] Lessons { get; set; }
        public static DateTime[] SchoolHolidays { get; set; }

        //constructor
        public Course(string name, string level, string location, int numberOfLessons) 
        {
            Name = name;
            Level = level;
            Location = location;
            NumberOfLessons = numberOfLessons;
            Active = true;
        }

        public void AllocateTimesDates(DateTime start, DayOfWeek[] days)
        {
            this.StartDateTime = start;
            this.Days = days;
        }

        public void CreateLessons()
        //instantiates lesson objects and adds to course Lessons array
        {
            //to do
        } 

        public static void DisplayAll()
        //displays all courses and course info
        {
            //to do
        }

        public void AssignTeacher(Teacher t)
        {
            this.Teacher = t;
        }

        public void RemoveTeacher()
        {
            //to do
        }

        public void Delete()
        //deletes course instance and removes from teacher schedules
        {
            //to do
        }

        public void Hold()
        //marks course as inactive and removes from teacher schedules
        {
            //to do
            this.Active = false;
        }

        public void PostponeClass(DateTime classDate)
        //cancels one class and adds make up class to end of course
        {
            //to do
        }
    }
}
