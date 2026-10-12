using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProcessorAuthGet operation.
/// </summary>
public sealed record ProcessorAuthGetOperationRequest
{
    public required ProcessorAuthGetRequest Body { get; init; }
}
