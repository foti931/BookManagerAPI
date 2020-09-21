using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Application.Books;
using API.Controllers;
using MediatR;

namespace BookManagerAPI.Controllers
{
    public class BooksController : BaseController
    {
        private readonly ILogger<BooksController> _logger;

        public BooksController(ILogger<BooksController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<List<Domain.Book>> Books()
        {
            _logger.LogInformation($"get:api/book");
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<Domain.Book> Books(string id)
        {
            _logger.LogInformation($"get:api/book/{id}");
            return await Mediator.Send(new Book.Query() { ID = id });
        }

        [HttpPost]
        public async Task<Unit> Books(Create.Command command)
        {
            _logger.LogInformation($"post:api/book");
            return await Mediator.Send(command);
        }
    }
}
