using System.ComponentModel.DataAnnotations;

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
        public required string CompanyName { get; set; }

        public string? ContactPersonName { get; set; } 

        public string? PhoneNumber { get; set; }

        public string? Comments { get; set; }

        public virtual ICollection<Project> Projects { get; set; } 
    }
}
