using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VuPhucLoc_201106058_Buoi3.Models;

namespace VuPhucLoc_201106058_Buoi3.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}