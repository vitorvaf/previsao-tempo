using System.Collections.Generic;
using System.Linq;

namespace PrevisaoTempo.Domain.Interfaces
{
    public interface IRepository<TEntidade>
    {

        TEntidade GetById(int id);
        IQueryable<TEntidade> ListAll();
        void Add(TEntidade entity);


    }
}