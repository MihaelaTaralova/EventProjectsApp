using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventProject.Domain.Entities
{
    public class ProjectDesigner
    {
        [ForeignKey(nameof(Project))]
        public int ProjectId { get; set; }
        public required Project Project { get; set; }

        [ForeignKey(nameof(Designer))]
        public Guid DesignerId { get; set; }
        public required Designer Designer { get; set; }

        /// <summary>
        /// true for graphic designer, false for scenic designer
        /// </summary>
        public bool IsGraphicDesigner { get; set; }

        /// <summary>
        /// Evaluation for the specific designer in this project
        /// </summary>
        [RegularExpression(@"^(10|[1-9])$", ErrorMessage = "The evaluation should be between 1 and 10")]
        public int? Evaluation { get; set; } 
    }
}
