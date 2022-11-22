using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentFeedback.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true,
               DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime date { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string gender { get; set; }

        [Required(ErrorMessage = "Course is required")]
        public Courses courses { get; set; }

        [Required(ErrorMessage = "Ratings is required")]
        public string Ratings { get; set; }

        [Required(ErrorMessage = "sugesstion is required")]
        public string sugesstion { get; set; }

        public Demo Demome { get; set; }



    }

    public enum Demo
    {
        Excellent, Good, Average, poor
    }

    public enum Ratings
    {
        Excellent, Good, Average, poor
    }

    public enum Gender
    {
        Male,FeMale
    }
}