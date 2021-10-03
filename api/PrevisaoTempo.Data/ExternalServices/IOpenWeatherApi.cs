namespace PrevisaoTempo.Data.ExternalServices
{
    public interface IOpenWeatherApi
    {
        string GetWheatherByCityName(string cityname);
         
    }
}