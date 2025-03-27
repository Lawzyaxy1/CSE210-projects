using System;
using System.Collections.Generic;

namespace OrderProcessing
{
    // Address Class
    class Address
    {
        private string street;
        private string city;
        private string state;
        private string country;

        public Address(string street, string city, string state, string country)
        {
            this.street = street;
            this.city = city;
            this.state = state;
            this.country = country;
        }

        public bool IsInUSA()
        {
            return this.country == "USA";
        }

        public string FullAddress()
        {
            return $"{street}\n{city}, {state}\n{country}";
        }
    }

    // Customer Class
    class Customer
    {
        private string name;
        private Address address;

        public Customer(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        public bool IsInUSA()
        {
            return this.address.IsInUSA();
        }

        public string GetName()
        {
            return name;
        }

        public string GetAddress()
        {
            return address.FullAddress();
        }
    }

    // Product Class
    class Product
    {
        private string name;
        private int productId;
        private decimal price;
        private int quantity;

        public Product(string name, int productId, decimal price, int quantity)
        {
            this.name = name;
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
        }

        public decimal TotalCost()
        {
            return price * quantity;
        }

        public string GetName()
        {
            return name;
        }

        public int GetProductId()
        {
            return productId;
        }
    }

    // Order Class
    class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(Customer customer)
        {
            this.products = new List<Product>();
            this.customer = customer;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public decimal CalculateTotal()
        {
            decimal totalCost = 0;
            foreach (var product in products)
            {
                totalCost += product.TotalCost();
            }
            decimal shippingCost = customer.IsInUSA() ? 5 : 35;
            return totalCost + shippingCost;
        }

        public string PackingLabel()
        {
            string label = "";
            foreach (var product in products)
            {
                label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
            }
            return label.TrimEnd();
        }

        public string ShippingLabel()
        {
            return $"Ship to: {customer.GetName()}\n{customer.GetAddress()}";
        }
    }

    // Program class for testing
    class Program
    {
        static void Main(string[] args)
        {
            // Create some addresses
            Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
            Address address2 = new Address("456 Maple Ave", "Vancouver", "BC", "Canada");

            // Create customers
            Customer customer1 = new Customer("Lawrence Manu", address1);
            Customer customer2 = new Customer("Joseph Smith", address2);

            // Create products
            Product product1 = new Product("Laptop", 101, 999.99m, 1);
            Product product2 = new Product("Phone", 102, 499.99m, 2);
            Product product3 = new Product("Headphones", 103, 89.99m, 3);

            // Create orders and add products
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product3);

            // Display order details
            Console.WriteLine("Order 1:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order1.PackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order1.ShippingLabel());
            Console.WriteLine($"Total Price: ${order1.CalculateTotal():F2}\n");

            Console.WriteLine("Order 2:");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order2.PackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order2.ShippingLabel());
            Console.WriteLine($"Total Price: ${order2.CalculateTotal():F2}");
        }
    }
}
