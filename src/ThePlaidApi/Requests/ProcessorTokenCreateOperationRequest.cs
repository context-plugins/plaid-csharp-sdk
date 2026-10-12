using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProcessorTokenCreate operation.
/// </summary>
public sealed record ProcessorTokenCreateOperationRequest
{
    public required ProcessorTokenCreateRequest Body { get; init; }
}
