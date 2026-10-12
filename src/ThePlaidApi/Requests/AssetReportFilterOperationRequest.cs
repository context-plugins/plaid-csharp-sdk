using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the AssetReportFilter operation.
/// </summary>
public sealed record AssetReportFilterOperationRequest
{
    public required AssetReportFilterRequest Body { get; init; }
}
