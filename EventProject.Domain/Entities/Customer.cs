using System.ComponentModel.DataAnnotations;
using static EventProject.Common.EntityValidationConstants.Customer;

namespace EventProject.Domain.Entities
{
    public class Customer
    {
        public Customer()
        {
            this.Projects = new List<Project>();
        }

        [Key]
        public required int Id { get; set; }

        [Required]
        [StringLength(CompanyNameMax), MinLength(CompanyNameMin)]
        public required string CompanyName { get; set; }

        /// <summary>
        /// First and last name
        /// </summary>
        [StringLength(ContactPersonNameMax), MinLength(ContactPersonNameMin)]
        //[Comment("First and last name")]
        public string? ContactPersonName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? EmailAddress { get; set; }

        [RegularExpression(@"/^\\+[1-9]{1}[0-9]{1,14}$/gm", ErrorMessage = "Not a valid number")]
        public string? MobileNumber { get; set; }

        [StringLength(CommentsMax), MinLength(CommentsMin)]
        public string? Comments { get; set; }

        public virtual ICollection<Project> Projects { get; set; } 
    }
}
