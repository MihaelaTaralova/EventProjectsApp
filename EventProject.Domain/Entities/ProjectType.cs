using System.ComponentModel.DataAnnotations;
using static EventProject.Common.EntityValidationConstants.ProjectType;

namespace EventProject.Domain.Entities
{
    public class ProjectType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(NameMax), MinLength(NameMin)]
        public required string Name { get; set; }

        [StringLength(DescriptionMax), MinLength(DescriptionMin)]
        public string? Description { get; set; }
    }
}
