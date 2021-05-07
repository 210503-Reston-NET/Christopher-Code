using System.Collections.Generic;
using RRModels;
using System.Linq;
namespace RRDL
{
    //Implementation of the IRepository that stores data in a static collection
    public class RepoSC : IRepository
    {
        public List<Restaurant> GetAllRestaurants()
        {
            return RRSCStorage.Restaurants;
        }
        public Restaurant AddRestaurant(Restaurant restaurant)
        {
            RRSCStorage.Restaurants.Add(restaurant);
            return restaurant;
        }
        public Restaurant getRestaurant(Restaurant restaurant)
        {
            // used LINQ(Language Integrated Query) which allows you to query collections to get the neccesary
            // data without having to traverse the collection manually in a for each iteration
            return RRSCStorage.Restaurants.FirstOrDefault(resto => resto.Equals(restaurant));
        }
    }
}