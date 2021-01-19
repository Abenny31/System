using System;
using System.ComponentModel.DataAnnotations;

namespace CorePokus3.Entities
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int PIN { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsVolunteer { get; set; }
        public bool IsOutsorced { get; set; }
    }
}