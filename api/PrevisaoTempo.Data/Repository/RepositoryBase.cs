using System.Collections.Generic;
using System.Linq;
using PrevisaoTempo.Data.Context;
using PrevisaoTempo.Domain.Entities;
using PrevisaoTempo.Domain.Interfaces;

namespace PrevisaoTempo.Data.Repository
{
   public class RepositoryBase<TEntidade> : IRepository<TEntidade> where TEntidade : Entidade
    {
        protected readonly ApplicationDbContext Context;

        public RepositoryBase(ApplicationDbContext context)
        {
            Context = context;
        }

        public void Add(TEntidade entity)
        {
            Context.Set<TEntidade>().Add(entity);
            Context.SaveChanges();
            
        }

        public virtual TEntidade GetById(int id)
        {
            var query = Context.Set<TEntidade>().Where(entidade => entidade.Id == id);
            return query.Any() ? query.First() : null;
        }

        public virtual IQueryable<TEntidade> ListAll()
        {
            var entidades = Context.Set<TEntidade>().ToList();
            return entidades.Any() ? entidades.AsQueryable() : new List<TEntidade>().AsQueryable();
        }
    }
}