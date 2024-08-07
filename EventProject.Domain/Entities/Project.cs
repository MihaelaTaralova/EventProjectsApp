using EventProject.Domain.Entities.Account;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static EventProject.Common.EntityValidationConstants.Project;

namespace EventProject.Domain.Entities
{
    public class Project
    {
        public Project()
        {
            this.ProjectLocations = new List<ProjectLocation>();
            this.ProjectMaterials = new List<ProjectMaterials>();
            this.GraphicDesigner = new List<ApplicationUser>();
            this.ScenicDesigner = new List<ApplicationUser>();
        }

        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime AcceptanceDate { get; set; }

        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }

        public virtual Customer? Customer { get; set; }

        [Required]
        [StringLength(ProjectNameMax), MinLength(ProjectNameMin)]
        public required string ProjectName { get; set; }

        public virtual ICollection<ProjectLocation> ProjectLocations { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EventDate { get; set; }

        public virtual ICollection<ApplicationUser> GraphicDesigner { get; set; }

        public virtual ICollection<ApplicationUser> ScenicDesigner { get; set; }

        [ForeignKey(nameof(GraphicDesignerEvaluation))]
        public int? GraphicDesignerEvaluationID { get; set; }
        public virtual Evaluation GraphicDesignerEvaluation { get; set; }

        [ForeignKey(nameof(ScenicDesignerEvaluation))]
        public int? ScenicDesignerEvaluationId { get; set; }
        public virtual Evaluation ScenicDesignerEvaluation { get; set; } 

        [ForeignKey(nameof(ProjectType))]
        public int ProjectTypeId { get; set; }
        public virtual ProjectType? ProjectType { get; set; }

        [DataType(DataType.Date)]
        public DateTime? HandoverDate { get; set; }

        [ForeignKey(nameof(ProjectStatus))]
        public int ProjectStatusId { get; set; }

        public virtual required ProjectStatus ProjectStatus { get; set; }

        [StringLength(DescriptionMax), MinLength(DescriptionMin)]
        public string? Description { get; set; }

        /// <summary>
        /// This date is for handover if after the first handover corrections are made
        /// </summary>
        [DataType(DataType.Date)]
        //[Comment("If corrections are made on submitted project this is the new date for handover")]
        public DateTime? HandoverAfterCorrectionDate { get; set; }

        public int NumberCorrections { get; set; }

        // Свързване с ApplicationUser като Project Manager
        [ForeignKey(nameof(ApplicationUser))]
        public Guid ProjectManagerId { get; set; }
        public virtual required ApplicationUser ProjectManager { get; set; }

        /// <summary>
        /// The name of the person who released the materials for printing
        /// </summary>
        [StringLength(PersonReleasedMaterialsMax), MinLength(PersonReleasedMaterialsMin)]
        //[Comment("Person who released materials for print")]
        [ForeignKey(nameof(PersonReleasedMaterials))]
        public Guid? PersonReleasedMaterialsId { get; set; } = null;

        public virtual required ApplicationUser PersonReleasedMaterials { get; set; }

        /// <summary>
        /// release date print materials
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime? PrintMaterialsReleaseDate { get; set; }

        public virtual ICollection<ProjectMaterials> ProjectMaterials { get; set; }

        [StringLength(CommentsMax), MinLength(CommentsMin)]
        public string? Comments { get; set; }

    }
}
