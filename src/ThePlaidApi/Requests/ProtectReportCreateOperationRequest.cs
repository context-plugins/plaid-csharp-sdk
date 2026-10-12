using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the ProtectReportCreate operation.
/// </summary>
public sealed record ProtectReportCreateOperationRequest
{
    public required ProtectReportCreateRequest Body { get; init; }
}
