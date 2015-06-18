using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cosmetics.Products
{
    public class ShoppingCart : IShoppingCart
    {
        private ICollection<IProduct> productsInCard;

        public ShoppingCart()
        {
            this.productsInCard = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            this.productsInCard.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.productsInCard.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            return this.productsInCard.Contains(product);
        }

        public decimal TotalPrice()
        {
            decimal totalPrice = 0;
            foreach (var product in productsInCard)
            {
                totalPrice += product.Price;
            }

            return totalPrice;
        }
    }
}
