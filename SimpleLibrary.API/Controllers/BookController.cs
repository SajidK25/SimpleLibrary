using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleLibrary.Core.Entities;
using SimpleLibrary.Core.Services;

namespace SimpleLibrary.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private IBookService _bookService;
        public BookController(ILogger<BookController> logger,IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        [HttpGet("/api/Library/book/GetBooks")]
        public IEnumerable<Book> Get()
        {
            return _bookService.Get();
        }
        
        [HttpPost("/api/Library/book/SaveBook")]
        public IActionResult Post([FromBody]Book book)
        {
            try
            {
                _bookService.AddNewBook(book);
                return Ok(book);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}