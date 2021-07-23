using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalysis_the_app.DAL.Services
{
    public interface IGenericRepos<T> where T : class
    {
        IQueryable<T> GetAll();

        Task<T> GetById(int Id);

        Task<T> GetById(string Id);
        Task<T> Create(T entity);

        Task Update(T entity);

        Task Delete(int id);
    }
}
