using System;
using System.Collections.Generic;
using System.Text;

namespace SIS2.Models
{
    public class Employee2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string PhotoPath { get; set; }
        public string Discount { get; set; }
        public Dept2? Genre { get; set; }
    }
}
