using System;

namespace shoppinglistapi.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int ShoppingListId { get; set; }
    }
}