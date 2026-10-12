namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CategoriesGet operation.
/// </summary>
public sealed record CategoriesGetRequest
{
    public required object Body { get; init; }
}
