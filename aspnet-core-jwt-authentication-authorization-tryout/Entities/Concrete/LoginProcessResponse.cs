using aspnet_core_jwt_authentication_authorization_tryout.Entities.Abstract;

namespace aspnet_core_jwt_authentication_authorization_tryout.Entities.Concrete
{
    public class LoginProcessResponse : ILoginProcessResponse
    {
        public string? Status { get; set; }
        public string? Message { get; set; }
    }
}
