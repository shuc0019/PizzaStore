using System;

namespace PizzaStore
{
    internal class Employee
    {
        // Instans felt + properties
        public int Id { get; set; }
        public string Name { get; set; }

        // Constructor
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        // ToString method
        public override string ToString()
        {
            return $"Employee ID: {Id}, Name: {Name}";
        }
    }
}
