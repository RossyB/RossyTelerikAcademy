using Cosmetics.Contracts;
using Cosmetics.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Category : ICategory
    {
        private const int MinValue = 2;
        private const int MaxValue = 15;

        private ICollection<IProduct> products;

        private string name;

        public Category(string name)
        {
            this.Name = name;
            products = new List<IProduct>();
        }

        public string Name
        {
            get { return this.name; }
            set 
            {
                Validator.CheckIfStringLengthIsValid(value, MaxValue, MinValue, string.Format("Category name must be between {0} and {1} symbols long!", MinValue, MaxValue));
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            products.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            products.Remove(cosmetics);
        }

        public string Print()
        {
           return this.ToString();
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(string.Format("{0} category - {1} {2} in total", this.Name, products.Count, products.Count == 1 ? "product" : "products"));
            var orderProducts = products.OrderBy(p => p.Brand).ThenByDescending(p => p.Price);
            foreach (var product in orderProducts)
            {
                result.AppendLine(product.Print());
            }

            return result.ToString().TrimEnd();
        }
    }
}
