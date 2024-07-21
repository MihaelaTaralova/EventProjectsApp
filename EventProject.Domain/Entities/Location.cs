using System.ComponentModel.DataAnnotations;

namespace EventProject.Domain.Entities
{
    public class Location
    {
        public Location()
        {
            this.ProjectLocations = new List<ProjectLocation>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        public string? ContactPersonName { get; set; }

        public string? Phone { get; set; }

        public string? Description { get; set; }

        public virtual ICollection<ProjectLocation> ProjectLocations { get; set; } 
    }
}
