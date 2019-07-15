using System;
using System.Collections.Generic;

namespace shoppinglistapi.Models
{
    public class ShoppingList
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}