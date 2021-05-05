namespace RRmodels
{
    public class Reviews
    {

        /// <summary>
        /// This described the numerican value of the rating of the restaurant
        /// </summary>
        /// <value></value>
        public int Rating { get; set; }

        /// <summary>
        /// This described the reasoning for the given Rating value based on experience
        /// </summary>
        /// <value></value>
        public string Description { get; set; }

        public override string ToString()
        {
            return $"\n\t Rating: {Rating} \n\t Description: {Description}";
        }
    }
}