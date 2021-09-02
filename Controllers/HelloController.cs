using Microsoft.AspNetCore.Mvc;


namespace DojoSurvey.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("form")]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost("results")]
        public IActionResult sendData(string Name, string Location, string Language, string Comments)
        {
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comments = Comments;
            return View ("results");
        }
    }
}