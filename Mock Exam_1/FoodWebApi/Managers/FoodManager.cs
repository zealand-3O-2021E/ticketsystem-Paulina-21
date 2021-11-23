using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodClassLib;

namespace FoodWebApi.Managers
{
    public class FoodManager
    {
        private static int _id = 1;

        public static readonly List<Food> items = new List<Food>
        {
            new Food(){Id = _id++, InStock = 25, LowLevel = 10, Name = "cookies"},
            new Food(){Id = _id++, InStock = 50, LowLevel = 20, Name = "almonds"},
            new Food(){Id = _id++, InStock = 100, LowLevel = 50, Name = "potatoes"},
            new Food(){Id = _id++, InStock = 300, LowLevel = 100, Name = "tea"},
            new Food(){Id = _id++, InStock = 10, LowLevel = 15, Name = "salad"}
        };

        public List<Food> GetAll(string name)
        {
            List<Food> _items = new List<Food>(items);

            if (!String.IsNullOrEmpty(name))
            {
                _items = (_items.FindAll(item => item.Name.StartsWith(name, StringComparison.OrdinalIgnoreCase)));
            }
            return _items;
            // Callers should no get a reference to the Items object, but rather get a copy
        }

        public Food GetById(int id)
        {
            return items.Find(item => item.Id == id);
        }

        public List<Food> GetPurchases()
        {
            List<Food> _items = new List<Food>(items);
            foreach (var VARIABLE in items)
            {
                if(VARIABLE.InStock<=VARIABLE.LowLevel)
                    _items.Add(VARIABLE);
            }

            return _items;
        }

    }
}
