using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the LinkTokenCreate operation.
/// </summary>
public sealed record LinkTokenCreateOperationRequest
{
    public required LinkTokenCreateRequest Body { get; init; }
}
