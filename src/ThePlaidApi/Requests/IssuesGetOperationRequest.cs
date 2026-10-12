using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the IssuesGet operation.
/// </summary>
public sealed record IssuesGetOperationRequest
{
    public required IssuesGetRequest Body { get; init; }
}
