using System.ComponentModel.DataAnnotations;


namespace BurgerBack.Models
{
  public class Burger
  {
    internal object name;

    public Burger(string name, int price, int patties, int id)
    {
      Name = name;
      Price = price;
      Patties = patties;
      Id = id;


    }
    // NOTE this is only for while we are using a fake database
    public Burger()
    {

    }




    [MaxLength]
    public string Name { get; set; }
    public int? Price { get; set; }
    public int? Patties { get; set; }
    public int Id { get; set; }
  }
}