using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/")]
    public ActionResult MadLibs(string character)
    {
      FillInTheBlanks usersWords = new FillInTheBlanks();
      usersWords.Character = character;
      return View(usersWords);
    }
  }
}