using Dapper;
using Mobile.Messenger.Core.Interfaces.Infrastructure;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Messenger.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>
    {
        #region Support Things

        private readonly string _entityName = typeof(T).Name;

        protected MySqlConnection? SqlConnection;
        protected DynamicParameters? DynamicParams;

        protected static MySqlConnection ConnectDatabase()
        {
            string connectionString = "Server=209.209.40.89; Port=19097; Database=Messenger; User Id=root; Password=root1234";

            var sqlConnection = new MySqlConnection(connectionString);

            return sqlConnection;
        }

        #endregion

        #region Main Methods

        public IEnumerable<T> GetAll()
        {
            using (SqlConnection = ConnectDatabase())
            {
                var entities = SqlConnection.Query<T>($"SELECT * FROM {_entityName}");
                return entities;
            }
        }

        public T GetById(string entityId)
        {
            throw new NotImplementedException();
        }

        public int Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public int UpdateById(T entity, Guid entityId)
        {
            throw new NotImplementedException();
        }

        public int DeleteById(string entityId)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
