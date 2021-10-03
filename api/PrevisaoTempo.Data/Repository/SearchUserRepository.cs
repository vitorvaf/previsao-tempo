using PrevisaoTempo.Data.Context;
using PrevisaoTempo.Domain.Entities;
using PrevisaoTempo.Domain.Interfaces;



namespace PrevisaoTempo.Data.Repository
{
    public class SearchUserRepository : RepositoryBase<SearchUser>, ISearchUserRepository
    {
        
        public SearchUserRepository(ApplicationDbContext context) : base(context)
        {


        }
    }
}