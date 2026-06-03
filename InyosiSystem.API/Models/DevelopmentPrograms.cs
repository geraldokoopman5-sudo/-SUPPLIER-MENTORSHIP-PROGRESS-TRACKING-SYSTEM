using System.ComponentModel.DataAnnotations;
using InyosiSystem.API.Enums;

namespace InyosiSystem.API.Models
{
    public class DevelopmentPrograms
    {
            [Key]
            [Required]
            public Guid ProgrammeId { get; set; }

            [Required]
            [MaxLength(50)]
            public string ProgrammeName { get; set; } = string.Empty;

            [Required]
            [MaxLength(50)]
            public string ProgrammeDescription { get; set; } = string.Empty;

            [Required]
            public DateTime StartDate { get; set; }

            [Required]
            public DateTime EndDate { get; set; }

            [Required]
            public ProgressStatus Status { get; set; }
    }
}
    


