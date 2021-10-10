using System;
using System.Linq.Expressions;
using PrevisaoTempo.Application.SearchUser.DTO;

namespace PrevisaoTempo.Application.SearchUser.Adapters
{
    public class SearchAdapter
    {
        public static Expression<Func<Domain.Entities.SearchUser, SearchResultDTO>> ConvertToDTO = search => new SearchResultDTO
        {
            Id = search.Id,
            Name = search.Name,
            Temp = search.Temp,
            Weather = search.Weather,
            Humidity = search.Humidity,
            Icon = search.Icon,
            CreationDate = search.CreationDate
        };
    }
}