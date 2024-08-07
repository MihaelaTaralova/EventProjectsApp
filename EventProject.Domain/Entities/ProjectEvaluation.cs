using EventProject.Domain.Entities.Account;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventProject.Domain.Entities;

public class ProjectEvaluation
{
    [ForeignKey(nameof(User))]
    public Guid UserId { get; set; }
    public virtual required ApplicationUser User { get; set; }

    [ForeignKey(nameof(Project))]
    public int ProjectId { get; set; }
    public virtual required  Project Project { get; set; }

    [ForeignKey(nameof(Evaluation))]
    public int EvaluationId { get; set; }
    public virtual required Evaluation Evaluation { get; set; }
}
