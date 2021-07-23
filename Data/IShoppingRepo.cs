using ShoppingAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingAPI.Data
{
    public interface IShoppingRepo
    {
        IEnumerable<ShoppingList> GetFullList();
        ShoppingList GetItemById(int id);
    }
}
