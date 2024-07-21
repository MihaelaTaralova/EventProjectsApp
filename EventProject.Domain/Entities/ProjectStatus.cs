using System.ComponentModel.DataAnnotations;

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
        public required string Name { get; set; }
    }
}
