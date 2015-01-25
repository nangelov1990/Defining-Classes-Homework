namespace PC_Catalog.Classes.Components
{
    using System;

    class GraphicCard : Component
    {
        public GraphicCard(string name, double price)
            : this(name, null, price)
        {
        }

        public GraphicCard(string name, string details, double price)
            : base(name, details, price)
        {
        }
    }
}
