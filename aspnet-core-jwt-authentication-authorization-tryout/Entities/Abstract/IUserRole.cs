using System.ComponentModel.DataAnnotations;

namespace aspnet_core_jwt_authentication_authorization_tryout.Entities.Abstract
{
    public interface IUserRole
    {
        [Required]
        string? Admin { get; set; }
        [Required]
        string? User { get; set; }
    }
}
