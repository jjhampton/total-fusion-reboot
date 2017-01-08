using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace demo
{
    [Route("api/menu")]
    [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true, Duration = -1)]
    public class MenuController : Controller
    {
        [HttpGet]
        public IEnumerable<MenuItem> GetMenu()
        {
            return new List<MenuItem>
            {
                new MenuItem
                {
                    Name = "Spring Rolls",
                    Price = 4.00,
                    Description = "Delicious Vietnamese spring rolls prepared in the traditional style.  Contains mixture of pork, shrimp, and crab meat and served with hoisin peanut sauce.",
                    Category = "Appetizers"
                },
                new MenuItem
                {
                    Name = "Pho Soup",
                    Price = 4.25,
                    Description = "Traditional Vietnamese soup served with rice noodles, variety of herbs, beef, chicken, green and white onions, and lime wedges.",
                    Category = "Soups"
                },
                new MenuItem
                {
                    Name = "Jaegerschnitzel",
                    Price = 7.00,
                    Description = "A German favorite - pork filet, thin-pounded and coated with breadcrumbs, then deep-fried and served with a hearty mushroom sauce.",
                    Category = "Entrees"
                },

            };
        }
    }

    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }
}