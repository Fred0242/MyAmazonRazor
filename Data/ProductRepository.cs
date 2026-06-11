using MyAmazonRazor.Models;

namespace MyAmazonRazor.Data;

public class ProductRepository
{
    private static readonly List<Product> _products = new()
    {
        new Product { Id = 1, Name = "Prodotto 1", Price = 10.00m, Category = "Elettronica", Description = "Descrizione del prodotto 1", ImageUrl = "https://picsum.photos/seed/laptop1/400/300" },
        new Product { Id = 2, Name = "Prodotto 2", Price = 2000.99m, Category = "Elettronica", Description = "Descrizione del prodotto 2", ImageUrl = "https://picsum.photos/seed/laptop2/400/300" },
        new Product { Id = 3, Name = "Prodotto 3", Price = 30.50m, Category = "Abbigliamento", Description = "Descrizione del prodotto 3", ImageUrl = "https://picsum.photos/seed/shirt3/400/300" },
        new Product { Id = 4, Name = "Prodotto 4", Price = 499.00m, Category = "Elettrodomestici", Description = "Descrizione del prodotto 4", ImageUrl = "https://picsum.photos/seed/appliance4/400/300" },
        new Product { Id = 5, Name = "Prodotto 5", Price = 15.75m, Category = "Abbigliamento", Description = "Descrizione del prodotto 5", ImageUrl = "https://picsum.photos/seed/shirt5/400/300" }
    };

    public IEnumerable<Product> GetAll() => _products;

    public IEnumerable<string> GetCategories() =>
        _products.Select(p => p.Category).Distinct().OrderBy(c => c);
}
