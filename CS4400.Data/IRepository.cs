using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS4400.Data
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll(bool includeInactive = false);
        IQueryable<T> GetAllFor(Guid id, bool includeDefault = true, bool includeInactive = false);
        T Find(params object[] keyValues);
        T FindQuick(params object[] keyValues);
        void Attach(T entity);
        void AttachRange(IEnumerable<T> entity);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(params object[] keyValues);
    }  
}