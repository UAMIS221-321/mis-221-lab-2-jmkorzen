// See https://aka.ms/new-console-template for more information
//Inputs
int numberOfSandwiches;
int numberOfToppings;
double tip;
//Constants
const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.1;


Console.WriteLine("How many sandwiches are you ordering?");
numberOfSandwiches = int.Parse(Console.ReadLine());

Console.WriteLine("How many total toppings are you ordering?");
numberOfToppings = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter a tip amount");
tip = double.Parse(Console.ReadLine());

//Processing items
double totalSandwichCost = numberOfSandwiches * COST_OF_SANDWICH;
double totalToppingCost = numberOfToppings * COST_OF_TOPPING;
double baseCost = totalSandwichCost + totalToppingCost;

double orderCost =Math.Round(tip + baseCost*(1-DISCOUNT_AMOUNT),2);

Console.WriteLine("Your order cost is " + orderCost);