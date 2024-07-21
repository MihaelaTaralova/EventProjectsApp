using System.ComponentModel.DataAnnotations;

namespace EventProject.Domain.Entities
{
    public class DesignerCategory
    {
        /*GraphicDesign,
      ScenicDesign*/

        [Key]
        public required int Id { get; set; }

        [Required]
        public required string Name { get; set; }
    }
}
