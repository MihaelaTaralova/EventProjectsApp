namespace EventProject.Domain.Entities
{
    public class Customer
    {
        public Customer()
        {
            this.Projects = new List<Project>();
        }
        public required int Id { get; set; }

        public required string CompanyName { get; set; }

        public string? ProjectManagerName { get; set; } 

        public string? PhoneNumber { get; set; }

        public string? Comments { get; set; }

        public virtual ICollection<Project> Projects { get; set; } 
    }
}
