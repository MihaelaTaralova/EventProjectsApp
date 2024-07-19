namespace EventProject.Domain.Entities
{
    public class Designer
    {
        public Designer()
        {
            this.Projects = new List<Project>();
            this.GraphicEvaluations = new List<ProjectEvaluation>();
            this.ScenicEvaluations = new List<ProjectEvaluation>();
        }
        public required int Id { get; set; }

        public required string FirstName { get; set; }

        public string? LastName { get; set; }

        public int CategoryDesignerId { get; set; }

        public virtual required DesignerCategory DesignerCategory { get; set; }

        public virtual ICollection<Project> Projects { get; set; }

        public virtual ICollection<ProjectEvaluation> GraphicEvaluations { get; set; }

        public virtual ICollection<ProjectEvaluation> ScenicEvaluations { get; set; } 
    }
}
