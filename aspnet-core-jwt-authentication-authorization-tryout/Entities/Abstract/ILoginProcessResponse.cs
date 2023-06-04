namespace aspnet_core_jwt_authentication_authorization_tryout.Entities.Abstract
{
    public interface ILoginProcessResponse
    {
        string? Status { get; set; }
        string? Message { get; set; }
    }
}
