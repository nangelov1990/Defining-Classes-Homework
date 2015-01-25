namespace Laptop_Shop
{
    using System;

    class LaptopShop
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop("Preslav", 499.99);
            Laptop laptop2 = new Laptop("Molodetz", 899.99, "Pravetz", "Intel i3 2.4 Ghz", 6, "GeForce", 500, 15.4, new Battery("Li-on", 8));
            Laptop laptop3 = new Laptop("Madara", 599.99, "Peshovtzi", "Intel Atom 1.8 Ghz", 4, null, 320, null, new Battery("Li-on"));

            Laptop[] laptops = new Laptop[] {laptop1, laptop2, laptop3};

            foreach (var laptop in laptops)
            {
                Console.WriteLine(laptop);
            }
        }
    }
}
