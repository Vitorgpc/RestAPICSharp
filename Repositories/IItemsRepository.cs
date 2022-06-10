using System;
using System.Collections.Generic;
using RestAPI.Entities;

namespace RestAPI.Repositories 
{
    public interface IItemsRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}