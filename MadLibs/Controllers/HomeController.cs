using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    
    [Route("/form")]
    public string Form() { return "Form here soon"; }

    [Route("/")]
    public string MadLibs() { return "Funny story here soon"; }
  }
}