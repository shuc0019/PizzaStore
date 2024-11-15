using System;

namespace PizzaStore
{
    public class Pizza
    {

        // Instans felt + properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }

        // Constructor
        public Pizza(int id, string title, string ingredients, double price)
        {
            Id = id;
            Title = title;
            Ingredients = ingredients;
            Price = price;
        }

        //tom constructor
        public Pizza()
        {
           
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
        // Liste over pizzaer
        public  List<Pizza> PizzaList { get; set; } = new List<Pizza>();

        // Tilføj pizza til listen
        public void Add(Pizza pizza)
        {
            if (PizzaList.Exists(x => x.Id == pizza.Id))
            {
                Console.WriteLine($"En pizza med ID {pizza.Id} findes allerede.");
            }
            else
            {
                PizzaList.Add(pizza);
                Console.WriteLine($"Pizza {pizza.Title} added successfully.");
            }
        }

        // Læs den enkelte
        public void ReadById(int id)
        {
            for (int i = 0; i < PizzaList.Count; i++)
            {
                if (PizzaList[i].Id == id)
                {
                    Console.WriteLine($"Pizzaoplysninger: {PizzaList[i]}");
                    return;
                }
            }

            // Pizza med det givne ID blev ikke fundet
            Console.WriteLine($"Pizza med ID {id} blev ikke fundet.");
        }

        public void UpdateById(int id, string newTitle, string newIngredients, double newPrice)
        {
            for (int i = 0; i < PizzaList.Count; i++) // Find pizza
            {
                if (PizzaList[i].Id == id)
                {
                    // Ændre info
                    if (!string.IsNullOrEmpty(newTitle))
                    {
                        PizzaList[i].Title = newTitle;
                    }

                    if (!string.IsNullOrEmpty(newIngredients))
                    {
                        PizzaList[i].Ingredients = newIngredients;
                    }

                    if (newPrice > 0)
                    {
                        PizzaList[i].Price = newPrice;
                    }

                    Console.WriteLine($"Pizza med ID {id} er opdateret.");
                    return;
                }
            }

            Console.WriteLine($"Pizza med ID {id} blev ikke fundet.");
        }

        // Delete
        public void RemoveById(int id)
        {
            int counter = PizzaList.RemoveAll(x => x.Id == id);
            if (counter > 0)
            {
                Console.WriteLine("Pizzaen er fjernet.");
            }
            else
            {
                Console.WriteLine("Pizza med dette ID blev ikke fundet.");
            }
        }

        // List all pizzas
        public void ListAllPizzas()
        {
            if (PizzaList.Count == 0)
            {
                Console.WriteLine("Ingen pizzaer er registreret.");
                return;
            }

            foreach (var pizza in PizzaList)
            {
                Console.WriteLine(pizza);
            }
        }
    }
}
