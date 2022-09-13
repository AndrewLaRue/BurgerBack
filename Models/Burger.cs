using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerBack.Models
{
  public class Burger
  {
    public Burger(string name, int price, int patties, int id)
    {
      Name = name;
      Price = price;
      Patties = patties;
      Id = id;


    }
    public Burger()
    {

    }




    [MaxLength]
    public string Name { get; set; }
    public int Price { get; set; }
    public int Patties { get; set; }
    public int Id { get; set; }
  }
}