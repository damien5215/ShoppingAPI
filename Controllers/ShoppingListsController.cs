using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShoppingAPI.Models;
using ShoppingAPI.Data;
using AutoMapper;
using ShoppingAPI.DTOs;

namespace ShoppingAPI.Controllers
{
    [Route("api/shoppinglists")]
    [ApiController]
    public class ShoppingListsController : ControllerBase
    {
        private readonly IShoppingRepo _repository;
        private readonly IMapper _mapper;

        public ShoppingListsController(IShoppingRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/shoppinglists
        [HttpGet]
        public ActionResult<IEnumerable<ShoppingListReadDTO>> GetAllItems()
        {
            var shoppingListItems = _repository.GetFullList();

            return Ok(_mapper.Map<IEnumerable<ShoppingListReadDTO>>(shoppingListItems));
        }

        //GET api/shoppinglists/{id}
        [HttpGet("{id}", Name = "GetItemById")]
        public ActionResult<ShoppingListReadDTO> GetItemById(int id)
        {
            var shoppingListItem = _repository.GetItemById(id);

            if (shoppingListItem != null)
            {
                return Ok(_mapper.Map<ShoppingListReadDTO>(shoppingListItem));
            }
            return NotFound();
        }

        //POST api/shoppinglists
        [HttpPost]
        public ActionResult<ShoppingListReadDTO> CreateItem(ShoppingListCreateDTO item)
        {
            var listModel = _mapper.Map<ShoppingList>(item);
            _repository.CreateShoppingList(listModel);
            _repository.SaveChanges();

            var shoppingListReadDto = _mapper.Map<ShoppingListReadDTO>(listModel);

            return CreatedAtRoute(nameof(GetItemById),
                new { Id = shoppingListReadDto.Id },
                shoppingListReadDto);
        }

        //PUT api/shopinglists/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateItem(int id, ShoppingListUpdateDTO shoppingListUpdateDTO) 
        {
            var slModelFromRepo = _repository.GetItemById(id);

            if (slModelFromRepo == null) 
            {
                return NotFound();
            }

            _mapper.Map(shoppingListUpdateDTO, slModelFromRepo);
            _repository.UpdateShoppingList(slModelFromRepo);
            _repository.SaveChanges();

            return NoContent();

        }
    }
}
