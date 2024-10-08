﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static EventProject.Common.EntityValidationConstants.ApplicationUser;

namespace EventProject.Domain.Entities.Account
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();
            this.Projects = new List<Project>();
            this.ProjectsEvaluations = new List<ProjectEvaluation>(); 
        }

        [Required]
        [MaxLength(FirstNameMax)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMax)]
        public string LastName { get; set; } = null!;

        public virtual ICollection<ProjectEvaluation>? ProjectsEvaluations { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
