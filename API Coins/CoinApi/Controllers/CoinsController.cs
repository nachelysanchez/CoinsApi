using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoinApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CoinsController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

     private Contexto _companyContext;

        public CoinsController(Contexto companyContext)
        {
            _companyContext = companyContext;
        }
    /*private readonly ILogger<CoinsController> _logger;
    private readonly Contexto contexto;

    public CoinsController(ILogger<CoinsController> logger, Contexto _contexto)
    {
        _logger = logger;
        _contexto = contexto;
    }*/

    [HttpGet(Name = "GetCoins")]
    public IEnumerable<Coins> Get()
    {
        return _companyContext.Coins;
    }
}
