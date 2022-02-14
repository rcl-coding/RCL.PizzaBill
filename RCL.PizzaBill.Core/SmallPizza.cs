namespace RCL.PizzaBill.Core
{
    internal class SmallPizza : IPizza
    {
        public decimal CalculateCost(int numberIngredients)
        {
            return 30.00M + (5.00M * numberIngredients);
        }
    }
}
