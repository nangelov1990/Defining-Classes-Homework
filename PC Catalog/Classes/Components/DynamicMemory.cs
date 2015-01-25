namespace PC_Catalog.Classes.Components
{
    using System;

    class DynamicMemory : Component
    {
        public DynamicMemory(string name, double price)
            : base(name, null, price)
        {
        }

        public DynamicMemory(string name, string details, double price)
            : base(name, details, price)
        {
        }
    }
}
