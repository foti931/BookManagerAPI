﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;
using System.Threading.Tasks;
using System.Threading;
using Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Books
{
    public class List
    {
        public class Query : IRequest<List<Book>>
        {
        }

        public class Handler : IRequestHandler<Query, List<Book>>
        {

            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Book>> Handle(Query request, CancellationToken cancellationToken)
            {
                var books = await _context.Books.ToListAsync();
                return books;
            }
        }
    }
}