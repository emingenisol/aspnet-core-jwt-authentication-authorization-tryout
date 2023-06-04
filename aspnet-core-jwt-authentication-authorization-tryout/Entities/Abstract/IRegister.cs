using System.ComponentModel.DataAnnotations;

namespace aspnet_core_jwt_authentication_authorization_tryout.Entities.Abstract
{
    public interface IRegister
    {
        [Required(ErrorMessage = "User Name is required")]
        string? Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        string? Password { get; set; }

        string? RoleType { get; set; }
    }
}
