using System.Collections.Generic;

namespace shoppinglistapi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ShoppingList> ShoppingLists { get; set; }
    }
}