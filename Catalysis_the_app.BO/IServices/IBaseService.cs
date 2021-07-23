using Catalysis_the_app.BO.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalysis_the_app.BO.IServices
{
    public interface IBaseService<T, I> where T : class where I : class
    {
        Task<T> Add(T t);
        Task<T> Update(T t);
        Task<T> GetById(int id);
        Task<T> GetById(string id);
        Task<IEnumerable<T>> Get(QueryFilter query);
    }
}
