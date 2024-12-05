using BookStoreApp.Books;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BookStoreApp.Pages.Books;

public class CreateModalModel : BookStoreAppPageModel
{
    [BindProperty]
    public CreateUpdateBookDto Book { get; set; } = new();

    private readonly IBookAppService _bookAppService;

    public CreateModalModel(IBookAppService bookAppService)
    {
        _bookAppService = bookAppService;
    }

    public void OnGet()
    {
        Book = new CreateUpdateBookDto();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _bookAppService.CreateAsync(Book);
        return NoContent();
    }
}
