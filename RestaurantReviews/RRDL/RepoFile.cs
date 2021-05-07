using System.Collections.Generic;
using RRModels;
using System.IO;// for File IO
using System.Text.Json;//used for json serialization and unmarshalling
using System.Linq;
using System;
namespace RRDL
{
    
    public class RepoFile : IRepository
    {
        private const string filePath = "../RRDL/Restaurants.json";
        private string jsonString;

        public Restaurant AddRestaurant(Restaurant restaurant)
        {
            List<Restaurant> restaurantFromFile = GetAllRestaurants();
            restaurantFromFile.Add(restaurant);
            jsonString = JsonSerializer.Serialize(restaurantFromFile);
            File.WriteAllText(filePath, jsonString);
            return restaurant;
        }

        public List<Restaurant> GetAllRestaurants()
        {
            try
            {
                jsonString = File.ReadAllText(filePath);
            }
            catch(Exception)
            {
            return new List<Restaurant>();
            }
            jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Restaurant>>(jsonString);
        }

        public Restaurant getRestaurant(Restaurant restaurant)
        {
            return GetAllRestaurants().FirstOrDefault(resto => resto.Equals(restaurant));
        }
    }

}