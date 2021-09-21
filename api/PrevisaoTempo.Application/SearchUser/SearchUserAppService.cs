using System.Collections.Generic;
using System.Linq;
using PrevisaoTempo.Application.SearchUser.Adapters;
using PrevisaoTempo.Application.SearchUser.DTO;
using PrevisaoTempo.Application.SearchUser.Interfaces;
using PrevisaoTempo.Domain.Interfaces;

namespace PrevisaoTempo.Application.SearchUser
{
    public class SearchUserAppService : ISearchUserAppService
    {
        private readonly ISearchUserRepository _repository;

        public SearchUserAppService(ISearchUserRepository repository)
        {
            _repository = repository;
            
        }

        public IQueryable<SearchResultDTO> ListHistorySearch()
        {
            var history = _repository.ListAll().Select(SearchAdapter.ConvertToDTO);            
            return history;
        }

        public IQueryable<SearchResultDTO> SearchWeather(string cityname)
        {
            throw new System.NotImplementedException();
        }
    }
}