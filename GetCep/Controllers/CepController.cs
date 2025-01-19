using GetCep.Services;
using Microsoft.AspNetCore.Mvc;

namespace GetCep.Controllers;

[ApiController]
[Route("cep")]
public class GetCepController : ControllerBase
{
    private readonly GetCepService _cepService;
    
    public GetCepController(GetCepService cepService)
    {
        _cepService = cepService;
    }

    [HttpGet("{number:int}", Name = "GetCep")]
    public ActionResult<int> GetCep(int number)
    {
        var cep = _cepService.GetCep(number);
        return Ok(cep);
    }
} 