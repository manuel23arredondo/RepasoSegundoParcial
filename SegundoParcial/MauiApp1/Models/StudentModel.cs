﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class StudentModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get{ return $"{FirstName} {LastName}"; } }

        public override string ToString()
        {
            return FullName;
        }
    }
}
