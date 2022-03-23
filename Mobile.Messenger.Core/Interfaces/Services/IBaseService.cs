using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Messenger.Core.Interfaces.Services
{
    public interface IBaseService<T>
    {
        public IEnumerable<T> GetAllService();

        public T GetByIdService(string entityId);

        public int InsertService(T entity);

        public int UpdateByIdService(T entity, Guid entityId);

        public int DeleteByIdService(string entityId);
    }
}
