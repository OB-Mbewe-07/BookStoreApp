using BookstoreApp.Application.Interfaces;
using BookstoreApp.Domain.Entities;
using BookstoreApp.Infrastructure.Persistence;

namespace BookstoreApp.Infrastructure.Repositories;

public class BookRepository : IBookRepository
{
    private readonly AppDbContext _context;

    public BookRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Books?> GetBookByIdAsync(int id)
    {
        return await _context.Books.FindAsync(id);
    }
}