using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Toothpaste : Product, IToothpaste, IProduct
    {
        private string totalingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.totalingredients = string.Join(", ", ingredients);
        }

        public string Ingredients
        {
            get { return this.totalingredients; }
        }

        public override string Print()
        {
            return this.ToString();
        }

        public override string ToString()
        {
            // * Ingredients: {product ingredients, separated by “, “} (when applicable)
            var result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine(string.Format("  * Ingredients: {0}", this.totalingredients));

            return result.ToString().TrimEnd();
        }
    }
}
