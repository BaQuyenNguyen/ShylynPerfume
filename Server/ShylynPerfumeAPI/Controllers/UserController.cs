using Microsoft.AspNetCore.Mvc;

namespace ShylynPerfumeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
