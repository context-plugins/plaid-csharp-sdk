using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProcessorAccountGet operation.
/// </summary>
public sealed record ProcessorAccountGetOperationRequest
{
    public required ProcessorAccountGetRequest Body { get; init; }
}
