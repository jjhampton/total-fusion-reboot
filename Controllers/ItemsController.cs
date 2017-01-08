using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace demo
{
    [Route("api/items")]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true, Duration = -1)]
    public class ItemsController : Controller
    {
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            return new List<Item>
            {
                new Item {Name = "Max Musterman", City = "Naustadt", Dob = new DateTime(1978, 07, 29)},
                new Item {Name = "Maria Musterfrau", City = "London", Dob = new DateTime(1979, 08, 30)},
                new Item {Name = "John Doe", City = "Los Angeles", Dob = new DateTime(1980, 09, 01)}
            };
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public string City { get; set; }
        public DateTime Dob { get; set; }
    }
}