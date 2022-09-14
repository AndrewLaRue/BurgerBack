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
    // SECTION create 
    internal Burger CreateBurger(Burger body)
    {
      // NOTE this is a today thing
      body.Id = Db.Burgers.Count + 1;
      Db.Burgers.Add(body);
      return body;
    }

    // SECTION get all
    internal List<Burger> GetBurgers()
    {
      return Db.Burgers;
    }

    // SECTION get by id
    internal Burger GetBurgerById(int id)
    {

      Burger burger = Db.Burgers.Find(b => b.Id == id);
      if (burger != null)
      {
        return burger;
      }
      throw new Exception("No burger with that id");
    }

    // SECTION update(edit)
    internal Burger UpdatedBurger(Burger update)
    {
      Burger original = GetBurgerById(update.Id);
      original.Name = update.Name != null ? update.Name : original.Name;
      original.Price = update.Price ?? original.Price;
      original.Patties = update.Patties ?? original.Patties;

      return original;
    }

    // SECTION delete check this first
    internal string DeleteBurger(int id)
    {
      Burger burger = GetBurgerById(id);
      Db.Burgers.Remove(burger);
      return $"{burger.name} was deleted";
    }

  }
}