using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the AssetReportRemove operation.
/// </summary>
public sealed record AssetReportRemoveOperationRequest
{
    public required AssetReportRemoveRequest Body { get; init; }
}
