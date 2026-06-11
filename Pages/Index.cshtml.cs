using Microsoft.AspNetCore.Mvc.RazorPages;
using MyAmazonRazor.Data;
using MyAmazonRazor.Models;

namespace MyAmazonRazor.Pages;

public class IndexModel : PageModel
{
    private readonly ProductRepository _repository;

    public IndexModel(ProductRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Product> Products { get; private set; } = Enumerable.Empty<Product>();

    public void OnGet()
    {
        Products = _repository.GetAll();
    }
}