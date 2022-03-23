using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Messenger.Core.Interfaces.Infrastructure
{
    public interface IBaseRepository<T>
    {
        public IEnumerable<T> GetAll();

        public T GetById(string entityId);

        public int Insert(T entity);

        public int UpdateById(T entity, Guid entityId);

        public int DeleteById(string entityId);
    }
}
