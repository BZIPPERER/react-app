using System;
using System.Collections.Generic;


/*My Model for Employee */
namespace rect.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public DateTime? JoiningDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
