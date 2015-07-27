namespace HomeworkVariablesDataExpressionsAndConstants
{
    using System;

    /// <summary>
    /// Class for testing class size. 
    /// </summary>
    public class TestSize
    {
        /// <summary>
        /// Main program for testing.
        /// </summary>
        public static void Main()
        {
            Size figure = new Size(5, 7);
            Size rotatedFigure = Size.GetRotatedSize(figure, 35);

            Console.WriteLine("Figure with width: " + figure.Width + " and height: " + figure.Height);
            Console.WriteLine("Rotated figure with width: " + rotatedFigure.Width + " and height: " + rotatedFigure.Height);
        }
    }
}
