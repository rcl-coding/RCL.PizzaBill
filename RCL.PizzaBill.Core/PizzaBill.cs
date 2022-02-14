namespace RCL.PizzaBill.Core
{
    /// <summary>
    /// Calculates the bill for a pizza
    /// </summary>
    public class PizzaBillCalculator
    {
        private readonly IPizza _pizza;

        public PizzaBillCalculator(IPizza pizza)
        {
            _pizza = pizza;
        }

        /// <summary>
        /// Calculates the payment required for the pizza bill
        /// </summary>
        /// <param name="numberIngredients">The number of ingredients on the pizza</param>
        /// <returns>A decimal value representing the payment required for the pizza</returns>
        public decimal CalculatePayment(int numberIngredients)
        {
            decimal payment = _pizza.CalculateCost(numberIngredients) * 1.15M;
            return Math.Round(payment, 2);
        }
    }
}
