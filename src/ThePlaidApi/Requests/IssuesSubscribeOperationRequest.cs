using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the IssuesSubscribe operation.
/// </summary>
public sealed record IssuesSubscribeOperationRequest
{
    public required IssuesSubscribeRequest Body { get; init; }
}
