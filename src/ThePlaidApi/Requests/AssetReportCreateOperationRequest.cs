using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the AssetReportCreate operation.
/// </summary>
public sealed record AssetReportCreateOperationRequest
{
    public required AssetReportCreateRequest Body { get; init; }
}
