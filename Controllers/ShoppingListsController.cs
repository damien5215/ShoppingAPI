using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShoppingAPI.Models;
using ShoppingAPI.Data;

namespace ShoppingAPI.Controllers
{
    [Route("api/shoppinglists")]
    [ApiController]
    public class ShoppingListsController : ControllerBase
    {
        private readonly MockShoppingRepo _repository = new MockShoppingRepo();

        //GET api/shoppinglist
        [HttpGet]
        public ActionResult<IEnumerable<ShoppingList>> GetAllItems()
        {
            var shoppingListItems = _repository.GetFullList();

            return Ok(shoppingListItems);
        
        }

        //GET api/shoppinglist/{id}
        [HttpGet("{id}")]
        public ActionResult <ShoppingList> GetItemById(int id)
        {
            var shoppingListItem = _repository.GetItemById(id);

            return Ok(shoppingListItem);
        }
    }
}
