using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingAPI.Models;

namespace ShoppingAPI.Data
{
    public class MockShoppingRepo : IShoppingRepo
    {
        public IEnumerable<ShoppingList> GetFullList()
        {
            var listOfItems = new List<ShoppingList>
            {
                new ShoppingList{
                    Id = 0,
                    ProductName = "Bread",
                    Price = 1.10M,
                    Quantity = 1,
                    ShopName = "Sainsburies"
                },
                new ShoppingList{
                    Id = 1,
                    ProductName = "Milk",
                    Price = 1.00M,
                    Quantity = 2,
                    ShopName = "M+S"
                },
                new ShoppingList{
                    Id = 2,
                    ProductName = "Pancakes",
                    Price = 1.25M,
                    Quantity = 2,
                    ShopName = "M+S"
                }

            };
            return listOfItems;
        }

        public ShoppingList GetItemById(int id)
        {
            return new ShoppingList { 
                Id = 12, 
                ProductName = "Soap",
                Price = 1.00M,
                Quantity = 1,
                ShopName = "CostCo"
            };
        }
    }
}
