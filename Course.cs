using System;
using System.Collections;
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
        public TimeSpan Duration { get; set; }
        public ArrayList LessonDates { get; set; }
        public ArrayList Lessons { get; set; }
        public static ArrayList SchoolHolidays { get; set; } //to do in createLessons

        //constructor
        public Course(string name, string level, string location, int numberOfLessons, DateTime start, DayOfWeek[] days, TimeSpan duration) 
        {
            Name = name;
            Level = level;
            Location = location;
            NumberOfLessons = numberOfLessons;
            Active = true;
            StartDateTime = start;
            Days = days;
            Duration = duration;
            LessonDates = new ArrayList();
            Lessons = new ArrayList();

        }

        public void CreateLessonsFullCourse()
        //generates lesson dates and lessons for full course from course start date and adds to course LessonDates arraylist
        {
            LessonDates.Add(this.StartDateTime); //add start date as first lesson date to lessonDates arraylist
            this.CreateLessonDatesHelper(this.StartDateTime, this.StartDateTime.DayOfWeek, this.NumberOfLessons - 1);
            this.CreateLessonsHelper(1); //calls helper method to insantiate all lessons from lesson 1
        }

        public void CreateLessonDatesHelper(DateTime lessonDateToAdd, DayOfWeek lessonDay, int lessons)
        //determines lesson dates of a given number, given specified week dates and previous lesson date
        {
            for (int i = 0; i < lessons; i++) //go through each lesson from second up to total number of lessons
            {
                if (this.Days.Length == 1) //if lesson is weekly, add date + 7 days, for each lesson number
                {
                    lessonDateToAdd = this.StartDateTime.AddDays(7);
                }
                else //calculate which dates to add, depending on lesson days
                {
                    //initialize variables
                    DateTime nextLessonDate;
                    int lastAddedDayIndex = Array.IndexOf(Days, lessonDay);  //get index number of current lesson day in Days array  
                    int daysToAdd = 0;  
                    int nextDayIndex = 0; 
                    DayOfWeek nextDay;  
                    
                    //get weekday of next lesson 
                    if (lastAddedDayIndex < this.Days.Length - 1)
                    {
                        nextDayIndex = lastAddedDayIndex + 1;
                    }
                    else {
                        nextDayIndex = 0;
                    }
                    nextDay = this.Days[nextDayIndex];

                    //get days to add to last lesson date to get next lesson date
                    daysToAdd = nextDay - lessonDay;
                    if (daysToAdd < 0)
                    {
                        daysToAdd += 7;
                    }

                    //get next lesson date
                    nextLessonDate = lessonDateToAdd.AddDays(daysToAdd);
                    //add date to arraylist of lesson dates
                    this.LessonDates.Add(nextLessonDate); 

                    //set current day of week to day just added
                    lessonDay = nextLessonDate.DayOfWeek; 
                    //set current lessonDateToAdd to date just added
                    lessonDateToAdd = nextLessonDate;
                }   
            }
        }

        public void CreateLessonsHelper(int lessonNumber)
        //instantiates lesson objects and adds to course Lessons array
        {
            for (int i = lessonNumber - 1; i < this.NumberOfLessons; i ++)
            {
                this.Lessons.Add(new Lesson(this.Name, i + 1, (DateTime)this.LessonDates[i], this.Duration));
            }
        } 

        public static void DisplayAll()
        //displays all courses and course info
        {
            //to do
        }

        public void ManuallyAssignTeacher(Teacher t)
        {
            this.Teacher = t;
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

        public void Extend(int numberNewLessons)
        //extends course by a given number of lessons and adds dates to course LessonDates arraylist
        {

            DateTime lastLessonDate = (DateTime)this.LessonDates[NumberOfLessons - 1];
            int lastLessonNumber = this.NumberOfLessons;
            this.CreateLessonDatesHelper(lastLessonDate, lastLessonDate.DayOfWeek, numberNewLessons);         
            this.NumberOfLessons += numberNewLessons;
            this.CreateLessonsHelper(lastLessonNumber + 1);
        }

        public void PostponeLesson(Lesson lesson)
        //cancels one lesson and adds make up lesson to end of course
        {
            this.LessonDates.Remove(lesson.Date);
            this.Lessons.Remove(lesson);
            for (int i = lesson.LessonNumber + 1; i < this.NumberOfLessons; i++)
            {
                Lesson currentLesson = (this.Lessons[i - 1]) as Lesson;
                currentLesson.LessonNumber -= 1;
            }
            this.NumberOfLessons -= 1;
            this.Extend(1);

        }
    }
}
