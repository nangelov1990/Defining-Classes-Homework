namespace PC_Catalog.Classes.Components
{
    using System;

    class Motherboard : Component
    {
        public Motherboard(string name, double price)
            : base(name, null, price)
        {
        }

        public Motherboard(string name, string details, double price)
            : base(name, details, price)
        {
        }
    }
}
