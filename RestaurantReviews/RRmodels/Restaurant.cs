using System;
using System.Collections;
using System.Collections.Generic;
/// <summary>
/// Namespace for the models/custom data dtructuresd involved in Restaurant Reviws
/// </summary>
namespace RRmodels
{
    /// <summary>
    /// data structure used to define a restaurant
    /// </summary>
    public class Restaurant
    {
        //Class Members
        // 1. Constructor - use this to create and instance of the class
        // 2. Fields - Defines the characteristics of a class
        // 3. Methods - Defines the behavior of a class
        // 4. Properties - also known as smart fields, are accesor methods used to access private backing fields
        // *Note that properties are analogous to Java getter and setter
        public Restaurant(string name, string city, string state)
        {
            this.Name = name;
            this.City = city;
            this.State = state;
        }

        public Restaurant()
        {

        }
        /// <summary>
        /// This descriubes the name of your restaurant
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// This described the location of your restaurant
        /// </summary>
        /// <value></value>
        public string City { get; set; }
        
        /// <summary>
        /// This described the location of your restaurant
        /// </summary>
        /// <value></value>
        public string State { get; set; }

        /// <summary>
        /// This described the location of your restaurant
        /// </summary>
        /// <value></value>
        public List<Reviews> Reviews { get; set; }


        public override string ToString()
        {
            return $" Name: {Name} \n Location: {City}, {State}";
        }
    }

}
