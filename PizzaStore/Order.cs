using System;

namespace PizzaStore
{
    internal class Order
    {
        // Instans felt + properties
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public Pizza Pizza { get; set; }
        public double TotalPrice { get; private set; }

        // Constructor
        public Order(int id, Customer customer, Pizza pizza)
        {
            Id = id;
            Customer = customer;
            Pizza = pizza;
            TotalPrice = pizza.CalculateTotalPrice();
        }

        // ToString method
        public override string ToString()
        {
            return $"Order ID: {Id}, Pizza: {Pizza}, Total Price: {TotalPrice:C}, Customer: {Customer}";
        }
    }
}
