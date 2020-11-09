using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesStudent.Models
{
    public class Student
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public int Class { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
    }
}