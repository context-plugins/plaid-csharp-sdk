using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BeaconReportGet operation.
/// </summary>
public sealed record BeaconReportGetOperationRequest
{
    public required BeaconReportGetRequest Body { get; init; }
}
