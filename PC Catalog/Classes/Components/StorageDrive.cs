namespace PC_Catalog.Classes.Components
{
    using System;

    class StorageDrive : Component
    {
        public StorageDrive(string name, double price)
            : base(name, null, price)
        {
        }

        public StorageDrive(string name, string details, double price)
            : base(name, details, price)
        {
        }
    }
}
