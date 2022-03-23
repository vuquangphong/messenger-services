using Mobile.Messenger.Core.Interfaces.Infrastructure;
using Mobile.Messenger.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Messenger.Core.Services
{
    public class BaseService<T> : IBaseService<T>
    {
        #region Dependency Injection
        
        private readonly IBaseRepository<T> _baseRepository;

        public BaseService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        #endregion

        #region Main Methods

        public IEnumerable<T> GetAllService()
        {
            return _baseRepository.GetAll();
        }

        public T GetByIdService(string entityId)
        {
            return _baseRepository.GetById(entityId);
        }

        public int InsertService(T entity)
        {
            // Validating data from request
            // Here...

            // Creating a new entityId
            var props = entity.GetType().GetProperties();
            if (props[0] != null && props[0].CanWrite)
            {
                props[0].SetValue(entity, Guid.NewGuid());
            }

            int rowsEffect = _baseRepository.Insert(entity);

            return rowsEffect;
        }

        public int UpdateByIdService(T entity, Guid entityId)
        {
            // Validating data from request
            // Here...

            // Everything is Okay!
            int rowsEffect = _baseRepository.UpdateById(entity, entityId);

            return rowsEffect;
        }

        public int DeleteByIdService(string entityId)
        {
            return _baseRepository.DeleteById(entityId);
        }

        #endregion

        #region Support Methods
        #endregion
    }
}
