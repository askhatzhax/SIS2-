using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Models
{
    public class Employee
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public int Price { get; set; }
       public string PhotoPath { get; set; }
       public string Discount { get; set; }
        public Dept? Genre { get; set; }/*Вопросилтельный знак так как обьект может ничего не содеожать */
    }
}
