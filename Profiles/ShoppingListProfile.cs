using AutoMapper;
using ShoppingAPI.DTOs;
using ShoppingAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingAPI.Profiles
{
    public class ShoppingListProfile : Profile
    {
        public ShoppingListProfile()
        {
            //Source => Target
            CreateMap<ShoppingList, ShoppingListReadDTO>();
            CreateMap<ShoppingListCreateDTO, ShoppingList>();
            CreateMap<ShoppingListUpdateDTO, ShoppingList>();
        }
    }
}
