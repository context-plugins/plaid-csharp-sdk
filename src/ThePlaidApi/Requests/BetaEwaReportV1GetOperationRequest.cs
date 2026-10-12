using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the BetaEwaReportV1Get operation.
/// </summary>
public sealed record BetaEwaReportV1GetOperationRequest
{
    public required BetaEwaReportV1GetRequest Body { get; init; }
}
