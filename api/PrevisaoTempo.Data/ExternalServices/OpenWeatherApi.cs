
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace PrevisaoTempo.Data.ExternalServices
{
    public class OpenWeatherApi : IOpenWeatherApi
    {
        private string API_KEY; 
        private string URL;

        public OpenWeatherApi()
        {
           API_KEY = "0649a1d57566b8d5fbc8d9c1cae39adf";
           URL = "http://api.openweathermap.org/data/2.5/weather";
        }   



        public string GetWheatherByCityName(string cityName)
        {          
          HttpClient client = new HttpClient();
          client.BaseAddress = new Uri(URL);

           HttpResponseMessage response = client.GetAsync($"?q={cityName}&appid=0649a1d57566b8d5fbc8d9c1cae39adf").Result;  
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                var dataObjects = response.Content.ReadAsStringAsync().Result;  
                client.Dispose();                
                return dataObjects;
                
            }
            else
            {
                client.Dispose();
                throw new Exception("Bad request to openweathermap");
            }
        }
    }
}