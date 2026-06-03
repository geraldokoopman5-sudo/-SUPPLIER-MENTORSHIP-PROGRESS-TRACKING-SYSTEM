using System.ComponentModel.DataAnnotations;
using InyosiSystem.API.Enums;

namespace InyosiSystem.API.Models
{
    public class Mentor
    {
        [Key]
        [Required]
        public Guid MentorId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FullName { get; set; } = string.Empty;


        [Required]
        [MaxLength(50)]
        public string EmailAddress { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Specialisation { get; set; } = string.Empty;

        [Required]
        public ProgressStatus Status { get; set; }

    }
}
