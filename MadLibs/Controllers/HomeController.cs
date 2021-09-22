using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/")]
    public ActionResult MadLibs() { return View(); }
  }
}