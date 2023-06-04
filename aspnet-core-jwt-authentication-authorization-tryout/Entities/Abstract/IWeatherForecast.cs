namespace aspnet_core_jwt_authentication_authorization_tryout.Entities.Abstract
{
    public interface IWeatherForecast
    {
        DateTime Date { get; set; }

        int TemperatureC { get; set; }

        int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        string? Summary { get; set; }
    }
}
