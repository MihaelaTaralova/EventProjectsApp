using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static EventProject.Common.EntityValidationConstants.PrintMaterials;

namespace EventProject.Domain.Entities
{
    public class PrintMaterials
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// name of the material
        /// </summary>
        /// [Required]
        [StringLength(NameMax), MinLength(NameMin)]
        public string Name { get; set; } = null!;

        [StringLength(DescriptionMax), MinLength(DescriptionMin)]
        public string? Description { get; set; }
    }
}
