using System.ComponentModel.DataAnnotations;
using static EventProject.Common.EntityValidationConstants.ProjectManager;

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
        [StringLength(FirstNameMax), MinLength(FirstNameMin)]
        public required string FirstName { get; set; }

        [StringLength(LastNameMax), MinLength(LastNameMin)]
        public string? LastName { get; set; } = null;

        public virtual ICollection<Project> Projects { get; set; } 
    }
}
