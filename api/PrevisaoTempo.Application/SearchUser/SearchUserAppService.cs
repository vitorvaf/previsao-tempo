using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using PrevisaoTempo.Application.SearchUser.Adapters;
using PrevisaoTempo.Application.SearchUser.DTO;
using PrevisaoTempo.Application.SearchUser.DTOs;
using PrevisaoTempo.Application.SearchUser.Interfaces;
using PrevisaoTempo.Data.ExternalServices;
using PrevisaoTempo.Domain.Interfaces;
using PrevisaoTempo.Domain.Entities;


namespace PrevisaoTempo.Application.SearchUser
{
    public class SearchUserAppService : ISearchUserAppService
    {
        private readonly ISearchUserRepository _repository;
        private readonly IOpenWeatherApi _openWeatherApi;

        public SearchUserAppService(ISearchUserRepository repository, IOpenWeatherApi openWeatherApi)
        {
            _repository = repository;
            _openWeatherApi = openWeatherApi;

        }

        public OpenWeatherResultDTO getInfoWeatherByCityname(string cityName)
        {
            var responseApi = _openWeatherApi.GetWheatherByCityName(cityName);
            OpenWeatherResultDTO weather = JsonConvert.DeserializeObject<OpenWeatherResultDTO>(responseApi);
            if(weather != null)
            {
                CreateHistory(weather);
            }
            
            return weather;
        }

        public IQueryable<SearchResultDTO> ListHistorySearch()
        {
            var history = _repository.ListAll().Select(SearchAdapter.ConvertToDTO);
            
            return history;
        }

        public string SearchWeather(string cityname)
        {
            return _openWeatherApi.GetWheatherByCityName(cityname);
        }

        private bool CreateHistory(OpenWeatherResultDTO responseApi)
        {
            var newSearch = new Domain.Entities.SearchUser(
                responseApi.name, 
                (int)responseApi.main.temp,
                responseApi.weather.FirstOrDefault().description, 
                responseApi.main.humidity.ToString(), 
                responseApi.weather.FirstOrDefault().icon);
          
          
            _repository.Add(newSearch);

            return true;

        }
    }
}