using Cosmetics.Contracts;
using Cosmetics.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Products
{
    public abstract class Product : IProduct
    {
        private const int MinNameValue = 3;
        private const int MinBrandValue = 2;
        private const int MaxValue = 10;

        private string name;
        private string brand;
        private decimal price;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            set 
            {
                Validator.CheckIfStringLengthIsValid(value, MaxValue, MinNameValue, string.Format("Product name must be between {0} and {1} symbols long!", MinNameValue, MaxValue));
                this.name = value; 
            }
        }

        public string Brand
        {
            get { return this.brand; }
            set
            {
                Validator.CheckIfStringLengthIsValid(value, MaxValue, MinBrandValue, string.Format("Product brand must be between {0} and {1} symbols long!", MinBrandValue, MaxValue));
                this.brand = value; 
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public GenderType Gender { get; protected set; }

        public virtual string Print()
        {
            return this.ToString();
        }

        public override string ToString()
        {

            var result = new StringBuilder();
            result.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            result.AppendLine(string.Format("  * Price: ${0}", this.Price));
            result.AppendLine(string.Format("  * For gender: {0}", this.Gender));

            return result.ToString().TrimEnd();
        }
    }
}
