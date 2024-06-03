using Microsoft.AspNetCore.Mvc;

namespace Ero.API.Presentation.Controllers
{
    [Route("/tests")]
    public class TestsController: Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Tests is okay");
        }
    }
}
