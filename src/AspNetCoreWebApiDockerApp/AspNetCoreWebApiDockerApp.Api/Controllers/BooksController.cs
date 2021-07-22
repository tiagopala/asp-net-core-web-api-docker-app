using AspNetCoreWebApiDockerApp.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AspNetCoreWebApiDockerApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet("{id:guid}")]
        public IActionResult Get(Guid id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Save([FromBody] Book book)
        {
            return Ok();
        }

        [HttpPut("{id:guid}")]
        public IActionResult Update(Guid id)
        {
            return Ok();
        }

        [HttpDelete("{id:guid}")]
        public IActionResult Delete(Guid id)
        {
            return Ok();
        }
    }
}
