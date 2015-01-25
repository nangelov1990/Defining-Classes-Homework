namespace PC_Catalog.Classes.Components
{
    using System;

    class Screen : Component
    {
        public Screen(string name, double price)
            : base(name, null, price)
        {
        }
        
        public Screen(string name, string details, double price)
            : base(name, details, price)
        {
        }
    }
}
