using MediatR;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Books
{
    public class List
    {
        public class Query : IRequest<List<Domain.Book>>
        {
        }

        public class Handler : IRequestHandler<Query, List<Domain.Book>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Domain.Book>> Handle(Query request, CancellationToken cancellationToken)
            {
                var books = await _context.Books.ToListAsync();
                return books;
            }
        }
    }
}