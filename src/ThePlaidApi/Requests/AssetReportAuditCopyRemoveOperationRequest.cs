using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the AssetReportAuditCopyRemove operation.
/// </summary>
public sealed record AssetReportAuditCopyRemoveOperationRequest
{
    public required AssetReportAuditCopyRemoveRequest Body { get; init; }
}
