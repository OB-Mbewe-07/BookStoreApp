using BookstoreApp.Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreApp.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private readonly GetBookIdQuery _query;

    public BooksController(GetBookIdQuery query)
    {
        _query = query;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetBooksById(int id)
    {
        var book = await _query.RunGetBooksById(id);
        return book is null ? NotFound() : Ok(book);
    }
}