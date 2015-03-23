namespace GSMClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class GSM
    {
        //fields
        private string model;
        private string manifacturer;
        private float? price;
        private string owner;
        public Battery Battery = new Battery("1234SR", BatteryTypes.LiIon, null, null);
        public Display Display = new Display(0, null);

        static private GSM iphone4s = new GSM("IPhone", "Apple", 1209.80f);

        private List<Call> callHistory = new List<Call>();

        public static GSM Iphone4s
        {
            get { return iphone4s; }
        }

        //constructors
        public GSM(string model, string manifacturer)
            : this(model, manifacturer, null)
        {
        }

        public GSM(string model, string manifacturer, float? price)
            : this(model, manifacturer, price, null)
        {
        }

        public GSM(string model, string manifacturer, float? price, string owner) 
            : this(model, manifacturer, price, owner, null, null)
        { 
        }

        public GSM(string model, string manifacturer, float? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manifacturer = manifacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        //properties
        public string Model
        {
            get { return this.model; }
            set
            {
                if (value.Length >= 0)
                {
                    this.model = value;
                }

                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string Manifacturer
        {
            get { return this.manifacturer; }
            set
            {
                if (value.Length >= 0)
                {
                    this.manifacturer = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public float? Price
        {
            get { return this.price; }
            set
            {
                if (value == null || value >= 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value == null || value.Length >= 0)
                {
                    this.owner = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }

        public void AddCall(string dialledPhoneNumber, int duration)
        {
            DateTime callDateTime = DateTime.Now;
            callHistory.Add(new Call(callDateTime, dialledPhoneNumber, duration));
        }

        public void DeleteCall(int index)
        {
            this.callHistory.RemoveAt(index);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public decimal CalculateTotalCallPrice(decimal price)
        {
            decimal totalPrice = 0;
            foreach (var call in callHistory)
            {
                double minutes = TimeSpan.FromSeconds(call.Duration).TotalMinutes; // converting seconds to minutes
                totalPrice += (decimal)minutes * price; // multiplying minutes by price
            }
            return totalPrice;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine();
            result.AppendLine("--------------GSM--------------");
            result.AppendLine("Model: " + this.model);
            result.AppendLine("Manifacturer: " + this.manifacturer);
            result.AppendLine("Price: " + this.price.ToString() + " lv");
            result.AppendLine("Owner: " + this.owner);
            result.AppendLine(this.Battery.ToString());
            result.AppendLine(this.Display.ToString());

            return result.ToString().TrimEnd();
        }
    }
}
