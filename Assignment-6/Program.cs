using System;
using System.Collections.Generic;



namespace Assignment_6
{
    public class Program
    {
        public static void Main()
        {
           List<Pizza> pizzaOrders = new List<Pizza>();
            

            pizzaOrders.Add(new Pizza("small", 1, 1, 1));
            pizzaOrders.Add(new Pizza("medium", 2, 1, 0));
            pizzaOrders.Add(new Pizza("large", 3, 2, 2));

            // Display the Pizza records
            foreach (var pizza in pizzaOrders)
            {
                Console.WriteLine(pizza.GetDescription());
                Console.WriteLine("Cost: $" + pizza.CalcCost());
}
        }
    }

        public class Pizza
    {
        // Private instance variables
        private string size;
        private int cheeseToppings;
        private int pepperoniToppings;
        private int hamToppings;

        // Constructor
        public Pizza(string size, int cheeseToppings, int pepperoniToppings, int hamToppings)
        {
            this.size = size;
            this.cheeseToppings = cheeseToppings;
            this.pepperoniToppings = pepperoniToppings;
            this.hamToppings = hamToppings;
        }

        // Getter and Setter methods
        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public int CheeseToppings
        {
            get { return cheeseToppings; }
            set { cheeseToppings = value; }
        }

        public int PepperoniToppings
        {
            get { return pepperoniToppings; }
            set { pepperoniToppings = value; }
        }

        public int HamToppings
        {
            get { return hamToppings; }
            set { hamToppings = value; }
        }

       

        // Method to get the description of the pizza
        public string GetDescription()
        {
            return $"Size: {size}, Cheese Toppings: {cheeseToppings}, Pepperoni Toppings: {pepperoniToppings}, Ham Toppings: {hamToppings}";
        }

        // Method to calculate the cost of the pizza
        public double CalcCost()
        {
            double baseCost = 0;

            switch (size.ToLower())
            {
                case "small":
                    baseCost = 10;
                    break;
                case "medium":
                    baseCost = 12;
                    break;
                case "large":
                    baseCost = 14;
                    break;
            }

            int totalToppings = cheeseToppings + pepperoniToppings + hamToppings;
            double cost = baseCost + (2 * totalToppings);

            return cost;
        }
    }

  }


