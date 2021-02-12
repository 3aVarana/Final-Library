using System;
using System.Threading.Tasks;
using FinalLibrary.Database;
using FinalLibrary.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace FinalLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ILibraryRepository _libraryRepository;
        private readonly LinkGenerator _linkGenerator;

        public BooksController(ILibraryRepository libraryRepository, LinkGenerator linkGenerator)
        {
            this._libraryRepository = libraryRepository;
            this._linkGenerator = linkGenerator;
        }

        [HttpGet]
        public async Task<ActionResult<Book[]>> Get()
        {
            try
            {
                var books = await _libraryRepository.GetAllBooksAsync();

                if (books == null)
                {
                    return NotFound("There are not books to show");
                }
                else
                {
                    return Ok(books);
                }
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, e.ToString());
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Book[]>> Get(int id)
        {
            try
            {
                var book = await _libraryRepository.GetBookByIdAsync(id);

                if (book == null)
                {
                    return NotFound($"Book with id {id} was not found");
                }
                else
                {
                    return Ok(book);
                }
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, e.ToString());
            }
        }
    }
}
