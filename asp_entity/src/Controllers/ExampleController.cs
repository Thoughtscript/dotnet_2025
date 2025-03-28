using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

    [HttpGet]
    public async Task<IActionResult> SqlExamplesAsync()
    {

        using (var context = new ApplicationDbContext())
        {
            var examples = await context.Examples.ToListAsync();
            return Ok(examples);
        }
    }
}