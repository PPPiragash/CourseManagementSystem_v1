﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    public class Course
    {


        public string CourseId { get; set; }

        public string Title { get; set; }

        public string Duration { get; set; }

        public decimal Price { get; set; }

        public static int TotalCourses { get; private set; } = 0;

        public Course(string courseId, string title, string duration, decimal price)
        {
            CourseId = courseId;
            Title = title;
            Duration = duration;
            Price = price;
            TotalCourses++;
        }


        public override string ToString()
        {
            return $"ID: {CourseId}, Title: {Title}, Duration: {Duration}, Price: {Price:C}";
        }


        public virtual string DisplayCourseInfo()
        {
            return $"ID: {CourseId}, Title: {Title}, Duration: {Duration}, Price: {Price:C}";
        }


        

        
       
    }

    

}
