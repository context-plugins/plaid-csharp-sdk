using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the AssetReportAuditCopyPdfGet operation.
/// </summary>
public sealed record AssetReportAuditCopyPdfGetOperationRequest
{
    public required AssetReportAuditCopyPdfGetRequest Body { get; init; }
}
