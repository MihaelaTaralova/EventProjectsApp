
using System.ComponentModel.DataAnnotations;

namespace EventProject.Domain.Entities
{
    public class DesignerCategory
    {
        /*GraphicDesign,
      ScenicDesign*/

        public required int Id { get; set; }

        public required string Name { get; set; }
    }
}
