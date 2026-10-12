using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BeaconReportSyndicationList operation.
/// </summary>
public sealed record BeaconReportSyndicationListOperationRequest
{
    public required BeaconReportSyndicationListRequest Body { get; init; }
}
