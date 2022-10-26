using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agenda_App.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Surname { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }


        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Number { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Address { get; set; }



    }
}