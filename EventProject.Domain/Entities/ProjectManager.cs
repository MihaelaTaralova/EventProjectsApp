using System.ComponentModel.DataAnnotations;

namespace EventProject.Domain.Entities
{
    public class ProjectManager
    {
        public ProjectManager()
        {
            this.Projects = new List<Project>();
        }

        [Key]
        public required int Id { get; set; }

        [Required]
        public required string FirstName { get; set; }

        public string? LastName { get; set; } = null;

        public virtual ICollection<Project> Projects { get; set; } 
    }
}
