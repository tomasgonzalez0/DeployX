using Microsoft.AspNetCore.Mvc;

namespace TeamGitPractice.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MembersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetMembers()
    {
        var members = new[]
        {
            "Tomas Gonzalez Zapata",
            "Daniel Felipe Marin Marin",
            "Carolina Arango Escobar",
            "Carla Juliana Giraldo Camacho",
            "Samuel Cristobal Cuello Duque"
        };
        return Ok(members);
    }

    [HttpGet("count")]
    public IActionResult GetCount()
    {
        return Ok(new { total = 5 });
    }
}