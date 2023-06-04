using aspnet_core_jwt_authentication_authorization_tryout.Entities.Abstract;

namespace aspnet_core_jwt_authentication_authorization_tryout.Entities.Concrete
{
    public class Login : ILogin
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
