﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TEams
{
    class Project
    { //Proprties
        public string Name { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string DueDate { get; set; }
        public List<Employee> TeamMembers { get; set; }

        //Constructor
        public Project (string name, string description, string startDate, string dueDate)
        {
            Name = name;
            Description = description;
            StartDate = startDate;
            DueDate = dueDate;

        }
    }
}
