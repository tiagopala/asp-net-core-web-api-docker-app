using AspNetCoreWebApiDockerApp.Api.Models;
using AspNetCoreWebApiDockerApp.Api.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AspNetCoreWebApiDockerApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBooksRepository _booksRepository;

        public BooksController(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var books = await _booksRepository.GetAll();

                if (books.Count.Equals(0))
                    return NotFound(new { Message = "Nenhum livro encontrado" });

                return Ok(books);
            }
            catch (Exception e)
            {
                return BadRequest(new { Message = "Nenhum livro encontrado" });
            }
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
