namespace EventProject.Domain.Entities
{
    public class Project
    {
        public Project()
        {
            this.Location = new List<Location>();
            this.PrintMaterials = new List<PrintMaterials>();
            this.NumberCorrections = new List<int>();
        }
        public int Id { get; set; }

        public DateTime AcceptanceDate { get; set; }

        public virtual Customer? Customer { get; set; }

        public required string ProjectName { get; set; }

        public virtual required List<Location> Location { get; set; } 

        public DateTime? EventDate { get; set; }

        public int GraphicDesignerId { get; set; }

        public Designer? GraphicDesigner { get; set; }

        public int ScenicDesignerId { get; set; }

        public Designer? ScenicDesigner { get; set; }

        public virtual ProjectEvaluation? GraphicEvaluation { get; set; }

        public virtual ProjectEvaluation? ScenicEvaluation { get; set; }

        public virtual ProjectType? ProjectType { get; set; }

        public DateTime? HandoverDate { get; set; }

        /// <summary>
        /// This date is for handover if after the first handover corrections are made
        /// </summary>
        public virtual required ProjectStatus ProjectStatus { get; set; }

        public string? Description { get; set; }       

        public DateTime? HandoverAfterCorrectionDate { get; set; }

        public List<int> NumberCorrections { get; set; } 

        public virtual required ProjectManager ProjectManager { get; set; }    
        
        public virtual List<PrintMaterials>? PrintMaterials { get; set; } 

        public string? Comments { get; set; }


    }
}
