namespace RefactorIfStatements
{
    using System;

    /// <summary>
    /// Class for refactoring
    /// </summary>
    public class RefactorIfStatements
    {
        /// <summary>
        /// Main method
        /// </summary>
        public static void Main()
        {
            // Task1
            Potato potato = new Potato();

            // ... 
            if (potato == null)
            {
                throw new ArgumentNullException("Potato cannot be null");
            }
            else
            {
                if (potato.IsPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }

            // Task2
            const int MinX = 0;
            const int MaxX = 100;
            const int MinY = 0;
            const int MaxY = 100;
            bool isVisitedCell = false;

            int x = 0;
            int y = 0;
            
            bool isXInRange = x >= MinX && x <= MaxX;
            bool isYInRange = MinY >= y && y <= MaxY;

            if (isXInRange && isYInRange && isVisitedCell)
            {
                VisitCell();
            }
        }

        /// <summary>
        /// Method for cooking.
        /// </summary>
        /// <param name="potato">Potato for cooking</param>
        private static void Cook(Potato potato)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Method to check visiting
        /// </summary>
        private static void VisitCell()
        {
            throw new NotImplementedException();
        }
    }
}
