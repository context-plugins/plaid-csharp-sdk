using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ConsentEventsGet operation.
/// </summary>
public sealed record ConsentEventsGetOperationRequest
{
    public required ConsentEventsGetRequest Body { get; init; }
}
