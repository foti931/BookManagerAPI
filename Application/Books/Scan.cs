﻿using MediatR;
using Persistence;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Books
{
    public class Scan
    {
        public class Query : IRequest<Domain.Book>
        {
            public int Id { get; set; }
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
                // 取得できなかった場合は空のインスタンスを返す
                return await _context.Books.FindAsync(request.Id) ?? new Domain.Book();
            }
        }
    }
}
