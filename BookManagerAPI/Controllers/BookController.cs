using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Application.Books;
using Domain;
using API.Controllers;
using System;
using MediatR;

namespace BookManagerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
        public async Task<Unit> Register()
        {
            _logger.LogInformation("Book/Create");
            return await Mediator.Send(new Create.Command());
        }
    }
}
