using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the SessionTokenCreate operation.
/// </summary>
public sealed record SessionTokenCreateOperationRequest
{
    public required SessionTokenCreateRequest Body { get; init; }
}
