using Microsoft.EntityFrameworkCore;
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
            this.PrintMaterials = new List<PrintMaterials>();
            this.NumberCorrections = new List<int>();
            this.ProjectDesigners = new List<ProjectDesigner>();
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

        public virtual ICollection<ProjectDesigner> ProjectDesigners { get; set; }

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

        public List<int> NumberCorrections { get; set; }

        [ForeignKey(nameof(ProjectManager))]
        public int ProjectManagerId { get; set; }

        public virtual required ProjectManager ProjectManager { get; set; }    
        
        public virtual List<PrintMaterials>? PrintMaterials { get; set; }

        [StringLength(CommentsMax), MinLength(CommentsMin)]
        public string? Comments { get; set; }


    }
}
