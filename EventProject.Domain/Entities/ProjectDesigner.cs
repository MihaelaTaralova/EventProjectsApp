using System.ComponentModel.DataAnnotations.Schema;

namespace EventProject.Domain.Entities
{
    public class ProjectDesigner
    {
        [ForeignKey(nameof(Project))]
        public int ProjectId { get; set; }
        public required Project Project { get; set; }

        [ForeignKey(nameof(Designer))]
        public int DesignerId { get; set; }
        public required Designer Designer { get; set; }

        /// <summary>
        /// true for graphic designer, false for scenic designer
        /// </summary>
        public bool IsGraphicDesigner { get; set; }

        /// <summary>
        /// Evaluation for the specific designer in this project
        /// </summary>
        public int? Evaluation { get; set; } 
    }
}
