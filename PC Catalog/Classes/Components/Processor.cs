namespace PC_Catalog.Classes.Components
{
    using System;

    class Processor : Component
    {
        public Processor(string name, double price)
            : base(name, null, price)
        {
        }

        public Processor(string name, string details, double price)
            : base(name, details, price)
        {
        }
    }
}
