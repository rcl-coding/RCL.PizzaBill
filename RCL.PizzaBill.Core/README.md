# A library to calculate the bill for a pizza order

## Usage

Create either a Small or Regular Pizza by using the  ``PizzaFactory`` class. The ``Create`` method will take a string parameter of argument of either : ``Small`` or ``Regular`` to represent the size of the pizza. See the example below:

```csharp
  IPizza smallPizza = _pizzaFactory.Create("Small");
```

Create an object from the ``PizzaBillCalculator`` class to calculate the cost of the pizza. In the constructor of the class, add the object created from the ``PizzaFactory`` above. Finally, use the ``CalculatePayment`` method to calculate the bill. The method takes the number of ingredients in the pizza as an argument. See the example below :

```csharp
 PizzaBillCalculator billCalculator = new PizzaBillCalculator(smallPizza);
 decimal payment = billCalculator.CalculatePayment(3);
```

## Example

The example below demonstrates the usage of the library

 ```csharp
// Create a Regular Pizza
IPizza regularPizza = _pizzaFactory.Create("Regular");

// Create a billCalculator object for the Regular Pizza
PizzaBillCalculator billCalculator = new PizzaBillCalculator(regularPizza);

// Calculate the payment for the Regular Pizza based on three (3) ingredients
decimal payment = billCalculator.CalculatePayment(3);
 ```


