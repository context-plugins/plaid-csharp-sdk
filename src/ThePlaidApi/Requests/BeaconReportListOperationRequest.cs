using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BeaconReportList operation.
/// </summary>
public sealed record BeaconReportListOperationRequest
{
    public required BeaconReportListRequest Body { get; init; }
}
