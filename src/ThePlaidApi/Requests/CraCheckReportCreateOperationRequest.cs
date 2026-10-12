using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CraCheckReportCreate operation.
/// </summary>
public sealed record CraCheckReportCreateOperationRequest
{
    public required CraCheckReportCreateRequest Body { get; init; }
}
