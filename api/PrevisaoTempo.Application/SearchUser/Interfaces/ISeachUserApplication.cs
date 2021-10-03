using System.Collections.Generic;
using System.Linq;
using PrevisaoTempo.Application.SearchUser.DTO;
using PrevisaoTempo.Application.SearchUser.DTOs;

namespace PrevisaoTempo.Application.SearchUser.Interfaces
{
    public interface ISearchUserAppService
    {
        string SearchWeather(string cityname);

        IQueryable<SearchResultDTO> ListHistorySearch();       

        OpenWeatherResultDTO getInfoWeatherByCityname(string cityName);       
         
         
    }
}