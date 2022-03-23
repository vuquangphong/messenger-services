using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mobile.Messenger.Core.Exceptions;
using Mobile.Messenger.Core.Interfaces.Services;

namespace Mobile.Messenger.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BaseMessengerController<T> : ControllerBase
    {
        #region Dependency Injection

        private readonly IBaseService<T> _baseService;

        public BaseMessengerController(IBaseService<T> baseService)
        {
            _baseService = baseService;
        }

        #endregion

        #region Main Controllers

        // @method: GET /Entities
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var entities = _baseService.GetAllService();

                if (entities == null)
                {
                    return NoContent();
                }
                return Ok(entities);
            }
            catch (Exception ex)
            {
                return CatchException(ex);
            }
        }

        // @method: GET /Entities/{entityId}
        [HttpGet("{entityId}")]
        public IActionResult Get(string entityId)
        {
            try
            {
                var entity = _baseService.GetByIdService(entityId);

                if (entity == null)
                {
                    return NoContent();
                }
                return Ok(entity);
            }
            catch (Exception ex)
            {
                return CatchException(ex);
            }
        }

        // @method: POST /Entities
        [HttpPost]
        public IActionResult Post(T entity)
        {
            try
            {
                var rowsEffect = _baseService.InsertService(entity);

                if (rowsEffect > 0)
                {
                    return StatusCode(201, entity);
                }
                return StatusCode(204);
            }
            catch (ValidateException ex)
            {
                var res = new
                {
                    devMsg = ex.Message,
                    userMsg = ex.Message,
                };
                return BadRequest(res);
            }
            catch (Exception ex)
            {
                return CatchException(ex);
            }
        }

        // @method: PUT /Entities/{entityId}
        [HttpPut("{entityId}")]
        public IActionResult Put(T entity, Guid entityId)
        {
            try
            {
                var rowsEffect = _baseService.UpdateByIdService(entity, entityId);

                if (rowsEffect > 0)
                {
                    return StatusCode(201, rowsEffect);
                }
                return StatusCode(204);
            }
            catch (ValidateException ex)
            {
                var res = new
                {
                    devMsg = ex.Message,
                    userMsg = ex.Message,
                };
                return BadRequest(res);
            }
            catch (Exception ex)
            {
                return CatchException(ex);
            }
        }

        // @method: DELETE /Entities/{entityId}
        [HttpDelete("{entityId}")]
        public IActionResult Delete(string entityId)
        {
            try
            {
                var rowsEffect = _baseService.DeleteByIdService(entityId);

                if (rowsEffect > 0)
                {
                    return Ok(rowsEffect);
                }
                return NoContent();
            }
            catch (Exception ex)
            {
                return CatchException(ex);
            }
        }

        #endregion

        #region Support Methods

        protected IActionResult CatchException(Exception ex)
        {
            var res = new
            {
                devMsg = ex.Message,
                userMsg = Core.Resources.VietnameseResource.UserMsgServerError,
            };

            return StatusCode(500, res);
        }

        #endregion
    }
}
