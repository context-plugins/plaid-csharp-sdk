using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProcessorIdentityMatch operation.
/// </summary>
public sealed record ProcessorIdentityMatchOperationRequest
{
    public required ProcessorIdentityMatchRequest Body { get; init; }
}
