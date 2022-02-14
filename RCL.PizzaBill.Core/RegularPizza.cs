namespace RCL.PizzaBill.Core
{
    internal class RegularPizza : IPizza
    {
        public decimal CalculateCost(int numberIngredients)
        {
            return 50.00M + ((8.00M * numberIngredients) * 1.10M);
        }
    }
}
