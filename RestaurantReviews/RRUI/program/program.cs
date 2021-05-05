using System;
using System.Collections;
using System.Collections.Generic;
using RRmodels;

namespace RRUI
{
    public class program
    {
        static void Main(string[] args)
        {
            //TODO: remove hardcoded restaurant
            IMenu menu = new MainMenu();
            menu.Start();
            //Restaurant goodTaste = new Restaurant("Good Taste", "Baguio City", "Benguet");
            //goodTaste.Reviews = new Reviews
            //{
            //    new Reviews
            //    {
            //        Rating = 5,
            //        Description = "A M A Z I N G"
            //    },
            //    new Reviews
            //    {
            //        Rating = 7,
            //        Description = "Good food for me."
           //     }
           //     
           // };
           // Console.WriteLine(goodTaste.ToString());
           // foreach(Reviews review1 in goodTaste.Reviews)
           // {
          //      Console.Write(goodTaste.ToString());
          //  } 
        }
    }
}
