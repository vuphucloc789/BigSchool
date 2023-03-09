using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VuPhucLoc_201106058_Buoi3.Models;

namespace VuPhucLoc_201106058_Buoi3.ViewModels
{
    public class CourseViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }

    }
}