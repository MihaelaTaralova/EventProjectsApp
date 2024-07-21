using System.ComponentModel.DataAnnotations;

namespace EventProject.Domain.Entities
{
    public class ProjectType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        public string? Description { get; set; }
    }
}
