using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers;

public class ErrorsController:ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        return Problem(); // show 500 error
    }
}