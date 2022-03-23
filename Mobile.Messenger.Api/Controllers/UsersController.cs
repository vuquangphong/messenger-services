using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mobile.Messenger.Core.Entities;
using Mobile.Messenger.Core.Interfaces.Services;

namespace Mobile.Messenger.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsersController : BaseMessengerController<User>
    {
        #region Dependency Injection

        private readonly IUserService _userService;

        public UsersController(IUserService userService) : base(userService)
        {
            _userService = userService;
        }

        #endregion
    }
}
