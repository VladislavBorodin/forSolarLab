using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace forSolarLab.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string FullName { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public Boolean Past { get; set; }
        public string Photo { get; set; }
        
    }
}
