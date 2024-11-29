// See https://aka.ms/new-console-template for more information
using DecoratorDesignPatternExample;


//Here’s how to create a simple project in .NET, C# Console Application to demonstrate the Decorator Pattern. The Decorator Pattern allows for dynamic behavior extension of objects without modifying their code.

//Scenario:
//We'll implement a basic coffee shop ordering system. The core functionality is a coffee, and decorators (milk, sugar, etc.) add additional functionality (cost and description).


Console.WriteLine("Hello, World!");


// Base coffee
ICoffee myCoffee = new SimpleCoffee();
Console.WriteLine($"{myCoffee.GetDescription()} costs ${myCoffee.GetCost()}");

// Add milk
myCoffee = new MilkDecorator(myCoffee);
Console.WriteLine($"{myCoffee.GetDescription()} costs ${myCoffee.GetCost()}");

// Add sugar
myCoffee = new SugarDecorator(myCoffee);
Console.WriteLine($"{myCoffee.GetDescription()} costs ${myCoffee.GetCost()}");

// Add another sugar
myCoffee = new SugarDecorator(myCoffee);
Console.WriteLine($"{myCoffee.GetDescription()} costs ${myCoffee.GetCost()}");
