namespace ClassChef
{
    using System;

    /// <summary>
    /// Class for the Chef
    /// </summary>
    public class Chef
    {
        /// <summary>
        /// Class for cooking
        /// </summary>
        public void Cook()
        {
            Bowl bowl = this.GetBowl();

            Potato potato = this.GetPotato();
            this.Peel(potato);
            this.Cut(potato);
            bowl.Add(potato);

            Carrot carrot = this.GetCarrot();
            this.Peel(carrot);
            this.Cut(carrot);
            bowl.Add(carrot);
        }
        
        /// <summary>
        /// Class for getting a bowl.
        /// </summary>
        /// <returns>Return new bowl.</returns>
        private Bowl GetBowl()
        {
            throw new NotImplementedException("TODO");
        }

        /// <summary>
        /// Class for getting a carrot.
        /// </summary>
        /// <returns>Return new carrot.</returns>
        private Carrot GetCarrot()
        {
            throw new NotImplementedException("TODO");
        }

        /// <summary>
        /// Class for getting a potato.
        /// </summary>
        /// <returns>Return new potato.</returns>
        private Potato GetPotato()
        {
            throw new NotImplementedException("TODO");
        }

        /// <summary>
        /// Class for cutting vegetables.
        /// </summary>
        /// <param name="vegetable">Vegetable for cutting.</param>
        private void Cut(Vegetable vegetable)
        {
            // ...
        }

        /// <summary>
        /// Class for peeling vegetables.
        /// </summary>
        /// <param name="vegetable">Vegetable for peeling.</param>
        private void Peel(Vegetable vegetable)
        {
            // ...
        } 
    }
}
