using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Application.Books;
using Domain;
using API.Controllers;
using MediatR;

namespace BookManagerAPI.Controllers
{
    [Route("[controller]/[action]")]
    public class BookController : BaseController
    {
        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<List<Book>> Get()
        {
            _logger.LogInformation("Book/Get");
            return await Mediator.Send(new List.Query());
        }

        [HttpPost]
        public async Task<Unit> Register(Create.Command command)
        {
            _logger.LogInformation("Book/Register");
            return await Mediator.Send(command);
        }
    }
}
