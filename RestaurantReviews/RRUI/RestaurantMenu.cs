using System;
using RRModels;
using RRBL;
using System.Collections.Generic;
namespace RRUI
{
    //Sub menu for selecting restraurant data
    public class RestaurantMenu : IMenu
    {
        private IRestaurantBL _restaurantBL;
        private IValidationService _validate;
        public RestaurantMenu(IRestaurantBL restaurantBL, IValidationService Validate)
        {
            _restaurantBL = restaurantBL;
            _validate = Validate;
        }
        public void Start()
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("Welcome to my Restaurant Menu!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[0] View restaurants");
                Console.WriteLine("[1] Create a restaurant");
                Console.WriteLine("[2] Go back");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        ViewRestaurants();
                        break;
                    case "1":
                        AddARestaurant();
                        break;
                    case "2":
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            } while (repeat);
        }

        private void AddARestaurant()
        {
            Console.WriteLine("Enter the details of the restaurant you want to add");
            //Want to make sure the use doesnt input nothing or incorrect input
            //come up with some validation to valid the input I receive
            //Set model specific validation rules within the properties of your models
            //but have a standard validation
            string name = _validate.ValidateString("Enter the restaurant name:");
            string city = _validate.ValidateString("Enter the city where the restaurant is located");
            string state = _validate.ValidateString("Enter the sate where the restaurant is located at");

            Restaurant nRestaurant = new Restaurant(name, city, state);
            
            try{
                Restaurant createdRestaurant = _restaurantBL.AddRestaurant(nRestaurant);
            Console.WriteLine("New restaurant created!");
            Console.WriteLine(createdRestaurant.ToString());
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void ViewRestaurants()
        {
            //TODO: Remove the hardcoded restaurant and refer to a stored restaurant that exists
            List<Restaurant> restaurants = _restaurantBL.GetAllRestaurants();
            if(restaurants.Count == 0) Console.WriteLine("No restaurants D: you should add a few");
            else
            {
                foreach (Restaurant restaurant in restaurants)
                {
                    Console.WriteLine(restaurant.ToString());
                }
            }
            
        }
    }
}