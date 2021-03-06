using Northwind.Entity.Base;
using Northwind.Entity.IBase;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll
{
    public class GenericManager<T, TDto> : IGenericService<T, TDto> where T : EntityBase where TDto : DtoBase
    {
        //UnitOfWork
        //IServiceProvider
        //GenericRepository
        //Constructor
        public IResponce<TDto> Add(TDto item, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public Task<IResponce<TDto>> AddAsync(TDto item, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public IResponce<bool> DeleteById(int id, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public Task<IResponce<TDto>> DeleteByIdAsync(int id, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public IResponce<TDto> Find(int id)
        {
            throw new NotImplementedException();
        }

        public IResponce<List<TDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResponce<List<TDto>> GetAll(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TDto> GetQueryable()
        {
            throw new NotImplementedException();
        }

        public IResponce<TDto> Update(TDto item, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public Task<IResponce<TDto>> UpdateAsync(TDto item, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}