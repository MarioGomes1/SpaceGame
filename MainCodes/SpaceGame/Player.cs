using System;
using System.Collections;
using System.Collections.Generic;
using static SpaceGame.Enumerations;

namespace SpaceGame
{
    public class Player
    {
        public Player()
        {
            this.ProductList = new List<Product>();
        }
        /// <summary>
        /// Player constructor sets number of tokens
        /// Instantiates ProductList and adds a water product
        /// </summary>
        /// <param name="tokens"></param>
        public Player(int tokens)
        {
            this.Tokens = tokens;
            this.ProductList = new List<Product>();
            //Product product = new Product {ProductType = ProductTypes.Water, Price = 50};
            Product product = new Product(); 
            product.Price = 50;
            product.ProductType = ProductTypes.Water;
            this.ProductList.Add(product);
        }
        public int Tokens { get; set; }
        public List<Product> ProductList { get; set; }

        public bool Buy(Product product)
        {
            if (this.Tokens>product.Price)
            { 
                this.Tokens -= product.Price;
                this.ProductList.Add(product);
                return true;
            }

            return false;
        }
    }
}