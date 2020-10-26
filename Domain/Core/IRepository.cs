using System;
using System.Collections.Generic;
using Criteria;

namespace Core
{
    public interface IRepository<T>
    {
        int Create(T entity);
        T Read(String id);
        List<T> Read();
        int Update(T entity);
        int Delete(String id);
        List<J> SearchByCriteria<J>(SearchCriteria criteria);
    }
}
