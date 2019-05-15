using attendance.objects.Contracts.Business;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace attendance.api.Controllers
{
    public class BaseController<TRequest, TModel> : ControllerBase
    {
        protected IBaseBusiness<TRequest, TModel> business;

        public BaseController(IBaseBusiness<TRequest, TModel> business)
        {
            this.business = business;
        }

        [HttpGet]
        public async Task<ActionResult> Get([FromQuery] TRequest request)
        {
            var result = await business.Find(request);

            if (result != null)
            {
                return new JsonResult(result);
            }

            return new NotFoundResult();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var result = await business.Get(id);

            if (result != null)
            {
                return new JsonResult(result);
            }

            return new NotFoundResult();
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] TModel model)
        {
            var result = await business.Save(model);

            if (result != null)
            {
                return new JsonResult(result);
            }

            return new NotFoundResult();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await business.Delete(id);
            return new JsonResult(result);
        }
    }
}
