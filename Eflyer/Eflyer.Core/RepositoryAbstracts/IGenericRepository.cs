using Eflyer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eflyer.Core.RepositoryAbstracts
{
   public interface IGenericRepository <T> where T: BaseEntity, new()
    {
        void Add(T entity);
        void Delete(T entity);
        int Commit();
        Task<int> CommitAsync();
        T Get (Func<T,bool>? func = null);
        List <T> GetAll (Func<T,bool>? func = null);
    }
}
