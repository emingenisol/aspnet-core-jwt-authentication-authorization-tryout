using aspnet_core_jwt_authentication_authorization_tryout.Entities.Abstract;

namespace aspnet_core_jwt_authentication_authorization_tryout.Entities.Concrete
{
    public class Register : IRegister
    {
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? RoleType { get; set; }
    }
}
