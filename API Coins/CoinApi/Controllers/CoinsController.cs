using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoinApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CoinsController : ControllerBase
{
    private Contexto _companyContext;

    public CoinsController(Contexto companyContext)
    {
        _companyContext = companyContext;
    }
    

    /*[HttpGet]
    public IEnumerable<Coins> Get()
    {
        return _companyContext.Coins;
    }*/

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Coins>>> GetCoins(){
        var lista = await _companyContext.Coins.ToListAsync();
        return lista;
    }

    [HttpPost]
    public async Task<ActionResult<Coins>> PostCoin(Coins coin){
        try{
            if (coin.MonedaId >= 0){
                if(CoinExiste(coin.MonedaId)){
                    _companyContext.Entry(coin).State = EntityState.Modified;
                    await _companyContext.SaveChangesAsync();
                    return Ok();
                }
                else{
                    _companyContext.Coins.Add(coin);
                    await _companyContext.SaveChangesAsync();
                    return CreatedAtAction("GetCoins", new {id = coin.MonedaId}, coin);
                }
            }
            else{
                return CreatedAtAction("PostAsync", coin);
            }
        }
        catch(Exception){
            throw;
        }
    }

    private bool CoinExiste(int id){
        var existe = _companyContext.Coins.Any(x => x.MonedaId == id);
        return existe;
    }
}
