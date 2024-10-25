using System;

namespace PizzaStore
{
    internal class Customer
    {
        // Instans felt + properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }

        // Constructor
        public Customer(int id, string name, int phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }

        // ToString method
        public override string ToString()
        {
            return $"Customer ID: {Id}, Name: {Name}, Phone: {Phone}";
        }
    }
}
