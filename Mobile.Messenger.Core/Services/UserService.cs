using Mobile.Messenger.Core.Entities;
using Mobile.Messenger.Core.Interfaces.Infrastructure;
using Mobile.Messenger.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.Messenger.Core.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        #region Dependency Injection

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;
        }

        #endregion
    }
}
