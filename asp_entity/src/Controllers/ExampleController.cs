using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using src.Models;

namespace src.Controllers;

public class ExampleController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ExampleController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // Automatic sub-path
    // GET: /Example/SimpleString
    public string SimpleString()
    {
        return "Simple String response...";
    }

    [HttpGet]
    public IActionResult JsonResponse()
    {
        var response = new
        {
            Id = 1,
            Msg = "Test Message",
            Num = 999
        };

        return Ok(response);
    }
}
