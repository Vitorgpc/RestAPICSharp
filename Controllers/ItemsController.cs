using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RestAPI.Entities;
using RestAPI.Repositories;

namespace RestAPI.Controller 
{
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly InMemItemsRepository itemsRepository;

        public ItemsController()
        {
            itemsRepository = new InMemItemsRepository();
        }

        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            var items = itemsRepository.GetItems();

            return items;
        }

        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {
            var item = itemsRepository.GetItem(id);

            if (item is null)
            {
                return NotFound();
            }

            return item;
        }
    }
}