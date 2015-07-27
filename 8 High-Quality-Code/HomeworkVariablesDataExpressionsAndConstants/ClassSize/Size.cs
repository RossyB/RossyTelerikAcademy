namespace HomeworkVariablesDataExpressionsAndConstants
{
    using System;

    /// <summary>
    /// Class Size
    /// </summary>
    internal class Size
    {
        /// <summary>
        /// Holds the width
        /// </summary>
        private double width;

        /// <summary>
        /// Holds the height
        /// </summary>
        private double height;

        /// <summary>
        /// Initializes a new instance of the Size class.
        /// </summary>
        /// <param name="width">Holds the width</param>
        /// <param name="height">Holds the height</param>
        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        /// <summary>
        /// Gets object's width
        /// </summary>
        public double Width 
        {
            get 
            { 
                return this.width; 
            }

            private set 
            { 
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be les than zero");
                }

                this.width = value; 
            }
        }

        /// <summary>
        /// Gets object's height
        /// </summary>
        public double Height
        {
            get 
            { 
                return this.height; 
            }

            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be les than zero");
                }

                this.height = value; 
            }
        }

        /// <summary>
        /// Gets the rotated size of a figure
        /// </summary>
        /// <param name="size">Size to be rotated.</param>
        /// <param name="angleOfrotation">angle of rotation</param>
        /// <returns>The calculated newSize of the rotated object</returns>
        public static Size GetRotatedSize(Size size, double angleOfrotation)
        {
            double newWidth = (Math.Abs(Math.Cos(angleOfrotation)) * size.width) +
                    (Math.Abs(Math.Sin(angleOfrotation)) * size.height);
            double newHeight = (Math.Abs(Math.Sin(angleOfrotation)) * size.width) +
                    (Math.Abs(Math.Cos(angleOfrotation)) * size.height);

            Size rotatedSize = new Size(newWidth, newHeight);

            return rotatedSize;
        }
    }
}
