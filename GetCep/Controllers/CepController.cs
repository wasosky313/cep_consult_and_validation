using GetCep.Models;
using GetCep.Services;
using Microsoft.AspNetCore.Mvc;

namespace GetCep.Controllers;

[ApiController]
[Route("cep")]
public class GetCepController : ControllerBase
{
    // TODO see de abstract dependency injection (Savon)
    private readonly GetCepService _cepService;
    
    public GetCepController(GetCepService cepService)
    {
        _cepService = cepService;
    }

    [HttpGet("{number}", Name = "GetCep")]
    public async Task<ActionResult<CepResponse>> GetCep(string number)
    {
        var cep = await _cepService.GetCepAsync(number);
        if (cep == null) return NotFound("CEP not found");
        return Ok(cep);
    }
} 