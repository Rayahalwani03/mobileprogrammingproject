﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobileprogrammingproject.Models
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]

        public int StudentID { get; set; }

        public string StudentName { get; set; }
        public string StudentDepartment { get; set;}
    }
}
