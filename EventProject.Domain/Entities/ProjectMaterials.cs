using EventProject.Domain.Entities.Account;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventProject.Domain.Entities;

public class ProjectMaterials
{
    [ForeignKey(nameof(Project))]
    public int ProjectId { get; set; }
    public virtual Project? Project { get; set; }

    [ForeignKey(nameof(Material))]
    public int MaterialId { get; set; }
    public virtual PrintMaterials? Material { get; set; }

    [ForeignKey(nameof(PrintingHouse))]
    public int PrintingHouseId { get; set; }
    public virtual PrintingHouse? PrintingHouse { get; set; }

    public int Number { get; set; }
}
