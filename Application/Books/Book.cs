using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Books
{
    public class Book
    {
        public class Query : IRequest<Domain.Book>
        {
            public string ID { get; set; }
        }

        public class Handler : IRequestHandler<Query, Domain.Book>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Domain.Book> Handle(Query request, CancellationToken cancellationToken)
            {
                var id = request.ID;
                var book = await _context.Books.FirstAsync(x => x.Id == id);
                return book;
            }
        }
    }
}
