using System;
using System.ComponentModel.DataAnnotations; 

namespace programmeringmed.Net2.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Förnamn är obligatoriskt.")]
        public string? fname { get; set; }

        [Required(ErrorMessage = "Efternamn är obligatoriskt.")]
        public string? lname { get; set; }

        [Required(ErrorMessage = "Ålder är obligatorisk.")]
        [Range(1, 120, ErrorMessage = "Ålder måste vara mellan 1 och 120.")]
        public int age { get; set; }

        [Required(ErrorMessage = "Kön är obligatoriskt.")]
        public string? gender { get; set; }
        [Required(ErrorMessage = "Anställningsstatus obligatorisk.")]

        public string? work { get; set; }
    }
}
