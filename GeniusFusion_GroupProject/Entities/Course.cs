﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using System.Diagnostics.Eventing.Reader;


namespace GeniusFusion_GroupProject.Entities
{
    public class Course
    {

        public int ? CourseId { get; set; }
        public string ?  CourseName { get; set; }


        // Navigation Property for the faculty teaching this course 

        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }

        public List<Enrollment> Enrollments { get; set; }


    }
}

