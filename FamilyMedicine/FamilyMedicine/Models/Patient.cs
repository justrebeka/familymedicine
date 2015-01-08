using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FamilyMedicine.Models
{
    public class Patient
    {
        public int ID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string CNP { get; set; }

        [Required]
        public string Gender { get; set; }

        public string Phone { get; set; }

        public string Street { get; set; }

        public string City { get; set; }


    }
}