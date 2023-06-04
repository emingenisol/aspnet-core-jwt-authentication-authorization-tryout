using System.ComponentModel.DataAnnotations;

namespace aspnet_core_jwt_authentication_authorization_tryout.Entities.Abstract
{
    // purpose for user login.
    public interface ILogin
    {
        [Required(ErrorMessage = "User Name is required")]
        string? Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        string? Password { get; set; }
    }
}
