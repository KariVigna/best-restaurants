using System.Collections.Generic;
using MySqlConnector;

namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public string Description { get; set; }
    public int RestaurantId { get; set; }
    public int  CuisineId { get; set; }
    public Cuisine Cuisine { get; set; }
  }
}