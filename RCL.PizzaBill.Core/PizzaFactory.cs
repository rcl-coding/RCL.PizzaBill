namespace RCL.PizzaBill.Core
{
    /// <summary>
    /// Creates an <see cref="IPizza"/> based on the pizza size
    /// </summary>
    public class PizzaFactory
    {
        /// <summary>
        /// Creates an <see cref="IPizza"/> based on size
        /// </summary>
        /// <param name="size">The size of the pizza</param>
        /// <returns>An <see cref="IPizza"/> instance </returns>
        public IPizza Create(string size)
        {
            if (size == "Small")
            {
                return new SmallPizza();
            }
            else if (size == "Regular")
            {
                return new RegularPizza();
            }
            else
            {
                return null;
            }
        }
    }
}
