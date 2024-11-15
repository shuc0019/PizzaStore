using System;
using PizzaStore;

class Program
{
    
    public static void Main(string[] args)
    {
        Customer c = new Customer();
        Pizza p = new Pizza();


        // Create Pizza objects
        Pizza margarita = new Pizza(1, "Margarita", "Cheese", 45);
        Pizza saladPizza = new Pizza(2, "Salad Pizza", "Salad, Kebab, Dressing", 65);
        Pizza pepperoni = new Pizza(3, "Pepperoni", "Pepperoni, Cheese", 55);

        // tilføj pizzaer
        p.Add(margarita);
        p.Add(saladPizza);
        p.Add(pepperoni);

        // Create Customer objects
        Customer customer1 = new Customer(1, "Alisa", 80706022);
        Customer customer2 = new Customer(2, "Lisa", 40706022);
        Customer customer3 = new Customer(3, "Alisson", 20706022);

        // tilføj customers
        c.Add(customer1);
        c.Add(customer2);
        c.Add(customer3);

        // Tilføj order
        Order order1 = new Order(1, customer1, margarita);
        Order order2 = new Order(2, customer2, saladPizza);
        Order order3 = new Order(3, customer3, pepperoni);

        // Read orders
        Console.WriteLine(order1);
        Console.WriteLine(order2);
        Console.WriteLine(order3);

        // regn totalprisen ud for hver pizza og udskriv dett
        Console.WriteLine("Total Price of Margarita: " + order1.Pizza.CalculateTotalPrice());
        Console.WriteLine("Total Price of Salad Pizza: " + order2.Pizza.CalculateTotalPrice());
        Console.WriteLine("Total Price of Pepperoni: " + order3.Pizza.CalculateTotalPrice());

        // -------------------- CRUD METODER:
        Console.WriteLine("\nCRUD:");

        // opdater kunde
        Console.WriteLine("\nUpdating Customer ID 1...");
        c.UpdateById(1, "Alisa Hansen", 12345678);
        c.ReadById(1);

        // Opdater pizza
        Console.WriteLine("\nUpdating Pizza ID 2...");
        p.UpdateById(2, "Greek Salad Pizza", "Salad, Feta Cheese, Olives, Dressing", 75);
        p.ReadById(2);

        // Fjern kunde
        Console.WriteLine("\nRemoving Customer ID 3...");
        c.RemoveById(3);

        // Fjern pizza
        Console.WriteLine("\nRemoving Pizza ID 3...");
        p.RemoveById(3);

        // Read alle kunder
        Console.WriteLine("\nRemaining Customers:");
        foreach (var customer in c.List)
        {
            Console.WriteLine(customer);
        }

        // Read alle pizzaer
        Console.WriteLine("\nRemaining Pizzas:");
        foreach (var pizza in p.PizzaList)
        {
            Console.WriteLine(pizza);
        }
    }


}