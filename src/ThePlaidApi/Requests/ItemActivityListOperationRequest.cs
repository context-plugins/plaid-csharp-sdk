using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ItemActivityList operation.
/// </summary>
public sealed record ItemActivityListOperationRequest
{
    public required ItemActivityListRequest Body { get; init; }
}
