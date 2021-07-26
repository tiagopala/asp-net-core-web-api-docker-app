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
                return BadRequest(new { Message = $"{e.Message}" });
            }
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get(string id)
        {
            try
            {
                var book = await _booksRepository.Get(id);

                if (book is null)
                    return NotFound(new { Message = "Livro não encontrado" });

                return Ok(book);
            }
            catch (Exception e)
            {
                return BadRequest(new { Message = $"{e.Message}" });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] Book book)
        {
            try
            {
                var createdBook = await _booksRepository.Save(book);

                return Ok(new { Message = $"Livro '{book.Id}' cadastrado com sucesso" });
            }
            catch (Exception e)
            {
                return BadRequest(new { Message = $"{e.Message}" });
            }
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Update(Guid id,[FromBody]Book book)
        {
            try
            {
                var livroAtualizado = new Book
                {
                    Id = id.ToString(),
                    Name = book.Name,
                    Description = book.Description,
                    Price = book.Price,
                    Author = book.Author
                };

                await _booksRepository.Update(livroAtualizado);

                return Ok(new { Message = "Livro atualizado com sucesso" });
            }
            catch (Exception e)
            {
                return BadRequest(new { Message = $"{e.Message}" });
            }
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                await _booksRepository.Delete(id);

                return Ok(new { Message = "Livro deletado com sucesso" });
            }
            catch (Exception e)
            {
                return BadRequest(new { Message = $"{e.Message}" });
            }
        }
    }
}
