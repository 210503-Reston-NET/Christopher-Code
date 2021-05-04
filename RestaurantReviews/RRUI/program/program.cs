using System;
using RRmodels;
namespace RRUI
{
    public class program
    {
        static void Main(string[] args)
        {
            Restaurant goodTaste = new Restaurant("Good Taste", "Baguio City", "Benguet");
            goodTaste.Reviews = new Reviews
            {
                Rating = 5,
                Description = "A M A Z I N G"
            };
            Console.WriteLine(goodTaste.ToString());
        }
    }
}
