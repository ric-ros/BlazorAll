namespace BlazorAll.Shared.Models;


public record Product(
    int? Id,
    string? Title,
    string? Description,
    decimal? Price,
    decimal? DiscountPercentage,
    decimal? Rating,
    int? Stock,
    string? Brand,
    string? Category,
    string? Thumbnail,
    string[]? Images
);

public record ProductApiResponse(
    List<Product> Products,
    int Total,
    int Skip,
    int Limit
);