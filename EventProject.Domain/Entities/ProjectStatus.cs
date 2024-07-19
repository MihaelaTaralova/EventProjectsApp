namespace EventProject.Domain.Entities
{
    public class ProjectStatus
    {
        /*Pending,
        Correction,
        Submitted,
        Past,
        Rejected  */

        public required int Id { get; set; }

        public required string Name { get; set; }
    }
}
