
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wann_Whiskey
{
    public class Item
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }
        public bool IsConsumable { get; set; }
        public int Quantity { get; set; }

        public Item(string name, string description, int value, bool isConsumable, int quantity)
        {
            Name = name;
            Description = description;
            Value = value;
            IsConsumable = isConsumable;
            Quantity = quantity;
        }
    }
}
