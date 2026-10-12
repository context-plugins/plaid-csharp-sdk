using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the AssetReportGet operation.
/// </summary>
public sealed record AssetReportGetOperationRequest
{
    public required AssetReportGetRequest Body { get; init; }
}
