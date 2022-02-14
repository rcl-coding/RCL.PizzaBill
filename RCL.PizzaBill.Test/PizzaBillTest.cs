using Microsoft.VisualStudio.TestTools.UnitTesting;
using RCL.PizzaBill.Core;

namespace RCL.PizzaBill.Test
{
    [TestClass]
    public class PizzaBillTest
    {
        private readonly PizzaFactory _pizzaFactory;

        public PizzaBillTest()
        {
            _pizzaFactory = new PizzaFactory();
        }

        [TestMethod]
        public void SmallPizzaTest()
        {
            IPizza smallPizza = _pizzaFactory.Create("Small");
            PizzaBillCalculator billCalculator = new PizzaBillCalculator(smallPizza);
            decimal payment = billCalculator.CalculatePayment(3);
            Assert.AreEqual(51.75M, payment);
        }

        [TestMethod]
        public void RegularPizzaTest()
        {
            IPizza regularPizza = _pizzaFactory.Create("Regular");
            PizzaBillCalculator billCalculator = new PizzaBillCalculator(regularPizza);
            decimal payment = billCalculator.CalculatePayment(3);
            Assert.AreEqual(87.86M, payment);
        }
    }
}
