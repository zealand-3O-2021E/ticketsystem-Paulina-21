using System;

namespace FoodClassLib
{/// <summary>
/// Food class with Id, Name, and Stock values
/// </summary>
    public class Food
    {
        /// <summary>
        /// Food's Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Food's name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Food's quantity in Stock
        /// </summary>
        public int InStock { get; set; }
        /// <summary>
        /// Food's quantity level below which it's low
        /// </summary>
        public int LowLevel { get; set; }

        /// <summary>
        /// basic info about the food
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"This is {Name}'s Id: {Id} \n The quantity in stock is {InStock}, and it's Low Level is {LowLevel}";
        }
    }
}
