using Microsoft.EntityFrameworkCore;

namespace BestRestaurant.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public int CuisineId { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public string PhoneNumber { get; set; }
    public int Rating { get; set; }
    public virtual Cuisine Cuisine { get; set; }
  }
}