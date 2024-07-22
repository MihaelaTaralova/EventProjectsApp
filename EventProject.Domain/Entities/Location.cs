using System.ComponentModel.DataAnnotations;
using static EventProject.Common.EntityValidationConstants.Location;

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
        [StringLength(LocationNameMax), MinLength(LocationNameMin)]
        public required string LocationName { get; set; }

        [StringLength(ContactNameMax), MinLength(ContactNameMin)]
        public string? ContactName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? EmailAddress { get; set; }

        [RegularExpression(@"/^\\+[1-9]{1}[0-9]{1,14}$/gm", ErrorMessage = "Not a valid number")]
        public string? MobileNumber { get; set; }

        [StringLength(DescriptionMax), MinLength(DescriptionMin)]
        public string? Description { get; set; }

        public virtual ICollection<ProjectLocation> ProjectLocations { get; set; } 
    }
}
