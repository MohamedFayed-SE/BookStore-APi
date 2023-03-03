using AutoMapper;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
       

        public BookController(IBookService bookService,IMapper mapper)
        {
            _bookService = bookService;
           
        }


        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult>GetAll()
        {

            var result = await _bookService.GetBooksAsync();

            return Ok(result);
        }

    }
}
