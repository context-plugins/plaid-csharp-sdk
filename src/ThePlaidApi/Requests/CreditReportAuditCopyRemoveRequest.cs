using ThePlaidApi.Models;

namespace ThePlaidApi.Requests;

/// <summary>
/// The inputs of the CreditReportAuditCopyRemove operation.
/// </summary>
public sealed record CreditReportAuditCopyRemoveRequest
{
    public required CreditAuditCopyTokenRemoveRequest Body { get; init; }
}
