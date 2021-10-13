using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_Library;
using Book_REST_Service.Manager;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Book_REST_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BookManager manager = new BookManager();
        // GET: api/<ValuesController>
        [HttpGet()]
        public IEnumerable<Book> Get([FromQuery] string title, string author)
        {
            return manager.GetList(title,author);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Book Get(string id)
        {
            return manager.GetBookById(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public Book Post([FromBody] Book newBook) //Add
        {
          return manager.AddBook(newBook);

            //{"title":"Learn the basics of C++","author":"Petersen","pageNo":250,"isbN13":"CODE2015"}
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public Book Put(string id, [FromBody] Book update) //Update
        {
           return manager.UpdateBook(id,update);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public Book Delete(string id)
        {
          return manager.DeleteBook(id);
        }
    }
}
