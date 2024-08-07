using static EventProject.Common.EntityValidationConstants.PrintingHouse;
using System.ComponentModel.DataAnnotations;

namespace EventProject.Domain.Entities
{
    public class PrintingHouse
    {
        public int Id { get; set; }

        [Required]
        [StringLength(PrintingHouseNameMax), MinLength(PrintingHouseNameMin)]
        public required string PrintingHouseName { get; set; }

        /// <summary>
        /// First and last name or only first name
        /// </summary>
        [StringLength(ContactNameMax), MinLength(ContactNameMin)]
        //[Comment("First and last name together or only first name")]
        public string? ContactName { get; set; } = null;

        [RegularExpression(@"/^\\+[1-9]{1}[0-9]{1,14}$/gm", ErrorMessage = "Not a valid number")]
        public string? MobilePhone { get; set; } = null;
    }
}
