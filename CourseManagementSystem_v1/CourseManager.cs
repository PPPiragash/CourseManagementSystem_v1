﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    public class CourseManager
    {
        private List<Course> courses = new List<Course>();

        public void CreateCourse (Course course)
        {
            courses.Add(course);
        }

        public List<Course> ReadCourses()
        {
            return courses;
        }


        public void UpdateCourse (string courseId, string title,string duration,decimal price)
        {
            var course = courses.Find(c => c.CourseId == courseId);
            if (course !=null)
            {
                course.Title = title;
                course.Duration = duration;
                course.Price = price;
            }
        }


        public void DeleteCourse (string courseId)
        {
            var course = courses.Find(c=> c.CourseId == courseId);
            if (course != null)
            {
                courses.Remove(course);
            }
        }
    }
}
