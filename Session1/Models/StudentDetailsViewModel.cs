using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session1.Models
{
     //View Model
    public class StudentDetailsViewModel
    {
        public Student Student { get; set; }  //Object type 
        public Address Address { get; set; }
        public string Title { get; set; }
        public string Header { get; set; }
    }

}
