using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ASPMVCver5.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Display(Name="Name")]
        public string StudentName { get; set; }
        public int Age { get; set; }
        public bool isNewlyEnrolled { get; set; }
        public string Password {get;set;}
        public string Description { get; set; }


    }

    public enum Gender
    {
        Male,
        Female
    }

}