using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BurgerBack.Models;
using BurgerBack.Repositories;

namespace BurgerBack.Services
{
  public class BurgersService
  {
    private readonly BurgersRepository _burgerRepo;

    public BurgersService(BurgersRepository burgerRepo)
    {
      _burgerRepo = burgerRepo;
    }

    internal List<Burger> GetBurgers()
    {
      List<Burger> burgers = _burgerRepo.GetBurgers();
      return burgers;
    }
  }
}