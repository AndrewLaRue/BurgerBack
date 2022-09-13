using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BurgerBack.Models;
using BurgerBack.Services;
using Microsoft.AspNetCore.Mvc;

namespace BurgerBack.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BurgersController : ControllerBase
  {
    private readonly BurgersService _burgersService;

    public BurgersController(BurgersService burgersService)
    {
      _burgersService = burgersService;
    }

    [HttpGet]
    public ActionResult<List<Burger>> GetBurgers()
    {
      try
      {
        List<Burger> burgers = _burgersService.GetBurgers();
        return Ok(burgers);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }





  }
}