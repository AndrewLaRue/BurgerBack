using System.Collections.Generic;
using BurgerBack.Models;

namespace BurgerBack.db
{
  public static class Db
  {
    public static List<Burger> Burgers { get; set; } = new List<Burger>()
    {
      new Burger("Classic", 5, 1, 1),
      new Burger("Special", 8, 2, 2),
      new Burger("Chunky", 15, 3, 3),
    };
  }
}