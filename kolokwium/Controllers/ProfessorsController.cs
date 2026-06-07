using kolokwium.Services;
using Microsoft.AspNetCore.Mvc;

namespace kolokwium.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProfessorsController
{
    private readonly IDbService _dbService;

    public ProfessorsController(IDbService dbService)
    {
        _dbService = dbService;
    }
    
    // [HttpGet("{id}")]
    // public async Task<IActionResult> GetProfessors([FromQuery] string lastName)
    // {
    //   
    // }
}