using System;
using PrevisaoTempo.Domain.Validation;

namespace PrevisaoTempo.Domain.Entities
{
    public class SearchUser
    {
        public string Name { get; private set; }
        public int Temp { get; private set; }
        public string Weather{ get; private set; }
        public string Humidity { get; private set; }
        public string Icon { get; private set; }

        public SearchUser(string name, int? temp, string weather, string humidity, string Icon)
        {
            ValidationEntitie(name,temp,weather,humidity,Icon);
            
        }

        private void ValidationEntitie(string name, int? temp, string weather, string humidity, string icon)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), 
                "Invalid name, Name is required");
            
            DomainExceptionValidation.When(!temp.HasValue,
                "Invalid temperature, Temp is required");

            DomainExceptionValidation.When(string.IsNullOrEmpty(weather),
                "Invalid weather, Weather is required");
            
            DomainExceptionValidation.When(string.IsNullOrEmpty(humidity),
                "Invalid humidity, Humidity is required");
            
            DomainExceptionValidation.When(string.IsNullOrEmpty(icon),
                "Invalid icon, Icon is required");


            Name = name;
            Temp = (int)temp;
            Weather = weather;
            Humidity = humidity;
            Icon = icon;

        }
    }
}