using BookstoreApp.Domain.Entities;

namespace BookstoreApp.Application.Interfaces;

public interface IBookRepository
{
    Task<Books?> GetBookByIdAsync(int id);
    Task<IEnumerable<Books>> GetAllBooksAsync();
    Task<Books> CreateAsync(Books book);
    Task<Books?> UpdateAsync(Books book);
    Task<bool> DeleteAsync(int id);
}