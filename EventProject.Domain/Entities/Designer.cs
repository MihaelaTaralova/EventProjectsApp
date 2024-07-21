using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventProject.Domain.Entities
{
    public class Designer
    {
        public Designer()
        {
            this.ProjectDesigners = new List<ProjectDesigner>();
        }

        [Key]
        public required int Id { get; set; }

        [Required]
        public required string FirstName { get; set; }

        public string? LastName { get; set; }

        [ForeignKey(nameof(DesignerCategory))]
        public int DesignerCategoryId { get; set; }

        public virtual required DesignerCategory DesignerCategory { get; set; }

        public virtual ICollection<ProjectDesigner> ProjectDesigners { get; set; }
    }
}
