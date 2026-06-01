using BookstoreApp.Application.Interfaces;
using BookstoreApp.Domain.Entities;

namespace BookstoreApp.Application.UseCases;

public class GetBookIdQuery
{
    private readonly IBookRepository _bookRepository;

    public GetBookIdQuery(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<Books?> RunGetBooksById(int id)
    {
        return await _bookRepository.GetBookByIdAsync(id);
    }
}