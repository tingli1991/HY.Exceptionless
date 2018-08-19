using Microsoft.AspNetCore.Mvc;

namespace Stack.Exceptionless.WebAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/Values"), ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// GET api/values
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var number = 0;
            var number1 = 100 / number;
            return "";
        }
    }
}