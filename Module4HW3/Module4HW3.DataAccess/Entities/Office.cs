﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Module4HW4.DataAccess.Entities
{
    public class Office
    {
        public int OfficeId { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
