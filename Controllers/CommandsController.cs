using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TutorialAPI.Controllers
{
    //Commands Controller is a class that inherits from Controller base
    //ControllerBase is a basic class for an MVC controller without a view.
    //need to decorate the controller with [ApiController] so that the MVC
    //framework can recognize it as a controller class
    //we also need to give it a route (like a path)
    //so that we know where to call the method. Think of a url.
    //you can use [controller] or the first name of the controller folder in lowercase
    //just remember to use that when typing the path into postman/google
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        //Create an action result, maps to our crud methods and swagger
        // an endpoint that will return a string
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetString()
        {
            return new string[] { "this", "is", "a", "placeholder" };
        }
    }
}
