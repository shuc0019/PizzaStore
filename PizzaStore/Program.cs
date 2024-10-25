using System;
using PizzaStore;

class Program
{
    public static void Main(string[] args)
    {
        // pizza objects
        Pizza margarita = new Pizza("Margarita", "Cheese", 45);
        Pizza saladPizza = new Pizza("Salad Pizza", "Salad, Kebab, Dressing", 65);
        Pizza pepperoni = new Pizza("Pepperoni", "Pepperoni, Cheese", 55);

        // customer objects
        Customer customer1 = new Customer(1, "Alisa", 80706022);
        Customer customer2 = new Customer(1, "lisa", 40706022);
        Customer customer3 = new Customer(1, "Alisson", 20706022);


        // Order objects each with a different pizza
        Order order1 = new Order(1, customer1, margarita);
        Order order2 = new Order(2, customer2, saladPizza);
        Order order3 = new Order(3, customer3, pepperoni);


        Console.WriteLine(order1);
        Console.WriteLine(order2);
        Console.WriteLine(order3);

        Console.WriteLine("Total Price of Margarita: " + order1.Pizza.CalculateTotalPrice());
        Console.WriteLine("Total Price of Salad Pizza: " + order2.Pizza.CalculateTotalPrice());
        Console.WriteLine("Total Price of Pepperoni: " + order3.Pizza.CalculateTotalPrice());
    }
}
