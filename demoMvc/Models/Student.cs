using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace demoMvc.Models
{
    public class Student
    {
       [Key]
        public int idStudent { get; set; }
        public string ageStudent { get; set; }
    }
}
