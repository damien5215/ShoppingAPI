using ShoppingAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingAPI.Data
{
    public interface IShoppingRepo
    {
        bool SaveChanges();

        IEnumerable<ShoppingList> GetFullList();
        ShoppingList GetItemById(int id);
        void CreateShoppingList(ShoppingList shoppingList);
        void UpdateShoppingList(ShoppingList shoppingList);
    }
}

