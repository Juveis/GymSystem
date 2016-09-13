using System;

namespace Core.Entities.Inventory
{
    public class StockType
    {
        
        public StockType()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
