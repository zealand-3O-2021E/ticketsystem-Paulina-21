using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodClassLib;
using FoodWebApi.Managers;

namespace FoodWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController: ControllerBase
    {
        private FoodManager _manager=new FoodManager();

        [HttpGet()]
        public IEnumerable<Food> GetByStringOfName([FromQuery] string substring)
        {
            return _manager.GetAll(substring);
        }

        public IEnumerable<Food> GetPurchases()
        {
            return _manager.GetPurchases();
        }
        [HttpGet("{id}")]
        public Food GetById(int id)
        {
            return _manager.GetById(id);
        }
    }
}
