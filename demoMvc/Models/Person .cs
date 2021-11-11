using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace demoMvc.Models
{
    public class Person
    {
        [Key]
        public string PersonID { get; set; }
        public string PersonName { get; set; }
        
    }
}
