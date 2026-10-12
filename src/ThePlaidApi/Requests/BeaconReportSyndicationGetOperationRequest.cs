using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BeaconReportSyndicationGet operation.
/// </summary>
public sealed record BeaconReportSyndicationGetOperationRequest
{
    public required BeaconReportSyndicationGetRequest Body { get; init; }
}
