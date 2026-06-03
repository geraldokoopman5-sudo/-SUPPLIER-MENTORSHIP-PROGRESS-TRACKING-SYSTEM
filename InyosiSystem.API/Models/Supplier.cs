using System.ComponentModel.DataAnnotations;

namespace InyosiSystem.API.Models
{
    public class Supplier
    {
        [Key]
        [Required]
        public Guid MentorId { get; set; }
    }
}
//•	MentorId(PK)
//•	FullName
//•	EmailAddress 
//•	Specialisation 
//•	IsActive 
