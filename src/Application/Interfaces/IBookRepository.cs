using BookstoreApp.Domain.Entities;

namespace BookstoreApp.Application.Interfaces;

public interface IBookRepository
{
    Task<Books?> GetBookByIdAsyc(int id);
}