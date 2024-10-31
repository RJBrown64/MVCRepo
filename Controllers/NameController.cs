using Microsoft.AspNetCore.Mvc;

namespace MVCRJB.Controllers
{
    [Route("api/name")]
    [ApiController]
    public class NameController : Controller
    {
        public IActionResult MyName()
        {
            var res = new { Name = "RJ BROWN"};
            return Ok(res);
        }
    }
}
