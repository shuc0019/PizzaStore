using System;

namespace PizzaStore
{
    public class Customer
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

        //tom construcor
        public Customer()
        {
            
        }

        // ToString method
        public override string ToString()
        {
            return $"Customer ID: {Id}, Name: {Name}, Phone: {Phone}";
        }

        public List<Customer> List { get; set; } = new List<Customer>();
        public void Add(Customer customer)
        {
            if (List.Exists(x => x.Id == customer.Id))
            {
                Console.WriteLine($"En kunde med ID {customer.Id} findes allerede.");
            }
            else
            {
                List.Add(customer);
                Console.WriteLine($"Customer {customer.Name} added successfully.");
            }
        }
            public void RemoveById(int id)
            {
                int counter = List.RemoveAll(x => x.Id == id);
                if (counter > 0)
                {
                    Console.WriteLine("Kunden er fjernet");

                }
                else
                {
                    Console.WriteLine("Kunde med denne id er ikke fundet");
                }
            }

            public void UpdateById(int id, String nyName, int nyPhone)
            {
                for (int i = 0; i < List.Count; i++) //find kunde
                {
                    if (List[i].Id == id)
                    {
                        //ændre info
                        List[i].Name = nyName;
                        List[i].Phone = nyPhone;

                        Console.WriteLine($"Kunden med ID {id} er opdateret.");
                        return;
                    }
                }

            }

            public void ReadById(int id)
            {

                for (int i = 0; i < List.Count; i++)
                {
                    if (List[i].Id == id)
                    {
                        Console.WriteLine($"Kundeoplysninger: {List[i]}");
                        return;
                    }
                }

                // Kunde med det givne ID blev ikke fundet
                Console.WriteLine($"Kunde med ID {id} blev ikke fundet.");
            }
        }
    }
