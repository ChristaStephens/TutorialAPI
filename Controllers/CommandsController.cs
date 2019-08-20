using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TutorialAPI.Controllers
{
    //Commands Controller is a class that inherits from Controller base
    //ControllerBase is a basic class for an MVC controller without a view.
    public class CommandsController : ControllerBase
    {
        //Create an action result, maps to our crud methods and swagger
       // an endpoint that will return a string
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetString()
        {
            return new string [] {"this", "is", "a", "placeholder"};
        }
    }
}
