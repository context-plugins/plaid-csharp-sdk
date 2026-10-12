using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ItemImport operation.
/// </summary>
public sealed record ItemImportOperationRequest
{
    public required ItemImportRequest Body { get; init; }
}
