﻿using Domain;
using FluentValidation;
using MediatR;
using Persistence;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Books
{
    public class Create
    {
        public class Command : IRequest
        {
            public string Id { get; set; }

            public string Title { get; set; }

            public string Gerne { get; set; }

            public string Detail { get; set; }

            public string Other { get; set; }

            public string JAN { get; set; }
        }

        public class CmmandValidator : AbstractValidator<Command>
        {
            public CmmandValidator()
            {

            }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                Domain.Book book = new Domain.Book
                {
                    Title = request.Title,
                    InsTime = DateTime.Now,
                    UpdTime = DateTime.Now,
                };

                _context.Books.Add(book);
                var success = await _context.SaveChangesAsync() > 0;

                if (success) return Unit.Value;

                throw new Exception("Problem saving changes");
            }
        }
    }
}
