using System.ComponentModel.DataAnnotations;
using static EventProject.Common.EntityValidationConstants.ProjectStatus;

namespace EventProject.Domain.Entities
{
    public class ProjectStatus
    {
        /*Pending,
        Correction,
        Submitted,
        Past,
        Rejected  */

        [Key]
        public required int Id { get; set; }

        [Required]
        [StringLength(NameMax), MinLength(NameMin)]
        public required string Name { get; set; }
    }
}
