using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreditAssetReportFreddieMacGet operation.
/// </summary>
public sealed record CreditAssetReportFreddieMacGetRequest
{
    public required AssetReportFreddieGetRequest Body { get; init; }
}
