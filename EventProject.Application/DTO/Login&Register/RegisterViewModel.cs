using System.ComponentModel.DataAnnotations;
using static EventProject.Common.EntityValidationConstants.ApplicationUser;
namespace EventProject.Application.DTO.Login_Register
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Name can't be blank")]
        [StringLength(FirstNameMax), MinLength(FirstNameMin)]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Name can't be blank")]
        [StringLength(LastNameMax), MinLength(LastNameMin)]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Email can't be blank")]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(ConfirmPassword))]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Passwords must match")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        public string ConfirmPassword { get; set; } = null!;

        [Display(Name = "Phone number")]
        public string? PhoneNumber  { get; set; }

        //[Required]
       // public UserRole Role { get; set; }

       
    }
}
