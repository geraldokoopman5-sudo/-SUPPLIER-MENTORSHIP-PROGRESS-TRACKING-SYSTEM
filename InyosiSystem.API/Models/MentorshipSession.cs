using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using InyosiSystem.API.Enums;

namespace InyosiSystem.API.Models
{
    public class MentorshipSession
    {
        [Key]
        [Required]
        public Guid SessionId { get; set; }

        //[ForeignKey]
        //[Required]
        //public SupplierMentorship SupplierMentorshipId { get; set; }

        [Required]
        public DateTime SessionDate { get; set; }

        [Required]
        [MaxLength(100)]
        public string SessionTopic { get; set; } = string.Empty;

        [Required]
        [MaxLength(500)]
        public string SessionNotes { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string ActionItems { get; set; } = string.Empty;

        [Required]
        public Attendance AttendanceStatus { get; set; }
    }
}

