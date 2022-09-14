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

    // SECTION create
    internal Burger CreateBurger(Burger body)
    {
      Burger burger = _burgerRepo.CreateBurger(body);
      return burger;
    }

    // SECTION get all
    internal List<Burger> GetBurgers()
    {
      List<Burger> burgers = _burgerRepo.GetBurgers();
      return burgers;
    }


    // SECTION get by id
    internal Burger GetBurgerById(int id)
    {
      Burger burger = _burgerRepo.GetBurgerById(id);
      return burger;
    }

    // SECTION update(edit)
    internal Burger UpdatedBurger(Burger update)
    {
      return _burgerRepo.UpdatedBurger(update);
    }

    // SECTION delete
    internal string DeleteBurger(int id)
    {
      return _burgerRepo.DeleteBurger(id);
    }


  }
}