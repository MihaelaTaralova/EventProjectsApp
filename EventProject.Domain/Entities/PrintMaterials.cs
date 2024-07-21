using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EventProject.Domain.Entities
{
    public class PrintMaterials
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string PrintingHouseName { get; set; }

        public string? ContactName { get; set; }

        /// <summary>
        /// The name of the person who released the materials for printing
        /// </summary>
        [Required]
        public required string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public required DateTime ReleaseDate { get; set; }

        public string? Description { get; set; }

        [ForeignKey(nameof(Project))]
        public int ProjectId { get; set; }

        public virtual Project? Project { get; set; }
    }
}
