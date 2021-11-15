using System;
using System.Collections.Generic;
using System.Text;

namespace Module4HW3.DataAccess.Entities
{
    public class Title
    {
        public int TitleId { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
