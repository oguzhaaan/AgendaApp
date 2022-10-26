using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agenda_App.Models
{
    public class Schedule
    {
        public int Id { get; set; }

        [StringLength(120, MinimumLength = 5)]
        [Required]
        public string? Description { get; set; }

        [Display(Name = "Planned Date")]
        [DataType(DataType.Date)]
        public DateTime PlannedDate { get; set; }

        [Display(Name = "Time")]
        [DataType(DataType.Time)]
        public string? Time { get; set; }

        [StringLength(120, MinimumLength = 5)]
        [Display(Name = "Meeting Address")]
        [Required]
        public string? MeetingAddress { get; set; }
    }
}