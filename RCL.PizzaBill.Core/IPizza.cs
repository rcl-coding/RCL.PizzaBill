namespace RCL.PizzaBill.Core
{
    /// <summary>
    /// Represents a pizza
    /// </summary>
    public interface IPizza
    {
        /// <summary>
        /// Calculates the cost of the pizza
        /// </summary>
        /// <param name="numberIngredients">The number of ingredients on the pizza</param>
        /// <returns>A decimal value representing the cost of the pizza</returns>
        decimal CalculateCost(int numberIngredients);
    }
}
