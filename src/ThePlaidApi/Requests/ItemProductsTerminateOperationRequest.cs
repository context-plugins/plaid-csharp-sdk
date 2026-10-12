using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ItemProductsTerminate operation.
/// </summary>
public sealed record ItemProductsTerminateOperationRequest
{
    public required ItemProductsTerminateRequest Body { get; init; }
}
