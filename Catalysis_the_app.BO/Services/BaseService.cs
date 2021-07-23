using AutoMapper;
using Catalysis_the_app.BO.IServices;
using Catalysis_the_app.BO.ViewModels;
using Catalysis_the_app.DAL;
using Catalysis_the_app.DAL.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalysis_the_app.BO.Services
{
    //T : View Model
    //I : Original Model
    public class BaseService<T, I> : IBaseService<T,I>
        where T : class
        where I : class
    {
        //protected readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepos<I> _repos;
        private readonly IMapper _mapper;
        private readonly BaseFilterBO<T> _filter;
        public BaseService(
            //IUnitOfWork unitOfWork,
            IMapper mapper,
            IGenericRepos<I> repos,
            BaseFilterBO<T> filter
            )
        {
            //_unitOfWork = unitOfWork;
            _mapper = mapper;
            _repos = repos;
            _filter = filter;
        }

        public async Task<T> Add(T t)
        {
            I i = _mapper.Map<I>(t);
            await _repos.Create(i);
            T insertedT = _mapper.Map<T>(i);
            return insertedT;
        }

        public async Task<IEnumerable<T>> Get(QueryFilter query)
        {
            IEnumerable<T> list = await _filter.Filter(query).ToListAsync();
            return list;
        }

        public async Task<T> GetById(int id)
        {
            I i = await _repos.GetById(id);
            return _mapper.Map<T>(i);
        }

        public async Task<T> GetById(string id)
        {
            I i = await _repos.GetById(id);
            return _mapper.Map<T>(i);
        }

        public async Task<T> Update(T t)
        {
            I i = _mapper.Map<I>(t);
            await _repos.Update(i);
            T insertedT = _mapper.Map<T>(i);
            return insertedT;
        }


    }
}
