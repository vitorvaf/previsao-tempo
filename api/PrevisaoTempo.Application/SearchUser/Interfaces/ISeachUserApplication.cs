using System.Collections.Generic;
using System.Linq;
using PrevisaoTempo.Application.SearchUser.DTO;

namespace PrevisaoTempo.Application.SearchUser.Interfaces
{
    public interface ISearchUserAppService
    {
        IQueryable<SearchResultDTO> SearchWeather(string cityname);

        IQueryable<SearchResultDTO> ListHistorySearch();        
         
    }
}