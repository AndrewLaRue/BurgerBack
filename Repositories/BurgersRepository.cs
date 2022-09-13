using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BurgerBack.db;
using BurgerBack.Models;

namespace BurgerBack.Repositories
{
  public class BurgersRepository
  {
    internal List<Burger> GetBurgers()
    {
      return Db.Burgers;
    }
  }
}