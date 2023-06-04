using aspnet_core_jwt_authentication_authorization_tryout.Entities.Abstract;

namespace aspnet_core_jwt_authentication_authorization_tryout.Entities.Concrete
{
    public class WeatherForecast : IWeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string? Summary { get; set; }
    }
}
