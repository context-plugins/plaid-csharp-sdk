using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the UserProductsTerminate operation.
/// </summary>
public sealed record UserProductsTerminateOperationRequest
{
    public required UserProductsTerminateRequest Body { get; init; }
}
