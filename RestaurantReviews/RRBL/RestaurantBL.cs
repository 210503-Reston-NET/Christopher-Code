using System.Collections.Generic;
using RRModels;
using RRDL;
namespace RRBL
{
    /// <summary>
    /// Business logic class for the restaurant model
    /// </summary>
    public class RestaurantBL : IRestaurantBL
    {
        // BL classes are in charge of processing/ sanitizing/ further validating data
        // As the name suggests its in charge of processing logic. For example, how does the ordering process
        // work in a store app. 
        // Any logic that is related to accessing the data stored somewhere, should be relegated to the DL 
        private IRepository _repo;
        public RestaurantBL(IRepository repo)
        {
            _repo = repo;
        }
        public Restaurant AddRestaurant(Restaurant restaurant)
        {
            //todo: call a repo method that adds a restaurant
            if(_repo.getRestaurant(restaurant) != null)
            {
                throw new System.Exception("Restaurant already exists D:");
            }
            return _repo.AddRestaurant(restaurant);
        }
        public List<Restaurant> GetAllRestaurants()
        {
            //Note that this method isn't really dependent on any inputs/parameters, I can just directly call the 
            // DL method in charge of getting all restaurants
            return _repo.GetAllRestaurants();
        }
    }
}