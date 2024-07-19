namespace EventProject.Domain.Entities
{
    public class ProjectType
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public string? Description { get; set; }
    }
}
