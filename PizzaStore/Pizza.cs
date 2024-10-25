using System;

namespace PizzaStore
{
    internal class Pizza
    {
        // Instans felt + properties
        public string Title { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }

        // Constructor
        public Pizza(string title, string ingredients, double price)
        {
            Title = title;
            Ingredients = ingredients;
            Price = price;
        }

        // calculate total price + moms
        public double CalculateTotalPrice()
        {
            double tax = 40; // moms
            return Price + tax;
        }

        // ToString method
        public override string ToString()
        {
            return $"Pizza: {Title}, Ingredients: {Ingredients}, Price: {Price:C}";
        }
    }
}
