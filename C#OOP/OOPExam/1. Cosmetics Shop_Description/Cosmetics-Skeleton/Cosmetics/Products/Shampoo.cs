using Cosmetics.Common;
using Cosmetics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public class Shampoo : Product, IShampoo, IProduct
    {

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base (name, brand, price, gender)
        {
            this.Price = price * milliliters;
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public uint Milliliters { get; private set; }

        public Common.UsageType Usage { get; private set; }

        public override string Print()
        {
            return this.ToString();
        }

        public override string ToString()
        {
            // * Quantity: {product quantity} ml (when applicable)
            // * Usage: EveryDay/Medical (when applicable)
            var result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine(string.Format("  * Quantity: {0} ml", this.Milliliters));
            result.AppendLine(string.Format("  * Usage: {0}", this.Usage));

            return result.ToString().TrimEnd();
        }
    }
}
