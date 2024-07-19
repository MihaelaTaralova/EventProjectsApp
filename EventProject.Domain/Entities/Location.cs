namespace EventProject.Domain.Entities
{
    public class Location
    {
        public Location()
        {
            this.Projects = new List<Project>();
        }
        public int Id { get; set; }

        public required string Name { get; set; }

        public string? ContactPersonName { get; set; }

        public string? Phone { get; set; }

        public string? Description { get; set; }

        public virtual ICollection<Project> Projects { get; set; } 
    }
}
