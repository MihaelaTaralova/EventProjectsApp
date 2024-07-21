using System.ComponentModel.DataAnnotations.Schema;

namespace EventProject.Domain.Entities
{
    public class ProjectLocation
    {
        [ForeignKey(nameof(Project))]
        public int ProjectId { get; set; }
        public required Project Project { get; set; }

        [ForeignKey(nameof(Location))]
        public int LocationId { get; set; }
        public required Location Location { get; set; }
    }
}
