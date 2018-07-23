using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name="Name")]
        public string StudentName { get; set;  }

        public int Age { set; get; }
        //public Standard standard { get; set; }
    }

    public class Standard
    {
        public int StandardId { get; set; }

        public string StandardName { get; set; }
    }

}