using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ApplicationGet operation.
/// </summary>
public sealed record ApplicationGetOperationRequest
{
    public required ApplicationGetRequest Body { get; init; }
}
