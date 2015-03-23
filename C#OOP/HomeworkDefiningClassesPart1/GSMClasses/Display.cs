namespace GSMClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Display
    {
        // fields
        private float displaySize;
        private int? displayNumberOfColors;

        //constructors

        public Display(float displaySize): this(displaySize, null)
        { 
        }

        public Display(float displaySize, int? displayNumberOfColors)
        {
            this.DisplaySize = displaySize;
            this.DisplayNumberOfColors = displayNumberOfColors;
        }

        //properties
        public float DisplaySize
        {
            get { return this.displaySize; }
            set
            {
                if (value >= 0)
                {
                    this.displaySize = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public int? DisplayNumberOfColors
        {
            get { return this.displayNumberOfColors; }
            set
            {
                if (value >= 0 || value == null)
                {
                    this.displayNumberOfColors = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("------------Display------------");
            result.AppendLine("Display Size: " + this.DisplaySize.ToString() + " '");
            result.AppendLine("Display Number of Colors: " + this.DisplayNumberOfColors.ToString());
            return result.ToString().TrimEnd();
        }
    }
}
