using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingAPI.Models;

namespace ShoppingAPI.Data
{
    public class ShoppingRepo : IShoppingRepo
    {
        private readonly ShoppingListContext _context;

        public ShoppingRepo(ShoppingListContext context)
        {
            _context = context;
        }

        public IEnumerable<ShoppingList> GetFullList()
        {
            return _context.ShoppingLists.ToList();
        }

        public ShoppingList GetItemById(int id)
        {
            return _context.ShoppingLists
            .Where(b => b.Id == id)
            .FirstOrDefault();
        }

        public void CreateShoppingList(ShoppingList shoppingList)
        {
            if (shoppingList == null)
            {
                throw new ArgumentNullException(nameof(shoppingList));
            }

            _context.ShoppingLists.Add(shoppingList);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateShoppingList(ShoppingList shoppingList)
        {
            // Nothing!
        }

        public void DeleteShoppingList(ShoppingList shoppingList)
        {
            if (shoppingList == null)
            {
                throw new ArgumentNullException(nameof(shoppingList));
            }

            _context.ShoppingLists.Remove(shoppingList);
        }
    }
}
