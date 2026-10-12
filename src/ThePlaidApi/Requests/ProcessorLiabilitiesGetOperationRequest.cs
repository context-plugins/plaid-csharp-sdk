using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProcessorLiabilitiesGet operation.
/// </summary>
public sealed record ProcessorLiabilitiesGetOperationRequest
{
    public required ProcessorLiabilitiesGetRequest Body { get; init; }
}
