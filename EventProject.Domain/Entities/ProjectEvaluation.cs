namespace EventProject.Domain.Entities
{
    public class ProjectEvaluation
    {
        public int Id { get; set; }
        /// <summary>
        /// Evaluation for the graphic part (1 to 5)
        /// </summary>
        public int GraphicEvaluation { get; set; }

        /// <summary>
        /// Evaluation for the scenic part (1 to 5)
        /// </summary>
        public int ScenicEvaluation { get; set; }

        public int ProjectId { get; set; }

        public virtual required Project Project { get; set; }

        public int DesignerId { get; set; }

        public virtual required Designer Designer { get; set; }
    }
}
