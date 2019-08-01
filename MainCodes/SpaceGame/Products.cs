

using System.Dynamic;
using static SpaceGame.Enumerations;

namespace SpaceGame
{
    /// <summary>
    /// This class represents the products available to the player
    /// </summary>
    public class Product
    {
        public ProductTypes ProductType { get; set; }
        public int Price { get; set; }
        
        
    }
}