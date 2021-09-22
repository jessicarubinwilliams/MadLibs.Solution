using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/")]
    public ActionResult MadLibs(string character, string typeOfPlace, string destination, string aProblem, string adjective1, string adjective2, string activityOrAction, string situationalOutcome)
    {
      FillInTheBlanks usersWords = new FillInTheBlanks();
      usersWords.Character = character;
      usersWords.TypeOfPlace = typeOfPlace;
      usersWords.Destination = destination;
      usersWords.AProblem = aProblem;
      usersWords.Adjective1 = adjective1;
      usersWords.Adjective2 = adjective2;
      usersWords.ActivityOrAction = activityOrAction;
      usersWords.SituationalOutcome = situationalOutcome;

      return View(usersWords);
    }
  }
}