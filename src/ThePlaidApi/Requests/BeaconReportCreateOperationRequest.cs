using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BeaconReportCreate operation.
/// </summary>
public sealed record BeaconReportCreateOperationRequest
{
    public required BeaconReportCreateRequest Body { get; init; }
}
