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

        [Required]
        [StringLength(PrintingHouseNameMax), MinLength(PrintingHouseNameMin)]
        public required string PrintingHouseName { get; set; }

        /// <summary>
        /// First and last name or only first name
        /// </summary>
        [StringLength(ContactNameMax), MinLength(ContactNameMin)]
        //[Comment("First and last name together or only first name")]
        public string? ContactName { get; set; }

        /// <summary>
        /// The name of the person who released the materials for printing
        /// </summary>
        [Required]
        [StringLength(PersonReleasedMaterialsMax), MinLength(PersonReleasedMaterialsMin)]
        //[Comment("Person who released materials for print")]
        public required string PersonReleasedMaterials { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public required DateTime ReleaseDate { get; set; }

        [StringLength(DescriptionMax), MinLength(DescriptionMin)]
        public string? Description { get; set; }

        [ForeignKey(nameof(Project))]
        public int ProjectId { get; set; }

        public virtual Project? Project { get; set; }
    }
}
