using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the IssuesSearch operation.
/// </summary>
public sealed record IssuesSearchOperationRequest
{
    public required IssuesSearchRequest Body { get; init; }
}
