using Microsoft.EntityFrameworkCore;
using ShoppingAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingAPI.Data
{
    public class ShoppingListContext : DbContext
    {
        public ShoppingListContext(DbContextOptions<ShoppingListContext> opt) : base(opt)
        {

        }

        public DbSet<ShoppingList> ShoppingLists { get; set; }
    }
}
