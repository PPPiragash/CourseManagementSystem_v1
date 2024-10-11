using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    public class DigitalCourse : Course
    {
        public string CourseLink { get; set; }

        public double FileSize { get; set; }

        public DigitalCourse(string courseId,string title, string duration, decimal price, string courseLink, double fileSize): base (courseId,title,duration,price)

        {
            CourseLink = courseLink;
            FileSize = fileSize;
        }

        public override string DisplayCourseInfo()
        {
            return $"{base.DisplayCourseInfo()}, Link : {CourseLink}, File Size : {FileSize}MB";
        }


    }
}
