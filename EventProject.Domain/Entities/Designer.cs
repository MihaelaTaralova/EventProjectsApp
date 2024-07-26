using EventProject.Domain.Entities.Account;
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
               
        [ForeignKey(nameof(DesignerCategory))]
        public int DesignerCategoryId { get; set; }
        public virtual required DesignerCategory DesignerCategory { get; set; }

        // Свързване с ApplicationUser
        [Key, ForeignKey(nameof(ApplicationUser))]
        public Guid ApplicationUserId { get; set; }
        public virtual required ApplicationUser ApplicationUser { get; set; }

        public virtual ICollection<ProjectDesigner> ProjectDesigners { get; set; }
    }
}
