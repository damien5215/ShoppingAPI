using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingAPI.Models;

namespace ShoppingAPI.Data
{
    public class MockShoppingRepo : IShoppingRepo
    {
        public IEnumerable<ShoppingList> CreateList() 
        {
            List<ShoppingList> listOfItems = new List<ShoppingList>();

            listOfItems.Add(new ShoppingList
            {
                Id = 0,
                ProductName = "Bread",
                Price = 1.10M,
                Quantity = 1,
                ShopName = "Sainsburies"
            });

            listOfItems.Add(new ShoppingList
            {
                Id = 1,
                ProductName = "Milk",
                Price = 1.00M,
                Quantity = 2,
                ShopName = "M+S"
            });

            listOfItems.Add(new ShoppingList
            {
                Id = 2,
                ProductName = "Pancakes",
                Price = 1.25M,
                Quantity = 2,
                ShopName = "M+S"
            });

            listOfItems.Add(new ShoppingList
            {
                Id = 3,
                ProductName = "Soap",
                Price = 1.00M,
                Quantity = 1,
                ShopName = "CostCo"
            });

            return listOfItems;
        }

        public IEnumerable<ShoppingList> GetFullList()
        {
            var list = CreateList();
            
            return list;
        }

        public ShoppingList GetItemById(int id)
        {
            var list = CreateList();

            return list
                .Where(b => b.Id == id)
                .FirstOrDefault();
        }
    }
}
